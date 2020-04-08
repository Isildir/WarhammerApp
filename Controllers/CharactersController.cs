using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WarhammerProfessionApp.Dtos;
using WarhammerProfessionApp.Entities;
using WarhammerProfessionApp.Entities.Models;
using WarhammerProfessionApp.Entities.Models.Enums;
using WarhammerProfessionApp.SignalR;
using WarhammerProfessionApp.Utility;

namespace WarhammerProfessionApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class CharactersController : ControllerBase
    {
        public CharactersController(ProfessionsContext context, CharacterHub characterHub)
        {
            this.context = context;
            this.characterHub = characterHub;
        }

        [HttpPost(nameof(AddAbility))]
        public ActionResult<CharacterChangeResponseDto> AddAbility([FromBody] int id)
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.Abilities)
                .Include(a => a.Professions).ThenInclude(a => a.Profession).ThenInclude(a => a.Statistics).ThenInclude(a => a.Statistic)
                .Include(a => a.Statistics).ThenInclude(a => a.Statistic)
                .FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!CheckCharacterExperienceLimit(character, 100))
                return BadRequest();

            var ability = context.Abilities.Find(id);

            if (ability == null || character.Abilities.Any(a => a.AbilityId == id))
                return BadRequest();

            character.ExperienceUsed += 100;
            character.Abilities.Add(new CharacterAbility { AbilityId = id });

            CharacterStatistic characterStatistic = null;

            if (ability.HasImpactOnStatictics)
            {
                characterStatistic = character.Statistics.FirstOrDefault(a => a.Statistic.Type == ability.ValueToAlter.Value);

                characterStatistic.CurrentValue += ability.ImpactValue.Value;
            }

            context.SaveChanges();

            SendMessageAboutExperienceChange(character);

            if (ability.HasImpactOnStatictics)
                SendMessageAboutStatisticValueChange(character, characterStatistic);

            return Ok(ability.HasImpactOnStatictics);
        }

        [HttpPost(nameof(AddAdditionalItem))]
        public ActionResult<CharacterChangeResponseDto> AddAdditionalItem([FromBody] CharacterItemDto value)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.AdditionalValues).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            character.AdditionalItems.Add(new AdditionalCharacterItem
            {
                Name = value.Name,
                Weigth = value.Weigth,
                Quantity = value.Quantity,
                Description = value.Description
            });

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(AddAdditionalValue))]
        public ActionResult<CharacterChangeResponseDto> AddAdditionalValue([FromBody] AdditionalCharacterValueDto value)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.AdditionalValues).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!CheckCharacterExperienceLimit(character, 100))
                return BadRequest();

            character.ExperienceUsed += 100;
            character.AdditionalValues.Add(new AdditionalCharacterValue { Name = value.Name });

            context.SaveChanges();

            SendMessageAboutExperienceChange(character);

            return Ok(false);
        }

        [HttpPost(nameof(AddItem))]
        public ActionResult AddItem(ModifyCharacterItemDto value)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.Items).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (context.Items.Any(a => a.Id == value.Id))
                return BadRequest();

            var item = context.Items.FirstOrDefault(a => a.Id == value.Id);

            if (value.ChangeMoney)
            {
                if (character.Money < item.Price)
                    return BadRequest("No za mało kasiorki byczku");

                character.Money -= character.Money - item.Price;
            }

            character.Items.Add(new CharacterItem
            {
                ItemId = value.Id,
                Quantity = 1
            });

            context.SaveChanges();

            if (value.ChangeMoney)
                SendMessageAboutMoneyChange(character);

            return Ok();
        }

        [HttpPost(nameof(AddSkill))]
        public ActionResult<CharacterChangeResponseDto> AddSkill([FromBody] int id)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.Skills).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!CheckCharacterExperienceLimit(character, 100))
                return BadRequest();

            var characterSkill = character.Skills.FirstOrDefault(a => a.SkillId == id);

            if (!context.Skills.Any(a => a.Id == id) || (characterSkill != null && characterSkill.Level >= 3))
                return BadRequest();

            character.ExperienceUsed += 100;

            if (characterSkill == null)
                character.Skills.Add(new CharacterSkill { SkillId = id, Level = 1 });
            else
                characterSkill.Level++;

            context.SaveChanges();

            SendMessageAboutExperienceChange(character);

            return Ok(false);
        }

        [HttpPost(nameof(ChangeBaseStatisticValue))]
        public ActionResult<CharacterChangeResponseDto> ChangeBaseStatisticValue([FromBody] BaseStatiticValueChangeDto value)
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.Professions).ThenInclude(a => a.Profession).ThenInclude(a => a.Statistics).ThenInclude(a => a.Statistic)
                .Include(a => a.Statistics)
                .ThenInclude(a => a.Statistic)
                .FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var characterStatistic = character.Statistics.FirstOrDefault(a => a.Statistic.Type == value.Type);

            characterStatistic.CurrentValue -= characterStatistic.BaseValue;
            characterStatistic.BaseValue = value.Value;
            characterStatistic.CurrentValue += characterStatistic.BaseValue;

            context.SaveChanges();

            SendMessageAboutStatisticValueChange(character, characterStatistic);

            return Ok();
        }

        [HttpPost(nameof(ChangeCharacterMaximumExperience))]
        public ActionResult<CharacterChangeResponseDto> ChangeCharacterMaximumExperience([FromBody] int value)
        {
            var character = GetUserCharacter();

            if (character == null)
                return NotFound();

            character.ExperienceSummary = value;

            context.SaveChanges();

            SendMessageAboutExperienceChange(character);

            return Ok(false);
        }

        [HttpPost(nameof(ChangeCharacterMoney))]
        public ActionResult<CharacterChangeResponseDto> ChangeCharacterMoney([FromBody] MoneyDto value)
        {
            var character = GetUserCharacter();

            if (character == null)
                return NotFound();

            character.Money = MoneyCalculator.GetUserMoney(value.Gold, value.Silver, value.Bronze);

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(ChangeCharacterName))]
        public ActionResult<CharacterChangeResponseDto> ChangeCharacterName([FromBody] string name)
        {
            var character = GetUserCharacter();

            if (character == null)
                return NotFound();

            character.Name = name;

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(ChangeCharacterNotes))]
        public ActionResult<bool> ChangeCharacterNotes([FromBody] string value)
        {
            var userId = GetUserId();

            var character = context.Characters.FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            character.Notes = value;

            context.SaveChanges();

            return Ok();
        }

        [HttpPost(nameof(ChangeStatisticValue))]
        public ActionResult<CharacterChangeResponseDto> ChangeStatisticValue([FromBody] StatiticValueChangeDto value)
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.Professions).ThenInclude(a => a.Profession).ThenInclude(a => a.Statistics).ThenInclude(a => a.Statistic)
                .Include(a => a.Statistics)
                .ThenInclude(a => a.Statistic)
                .FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var characterStatistic = character.Statistics.FirstOrDefault(a => a.Statistic.Type == value.Type);

            if (characterStatistic.Statistic.IsCalculatedValue)
                return BadRequest();

            var incrementValue = characterStatistic.Statistic.IsBasicValue ? 5 : 1;

            var maximumValue = GetTotalStatisticMaximumValue(characterStatistic.Statistic.Type, character, out int professionValue, out Dictionary<string, int> _);

            if (value.IncrementingValue)
            {
                if (!CheckCharacterExperienceLimit(character, 100) || characterStatistic.CurrentValue + incrementValue > maximumValue)
                    return BadRequest("Za mało punktów doświadczenia lub przekroczono limit");

                character.ExperienceUsed += 100;
                characterStatistic.CurrentValue += incrementValue;
            }
            else
            {
                if (characterStatistic.CurrentValue - incrementValue < maximumValue - professionValue)
                    return BadRequest("Przekroczono dolną granicę");

                character.ExperienceUsed -= 100;
                characterStatistic.CurrentValue -= incrementValue;
            }

            context.SaveChanges();

            SendMessageAboutExperienceChange(character);

            SendMessageAboutStatisticValueChange(character, characterStatistic);

            return Ok(characterStatistic.Statistic.Type == StatisticType.Stamina || characterStatistic.Statistic.Type == StatisticType.Resistance);
        }

        [HttpGet]
        public async Task<ActionResult<CharacterDto>> GetCharacter()
        {
            var userId = GetUserId();

            var character = await context.Characters
                .Include(a => a.Professions).ThenInclude(a => a.Profession).ThenInclude(a => a.Statistics).ThenInclude(a => a.Statistic)
                .Include(a => a.Skills).ThenInclude(a => a.Skill)
                .Include(a => a.Abilities).ThenInclude(a => a.Ability)
                .Include(a => a.Items).ThenInclude(a => a.Item)
                .Include(a => a.Statistics).ThenInclude(a => a.Statistic)
                .Include(a => a.AdditionalItems)
                .Include(a => a.AdditionalValues)
                .FirstOrDefaultAsync(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var money = MoneyCalculator.ConvertMoney(character.Money);
            var load = character.Items.Any() ? character.Items.Sum(a => a.Quantity * a.Item.Weigth) : 0;

            var basicValues = new CharacterBasicValuesDto
            {
                Id = character.Id,
                ActualProfessionName = character.CurrentProfession?.Name,
                ExperienceLeft = character.ExperienceSummary - character.ExperienceUsed,
                ExperienceSum = character.ExperienceSummary,
                Name = character.Name,
                Notes = character.Notes,
                CurrentLoad = $"{load} / {character.Statistics.FirstOrDefault(a => a.Statistic.Type == StatisticType.Stamina).CurrentValue * 10}",
                Race = character.Race != null ? new RaceDto
                {
                    Id = (int)character.Race,
                    Name = character.Race.ToString()
                } : null
            };

            var professions = character.Professions.Select(a => new ShortProfessionDto { Id = a.Profession.Id, Name = a.Profession.Name }).ToList();

            var additionalItems = character.AdditionalItems.Select(a => new CharacterItemDto
            {
                Id = a.Id,
                Name = a.Name,
                Weigth = a.Weigth,
                Quantity = a.Quantity,
                Description = a.Description
            }).ToList(); ;

            var additionalValues = character.AdditionalValues.Select(a => new AdditionalCharacterValueDto
            {
                Id = a.Id,
                Name = a.Name
            }).ToList();

            var skills = character.Skills.Select(a => new CharacterSkillDto
            {
                Id = a.SkillId,
                Name = a.Skill.Name,
                Trait = EnumTranslator.TranslateStaticticValue(a.Skill.Trait),
                Description = a.Skill.Description,
                Level = a.Level,
                SkillLevel = a.Skill.SkillLevel.ToString()
            }).ToList();

            var abilities = character.Abilities.Select(a => new AbilityDto
            {
                Id = a.AbilityId,
                Name = a.Ability.Name,
                Description = a.Ability.Description
            }).ToList();

            var items = character.Items.Select(a => new CharacterItemDto
            {
                Id = a.Item.Id,
                Name = a.Item.Name,
                Weigth = a.Item.Weigth,
                Description = a.Item.Description,
                Quantity = a.Quantity
            }).ToList();

            var statistics = new List<Tuple<bool, CharacterStatisticDto>>();

            foreach (var value in character.Statistics)
            {
                var maximumValue = GetTotalStatisticMaximumValue(value.Statistic.Type, character, out int professionValue, out Dictionary<string, int> abilitiesValues);
                var staticValues = abilitiesValues.Any() ? abilitiesValues.Sum(a => a.Value) : 0;

                var result = new CharacterStatisticDto
                {
                    Type = value.Statistic.Type,
                    Name = EnumTranslator.TranslateStaticticValue(value.Statistic.Type),
                    IsReadOnly = value.Statistic.IsReadOnly,
                    BaseValue = value.BaseValue,
                    CurrentValue = value.CurrentValue,
                    MaximumValue = maximumValue,
                    Details = $"Bazowe {value.BaseValue}",
                };

                if (value.Statistic.Type == StatisticType.Hardness)
                {
                    var val = character.Statistics.FirstOrDefault(a => a.Statistic.Type == StatisticType.Resistance).CurrentValue / 10;

                    result.BaseValue = val;
                    result.CurrentValue = val;
                    result.MaximumValue = val;
                }
                else if (value.Statistic.Type == StatisticType.Strength)
                {
                    var val = character.Statistics.FirstOrDefault(a => a.Statistic.Type == StatisticType.Stamina).CurrentValue / 10;

                    result.BaseValue = val;
                    result.CurrentValue = val;
                    result.MaximumValue = val;
                }

                if (value.Statistic.IsCalculatedValue)
                {
                    result.CanBeDecreased = false;
                    result.CanBeIncreased = false;
                }
                else
                {
                    result.CanBeDecreased = value.CurrentValue > value.BaseValue + staticValues;
                    result.CanBeIncreased = value.CurrentValue < maximumValue;
                }

                if (character.Professions.Any())
                    result.Details += $" + {professionValue} z rozwoju";

                if (abilitiesValues.Any())
                    result.Details += $" + {string.Join(',', abilitiesValues.Select(a => $"{a.Value} z {a.Key}"))}";

                statistics.Add(new Tuple<bool, CharacterStatisticDto>(value.Statistic.IsBasicValue, result));
            }

            return Ok(new CharacterDto
            {
                Money = money,
                Items = items,
                Skills = skills,
                Abilities = abilities,
                BasicValues = basicValues,
                Professions = professions,
                AdditionalItems = additionalItems,
                AdditionalValues = additionalValues,
                BasicStatistics = statistics.Where(a => a.Item1).Select(a => a.Item2).ToList(),
                AdvancedStatistics = statistics.Where(a => !a.Item1).Select(a => a.Item2).ToList()
            });
        }

        [HttpGet(nameof(GetFilteredAbilities))]
        public async Task<ActionResult<AbilityDto>> GetFilteredAbilities()
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.Abilities)
                .Include(a => a.Professions)
                .ThenInclude(a => a.Profession)
                .ThenInclude(a => a.Abilities)
                .ThenInclude(a => a.Abilities)
                .ThenInclude(a => a.Ability)
                .FirstOrDefault(a => a.UserId == userId);

            var availableAbilities = character.Professions.SelectMany(a => a.Profession.Abilities.SelectMany(b => b.Abilities.Select(c => c.Ability))).ToList();
            var availableAbilitiesIds = availableAbilities.Select(c => c.Id).Distinct().ToList();
            var takenAbilitiesIds = character.Abilities.Select(a => a.AbilityId).ToList();

            var filteredAbilitiesIds = availableAbilitiesIds.Where(a => !takenAbilitiesIds.Contains(a)).ToList();

            var values = filteredAbilitiesIds.Select(a => availableAbilities.FirstOrDefault(b => b.Id == a)).Select(a => new AbilityDto
            {
                Id = a.Id,
                Name = a.Name
            }).ToList();

            return Ok(values);
        }

        [HttpGet(nameof(GetFilteredItems))]
        public async Task<ActionResult<ItemDto>> GetFilteredItems()
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.Items)
                .FirstOrDefault(a => a.UserId == userId);

            var takenItemsIds = character.Items.Select(a => a.ItemId).ToList();

            var values = context.Items.Where(a => !takenItemsIds.Contains(a.Id)).Select(a => new
            {
                a.Id,
                a.Name,
                a.Price,
                a.Weigth
            }).ToList();

            var convertedValues = new List<ItemDto>();

            foreach (var item in values)
            {
                var money = MoneyCalculator.ConvertMoney(item.Price);

                var value = new ItemDto
                {
                    Id = item.Id,
                    Name = item.Name,
                    Weigth = item.Weigth,
                    Gold = money.Gold,
                    Silver = money.Silver,
                    Bronze = money.Bronze
                };

                convertedValues.Add(value);
            }

            return Ok(convertedValues);
        }

        [HttpGet(nameof(GetFilteredProfessions))]
        public async Task<ActionResult<ShortProfessionDto>> GetFilteredProfessions()
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.Professions)
                .Include(a => a.Statistics).ThenInclude(a => a.Statistic)
                .Include(a => a.Professions).ThenInclude(a => a.Profession).ThenInclude(a => a.Skills).ThenInclude(a => a.Skills)
                .Include(a => a.Professions).ThenInclude(a => a.Profession).ThenInclude(a => a.Abilities).ThenInclude(a => a.Abilities)
                .FirstOrDefault(a => a.UserId == userId);

            if (!CheckIfProfessionsAreFinished(character))
                return Ok();

            var characterProfessions = character.Professions.Select(a => a.ProfessionId).ToList();

            var values = context.Professions.Where(a => !characterProfessions.Contains(a.Id));

            if (character.CurrentProfessionId.HasValue)
                values = values.Where(a => a.EntranceProfessions.Any(b => b.EntranceProfessionId == character.CurrentProfessionId.Value));
            else
                values = values.Where(a => a.ProfessionLevel == ProfessionLevel.Basic);

            return Ok(values.Select(a => new ShortProfessionDto { Id = a.Id, Name = a.Name }).ToList());
        }

        [HttpGet(nameof(GetFilteredSkills))]
        public async Task<ActionResult<CharacterSkillGetDto>> GetFilteredSkills()
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.Skills)
                .Include(a => a.Professions)
                .ThenInclude(a => a.Profession)
                .ThenInclude(a => a.Skills)
                .ThenInclude(a => a.Skills)
                .ThenInclude(a => a.Skill)
                .FirstOrDefault(a => a.UserId == userId);

            var takenSkills = character.Skills.ToDictionary(a => a.SkillId, a => a.Level);
            var availableSkills = character.Professions
                .SelectMany(a => a.Profession.Skills.SelectMany(b => b.Skills.Select(c => c.Skill)));

            var groupedAvailableSkills = availableSkills.GroupBy(a => a.Id).ToDictionary(a => a.Key, a => a.Count());

            var values = new List<CharacterSkillGetDto>();

            foreach (var skill in groupedAvailableSkills)
            {
                var record = availableSkills.FirstOrDefault(a => a.Id == skill.Key);

                if (!takenSkills.ContainsKey(skill.Key))
                    values.Add(new CharacterSkillGetDto
                    {
                        Id = record.Id,
                        Name = record.Name,
                        Level = 1
                    });
                else if (takenSkills.ContainsKey(skill.Key) && takenSkills[skill.Key] < skill.Value)
                    values.Add(new CharacterSkillGetDto
                    {
                        Id = record.Id,
                        Name = record.Name,
                        Level = takenSkills[skill.Key] + 1
                    });
            }

            return Ok(values);
        }

        [HttpGet(nameof(GetRaces))]
        public async Task<ActionResult<RaceDto>> GetRaces()
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.Professions)
                .ThenInclude(a => a.Profession)
                .FirstOrDefault(a => a.UserId == userId);

            var values = SortAvailableRaces(character);

            return Ok(values);
        }

        [HttpPost(nameof(ModifyAdditionalItem))]
        public ActionResult<CharacterChangeResponseDto> ModifyAdditionalItem([FromBody] CharacterItemDto value)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.AdditionalItems).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var characterValue = character.AdditionalItems.FirstOrDefault(a => a.Id == value.Id);

            if (characterValue == null)
                return BadRequest();

            characterValue.Name = value.Name;
            characterValue.Weigth = value.Weigth;
            characterValue.Quantity = value.Quantity;
            characterValue.Description = value.Description;

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(ModifyExcerienceCostValue))]
        public ActionResult<CharacterChangeResponseDto> ModifyExcerienceCostValue([FromBody] AdditionalCharacterValueDto value)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.AdditionalValues).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!character.AdditionalValues.Any(a => a.Id == value.Id))
                return BadRequest();

            character.AdditionalValues.FirstOrDefault(a => a.Id == value.Id).Name = value.Name;

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(ModifyItem))]
        public ActionResult<int> ModifyItem(ModifyCharacterItemDto value)
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.Items)
                .ThenInclude(a => a.Item)
                .FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!context.Items.Any(a => a.Id == value.Id))
                return BadRequest();

            var item = character.Items.FirstOrDefault(a => a.ItemId == value.Id);

            if (value.ChangeMoney)
            {
                var change = value.Quantity - item.Quantity;

                if (change != 0)
                {
                    if (change > 0 && character.Money < item.Item.Price * change)
                        return BadRequest("No za mało kasiorki byczku");

                    character.Money += item.Item.Price * change;
                }
            }

            item.Quantity = value.Quantity;

            context.SaveChanges();

            if (value.ChangeMoney)
                SendMessageAboutMoneyChange(character);

            return Ok();
        }

        [HttpDelete(nameof(RemoveAbility))]
        public ActionResult<CharacterChangeResponseDto> RemoveAbility(int id)
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.Abilities)
                .Include(a => a.Professions)
                .ThenInclude(a => a.Profession).ThenInclude(a => a.Statistics).ThenInclude(a => a.Statistic)
                .FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var ability = context.Abilities.Find(id);

            var characterAbility = character.Abilities.FirstOrDefault(a => a.AbilityId == id);

            if (ability == null || characterAbility == null)
                return BadRequest();

            character.ExperienceUsed -= 100;
            character.Abilities.Remove(characterAbility);

            CharacterStatistic characterStatistic = null;

            if (ability.HasImpactOnStatictics)
            {
                characterStatistic = character.Statistics.FirstOrDefault(a => a.Statistic.Type == ability.ValueToAlter.Value);

                characterStatistic.CurrentValue -= ability.ImpactValue.Value;
            }

            context.SaveChanges();

            SendMessageAboutExperienceChange(character);

            if (ability.HasImpactOnStatictics)
                SendMessageAboutStatisticValueChange(character, characterStatistic);

            return Ok(ability.HasImpactOnStatictics);
        }

        [HttpDelete(nameof(RemoveAdditionalItem))]
        public ActionResult<CharacterChangeResponseDto> RemoveAdditionalItem(int id)
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.AdditionalItems)
                .FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var value = character.AdditionalItems.FirstOrDefault(a => a.Id == id);

            if (value == null)
                return BadRequest();

            character.AdditionalItems.Remove(value);

            context.SaveChanges();

            return Ok(false);
        }

        [HttpDelete(nameof(RemoveAdditionalValue))]
        public ActionResult<CharacterChangeResponseDto> RemoveAdditionalValue(int id)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.AdditionalValues).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!character.AdditionalValues.Any(a => a.Id == id))
                return BadRequest();

            character.ExperienceUsed -= 100;
            character.AdditionalValues.Remove(character.AdditionalValues.First(a => a.Id == id));

            context.SaveChanges();

            SendMessageAboutExperienceChange(character);

            return Ok(false);
        }

        [HttpPost(nameof(RemoveItem))]
        public ActionResult<int> RemoveItem([FromBody] ModifyCharacterItemDto value)
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.Items)
                .ThenInclude(a => a.Item)
                .FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!context.Items.Any(a => a.Id == value.Id))
                return BadRequest();

            var item = character.Items.FirstOrDefault(a => a.ItemId == value.Id);

            if (value.ChangeMoney)
                character.Money += item.Item.Price * item.Quantity;

            character.Items.Remove(item);

            context.SaveChanges();

            if (value.ChangeMoney)
                SendMessageAboutMoneyChange(character);

            return Ok();
        }

        [HttpPost(nameof(RemoveLastCharacterProfession))]
        public ActionResult<CharacterChangeResponseDto> RemoveLastCharacterProfession()
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.Professions).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!character.Professions.Any())
                return BadRequest();

            var maxProfessionOrder = character.Professions.Max(a => a.Order);
            var professionToRemove = character.Professions.First(a => a.Order == maxProfessionOrder);

            character.Professions.Remove(professionToRemove);

            if (character.CurrentProfessionId.HasValue && character.CurrentProfessionId.Value == professionToRemove.ProfessionId)
            {
                var targetProfession = context.Professions
                    .Include(a => a.Skills)
                    .Include(a => a.Abilities)
                    .FirstOrDefault(a => a.Id == professionToRemove.ProfessionId);

                character.CurrentProfessionId = null;
                character.ExperienceSummary -= targetProfession.Skills.Sum(a => a.Quantity * 100) + targetProfession.Abilities.Sum(a => a.Quantity * 100);
            }

            if (maxProfessionOrder > 1)
                character.ExperienceUsed -= 100;

            context.SaveChanges();

            SendMessageAboutExperienceChange(character);

            return Ok(false);
        }

        [HttpDelete(nameof(RemoveSkill))]
        public ActionResult<CharacterChangeResponseDto> RemoveSkill(int id)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.Skills).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var skill = character.Skills.FirstOrDefault(a => a.SkillId == id);

            if (skill == null)
                return BadRequest();

            character.ExperienceUsed -= 100;

            if (skill.Level <= 1)
                character.Skills.Remove(skill);
            else
                skill.Level--;

            context.SaveChanges();

            SendMessageAboutExperienceChange(character);

            return Ok(false);
        }

        [HttpPost(nameof(SetCharacterRace))]
        public ActionResult<CharacterChangeResponseDto> SetCharacterRace([FromBody] int id)
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.Professions)
                .ThenInclude(a => a.Profession)
                .FirstOrDefault(a => a.UserId == userId);

            var values = SortAvailableRaces(character);

            if (!values.Any(a => a.Id == id))
                return BadRequest();

            character.Race = (Race)id;

            context.SaveChanges();

            return Ok();
        }

        [HttpPost(nameof(SetNextCharacterProfession))]
        public ActionResult<CharacterChangeResponseDto> SetNextCharacterProfession([FromBody] int id)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.Professions).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var targetProfession = context.Professions
                .Include(a => a.EntranceProfessions)
                .Include(a => a.Skills)
                .Include(a => a.Abilities)
                .FirstOrDefault(a => a.Id == id);

            if (targetProfession == null || character.Professions.Any(a => a.ProfessionId == id))
                return BadRequest();

            if (character.CurrentProfessionId.HasValue && !targetProfession.EntranceProfessions.Any(a => a.EntranceProfessionId == character.CurrentProfessionId.Value))
                return BadRequest();

            var maxProfessionOrder = character.Professions.Any() ? character.Professions.Max(a => a.Order) : (byte)0;

            if (character.CurrentProfessionId.HasValue)
                character.ExperienceUsed += 100;
            else
                character.ExperienceSummary += targetProfession.Skills.Sum(a => a.Quantity * 100) + targetProfession.Abilities.Sum(a => a.Quantity * 100);

            character.CurrentProfessionId = id;
            character.Professions.Add(new CharacterProfession
            {
                Profession = targetProfession,
                Order = ++maxProfessionOrder
            });

            context.SaveChanges();

            SendMessageAboutExperienceChange(character);

            return Ok(true);
        }

        private readonly CharacterHub characterHub;

        private readonly ProfessionsContext context;

        private bool CheckCharacterExperienceLimit(Character character, int value) => character.ExperienceSummary - character.ExperienceUsed >= value;

        private bool CheckIfProfessionsAreFinished(Character character)
        {
            var allCharacterSkillsIds = character.Skills.Select(a => a.SkillId).ToList();
            var allCharacterAbilitiesIds = character.Abilities.Select(a => a.AbilityId).ToList();

            var skillsCondition = character.Professions.SelectMany(a => a.Profession.Skills).All(a => a.Skills.Count(b => allCharacterSkillsIds.Contains(b.SkillId)) >= a.Quantity);
            var abilityCondition = character.Professions.SelectMany(a => a.Profession.Abilities).All(a => a.Abilities.Count(b => allCharacterAbilitiesIds.Contains(b.AbilityId)) >= a.Quantity);
            var statisticsCondition = true;

            foreach (var value in character.Statistics)
            {
                var maximumValue = GetTotalStatisticMaximumValue(value.Statistic.Type, character, out int professionValue, out Dictionary<string, int> abilitiesValues);

                if (value.CurrentValue != maximumValue)
                {
                    statisticsCondition = false;
                    break;
                }
            }

            return skillsCondition && abilityCondition && statisticsCondition;
        }

        private int GetBonusStatisticMaximumValue(StatisticType type, Character character)
        {
            var bonuses = character.Abilities
                .Where(b => b.Ability.HasImpactOnStatictics && b.Ability.ValueToAlter.Value == type)
                .ToDictionary(a => a.Ability.Name, a => a.Ability.ImpactValue.Value);

            return bonuses.Any() ? bonuses.Sum(a => a.Value) : 0;
        }

        private int GetProfessionStatisticMaximumValue(StatisticType type, Character character)
            => character.Professions.Max(a => a.Profession.Statistics.First(b => b.Statistic.Type == type).Value);

        private int GetTotalStatisticMaximumValue(StatisticType type, Character character)
        {
            var maximumValueFromProfessions = character.Professions.Any() ? GetProfessionStatisticMaximumValue(type, character) : 0;
            var bonuses = GetBonusStatisticMaximumValue(type, character);

            return character.Statistics.First(a => a.Statistic.Type == type).BaseValue + bonuses + maximumValueFromProfessions;
        }

        private int GetTotalStatisticMaximumValue(StatisticType type, Character character, out int professionValue, out Dictionary<string, int> abilitiesValues)
        {
            var maximumValueFromProfessions = 0;
            var bonuses = character.Abilities
                .Where(b => b.Ability.HasImpactOnStatictics && b.Ability.ValueToAlter.Value == type)
                .ToDictionary(a => a.Ability.Name, a => a.Ability.ImpactValue.Value);

            if (character.Professions.Any())
                maximumValueFromProfessions = GetProfessionStatisticMaximumValue(type, character);

            professionValue = maximumValueFromProfessions;
            abilitiesValues = bonuses;

            return character.Statistics.First(a => a.Statistic.Type == type).BaseValue + (bonuses.Any() ? bonuses.Sum(a => a.Value) : 0) + maximumValueFromProfessions;
        }

        private Character GetUserCharacter()
        {
            var userId = GetUserId();

            return context.Characters.FirstOrDefault(a => a.UserId == userId);
        }

        private int GetUserId()
        {
            var principal = Request.HttpContext.Request.HttpContext.User;

            if (!(principal?.Identity is ClaimsIdentity identity))
                return 0;

            var claim = identity.Claims.FirstOrDefault(a => a.Type.Equals(ClaimTypes.Name)).Value;

            return int.Parse(claim);
        }

        private void SendMessageAboutExperienceChange(Character character) =>
                                                                                                                                                                                                                                                                                                                            characterHub.ChangeExperience(character.Id, character.ExperienceSummary - character.ExperienceUsed);

        private void SendMessageAboutMoneyChange(Character character)
        {
            var money = MoneyCalculator.ConvertMoney(character.Money);

            characterHub.ChangeMoney(character.Id, money.Gold, money.Silver, money.Bronze);
        }

        private void SendMessageAboutStatisticValueChange(Character character, CharacterStatistic characterStatistic)
        {
            var maximumValue = GetTotalStatisticMaximumValue(characterStatistic.Statistic.Type, character);

            characterHub.ChangeStatisticValue(character.Id, characterStatistic.Statistic.Type, characterStatistic.CurrentValue, maximumValue);

            if (characterStatistic.Statistic.Type == StatisticType.Stamina)
                SendMessageAboutStatisticValueChange(character, StatisticType.Strength, characterStatistic.CurrentValue / 10);
            else if (characterStatistic.Statistic.Type == StatisticType.Resistance)
                SendMessageAboutStatisticValueChange(character, StatisticType.Hardness, characterStatistic.CurrentValue / 10);
        }

        private void SendMessageAboutStatisticValueChange(Character character, StatisticType type, int value)
            => characterHub.ChangeStatisticValue(character.Id, type, value, value);

        private List<RaceDto> SortAvailableRaces(Character character)
        {
            var allowedProfessions = character.Professions.Select(a => a.Profession.ProfessionRaceAllowed).ToList();
            var mostRestrictedValue = (Race)(allowedProfessions.Any() ? allowedProfessions.Min(a => (int)a) : (int)(Race.Human | Race.Elf | Race.Dwarf | Race.Halfing));

            var values = new List<RaceDto>();

            if (mostRestrictedValue.HasFlag(Race.Human))
                values.Add(new RaceDto
                {
                    Id = (int)Race.Human,
                    Name = Race.Human.ToString()
                });

            if (mostRestrictedValue.HasFlag(Race.Elf))
                values.Add(new RaceDto
                {
                    Id = (int)Race.Elf,
                    Name = Race.Elf.ToString()
                });

            if (mostRestrictedValue.HasFlag(Race.Dwarf))
                values.Add(new RaceDto
                {
                    Id = (int)Race.Dwarf,
                    Name = Race.Dwarf.ToString()
                });

            if (mostRestrictedValue.HasFlag(Race.Halfing))
                values.Add(new RaceDto
                {
                    Id = (int)Race.Halfing,
                    Name = Race.Halfing.ToString()
                });

            return values;
        }
    }
}