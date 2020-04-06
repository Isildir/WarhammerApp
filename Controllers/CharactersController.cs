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

        [HttpPost(nameof(AddCharacterAbility))]
        public ActionResult<CharacterChangeResponseDto> AddCharacterAbility([FromBody] int id)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.Abilities).Include(a => a.Statistics).ThenInclude(a => a.Statistic).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!CheckCharacterExperienceLimit(character, 100))
                return BadRequest();

            var ability = context.Abilities.Find(id);

            if (ability == null || character.Abilities.Any(a => a.AbilityId == id))
                return BadRequest();

            character.ExperienceUsed += 100;
            character.Abilities.Add(new CharacterAbility { AbilityId = id });

            if (ability.HasImpactOnStatictics)
            {
                var characterStatistic = character.Statistics.FirstOrDefault(a => a.Statistic.Type == ability.ValueToAlter.Value);

                characterStatistic.CurrentValue += ability.ImpactValue.Value;
            }

            context.SaveChanges();

            return Ok(ability.HasImpactOnStatictics);
        }

        [HttpPost(nameof(AddCharacterAdditionalValue))]
        public ActionResult<CharacterChangeResponseDto> AddCharacterAdditionalValue([FromBody] AdditionalCharacterValueDto value)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.AdditionalValues).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            character.AdditionalValues.Add(new AdditionalCharacterValue { Value = value.Value });

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(AddCharacterExcerienceCostValue))]
        public ActionResult<CharacterChangeResponseDto> AddCharacterExcerienceCostValue([FromBody] AdditionalCharacterValueDto value)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.AdditionalExcerienceCostValues).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!CheckCharacterExperienceLimit(character, 100))
                return BadRequest();

            character.ExperienceUsed += 100;
            character.AdditionalExcerienceCostValues.Add(new ExperienceAdditionalCharacterValue { Value = value.Value });

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(AddCharacterItem))]
        public ActionResult AddCharacterItem(ModifyCharacterItemDto value)
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

            return Ok();
        }

        [HttpPost(nameof(AddCharacterSkill))]
        public ActionResult<CharacterChangeResponseDto> AddCharacterSkill([FromBody] int id)
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

            return Ok(false);
        }

        [HttpPost(nameof(ChangeBaseStatisticValue))]
        public ActionResult<CharacterChangeResponseDto> ChangeBaseStatisticValue([FromBody] BaseStatiticValueChangeDto value)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.Statistics).ThenInclude(a => a.Statistic).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var characterStatistic = character.Statistics.FirstOrDefault(a => a.Statistic.Type == value.Type);

            characterStatistic.CurrentValue -= characterStatistic.BaseValue;
            characterStatistic.BaseValue = value.Value;
            characterStatistic.CurrentValue += characterStatistic.BaseValue;

            context.SaveChanges();

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

            var generator = new Random();

            characterHub.OnMoneyChange(character.Id, generator.Next(1, 100), generator.Next(1, 100), generator.Next(1, 100));

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
                .Include(a => a.Professions)
                .ThenInclude(a => a.Profession)
                .Include(a => a.Statistics)
                .ThenInclude(a => a.Statistic)
                .FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var characterStatistic = character.Statistics.FirstOrDefault(a => a.Statistic.Type == value.Type);

            if (characterStatistic.Statistic.IsCalculatedValue)
                return BadRequest();

            var incrementValue = characterStatistic.Statistic.IsBasicValue ? 5 : 1;

            var maximumValue = GetStatisticMaximumValue(characterStatistic.Statistic.Type, character, out int professionValue, out Dictionary<string, int> _);

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

            return Ok(characterStatistic.Statistic.Type == StatisticType.Stamina || characterStatistic.Statistic.Type == StatisticType.Resistance);
        }

        [HttpGet]
        public async Task<ActionResult<CharacterDto>> GetCharacter()
        {
            var userId = GetUserId();

            var character = await context.Characters
                .Include(a => a.Professions).ThenInclude(a => a.Profession)
                .Include(a => a.Skills).ThenInclude(a => a.Skill)
                .Include(a => a.Abilities).ThenInclude(a => a.Ability)
                .Include(a => a.Items).ThenInclude(a => a.Item)
                .Include(a => a.Statistics).ThenInclude(a => a.Statistic)
                .Include(a => a.AdditionalValues)
                .Include(a => a.AdditionalExcerienceCostValues)
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

            var additionalValues = new List<AdditionalCharacterValueDto>
                {
                    new AdditionalCharacterValueDto { Id = 1, Value = "Ajtem namber łan" },
                    new AdditionalCharacterValueDto { Id = 2, Value = "Ajtem tu" },
                    new AdditionalCharacterValueDto { Id = 3, Value = "Ajtem trii" }
                };

            var moreAdditionalValues = new List<AdditionalCharacterValueDto>
                {
                    new AdditionalCharacterValueDto { Id = 1, Value = "Item za expa 1" },
                    new AdditionalCharacterValueDto { Id = 2, Value = "Item za expa 2" },
                    new AdditionalCharacterValueDto { Id = 3, Value = "Item za expa 3" }
                };

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
                var maximumValue = GetStatisticMaximumValue(value.Statistic.Type, character, out int professionValue, out Dictionary<string, int> abilitiesValues);
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
                BasicValues = basicValues,
                Professions = professions,
                AdditionalValues = additionalValues,
                AdditionalExcerienceCostValues = moreAdditionalValues,
                BasicStatistics = statistics.Where(a => a.Item1).Select(a => a.Item2).ToList(),
                AdvancedStatistics = statistics.Where(a => !a.Item1).Select(a => a.Item2).ToList(),
                Skills = skills,
                Abilities = abilities,
                Items = items
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
                        IsUpgrade = false
                    });
                else if (takenSkills.ContainsKey(skill.Key) && takenSkills[skill.Key] < skill.Value)
                    values.Add(new CharacterSkillGetDto
                    {
                        Id = record.Id,
                        Name = record.Name,
                        IsUpgrade = true
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

        [HttpPost(nameof(ModifyCharacterAdditionalValue))]
        public ActionResult<CharacterChangeResponseDto> ModifyCharacterAdditionalValue([FromBody] AdditionalCharacterValueDto value)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.AdditionalValues).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var characterValue = character.AdditionalValues.FirstOrDefault(a => a.Id == value.Id);

            if (characterValue == null)
                return BadRequest();

            characterValue.Value = value.Value;

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(ModifyCharacterExcerienceCostValue))]
        public ActionResult<CharacterChangeResponseDto> ModifyCharacterExcerienceCostValue([FromBody] AdditionalCharacterValueDto value)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.AdditionalExcerienceCostValues).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!character.AdditionalValues.Any(a => a.Id == value.Id))
                return BadRequest();

            character.AdditionalExcerienceCostValues.FirstOrDefault(a => a.Id == value.Id).Value = value.Value;

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(ModifyCharacterItem))]
        public ActionResult<int> ModifyCharacterItem(ModifyCharacterItemDto value)
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

            return Ok();
        }

        [HttpDelete(nameof(RemoveCharacterAbility))]
        public ActionResult<CharacterChangeResponseDto> RemoveCharacterAbility(int id)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.Abilities).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var ability = context.Abilities.Find(id);

            var characterAbility = character.Abilities.FirstOrDefault(a => a.AbilityId == id);

            if (ability == null || characterAbility == null)
                return BadRequest();

            character.ExperienceUsed -= 100;
            character.Abilities.Remove(characterAbility);

            if (ability.HasImpactOnStatictics)
            {
                var characterStatistic = character.Statistics.FirstOrDefault(a => a.Statistic.Type == ability.ValueToAlter.Value);

                characterStatistic.CurrentValue -= ability.ImpactValue.Value;
            }

            context.SaveChanges();

            return Ok(ability.HasImpactOnStatictics);
        }

        [HttpPost(nameof(RemoveCharacterAdditionalValue))]
        public ActionResult<CharacterChangeResponseDto> RemoveCharacterAdditionalValue([FromBody] int id)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.AdditionalValues).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var value = character.AdditionalValues.FirstOrDefault(a => a.Id == id);

            if (value == null)
                return BadRequest();

            character.AdditionalValues.Remove(value);

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(RemoveCharacterExcerienceCostValue))]
        public ActionResult<CharacterChangeResponseDto> RemoveCharacterExcerienceCostValue([FromBody] int id)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.AdditionalExcerienceCostValues).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!character.AdditionalExcerienceCostValues.Any(a => a.Id == id))
                return BadRequest();

            character.ExperienceUsed -= 100;
            character.AdditionalExcerienceCostValues.Remove(character.AdditionalExcerienceCostValues.First(a => a.Id == id));

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(RemoveCharacterItem))]
        public ActionResult<int> RemoveCharacterItem(ModifyCharacterItemDto value)
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

            return Ok();
        }

        [HttpDelete(nameof(RemoveCharacterSkill))]
        public ActionResult<CharacterChangeResponseDto> RemoveCharacterSkill(int id)
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

            return Ok(false);
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
                var maximumValue = GetStatisticMaximumValue(value.Statistic.Type, character, out int professionValue, out Dictionary<string, int> abilitiesValues);

                if (value.CurrentValue != maximumValue)
                {
                    statisticsCondition = false;
                    break;
                }
            }

            return skillsCondition && abilityCondition && statisticsCondition;
        }

        private int GetStatisticMaximumValue(StatisticType type, Character character, out int professionValue, out Dictionary<string, int> abilitiesValues)
        {
            var maximumValueFromProfessions = 0;
            var bonuses = character.Abilities
                .Where(b => b.Ability.HasImpactOnStatictics && b.Ability.ValueToAlter.Value == type)
                .ToDictionary(a => a.Ability.Name, a => a.Ability.ImpactValue.Value);

            if (character.Professions.Any())
            {
                maximumValueFromProfessions = type switch
                {
                    StatisticType.Agility => character.Professions.Max(a => a.Profession.Agility),
                    StatisticType.Attacks => character.Professions.Max(a => a.Profession.Attacks),
                    StatisticType.CloseCombat => character.Professions.Max(a => a.Profession.CloseCombat),
                    StatisticType.Hitpoints => character.Professions.Max(a => a.Profession.Hitpoints),
                    StatisticType.Inteligence => character.Professions.Max(a => a.Profession.Inteligence),
                    StatisticType.Magic => character.Professions.Max(a => a.Profession.Magic),
                    StatisticType.Polish => character.Professions.Max(a => a.Profession.Polish),
                    StatisticType.Resistance => character.Professions.Max(a => a.Profession.Resistance),
                    StatisticType.Shooting => character.Professions.Max(a => a.Profession.Shooting),
                    StatisticType.Speed => character.Professions.Max(a => a.Profession.Speed),
                    StatisticType.Stamina => character.Professions.Max(a => a.Profession.Stamina),
                    StatisticType.Willpower => character.Professions.Max(a => a.Profession.Willpower),
                    _ => 0
                };
            }

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