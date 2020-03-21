using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WarhammerProfessionApp.Dtos;
using WarhammerProfessionApp.Entities;
using WarhammerProfessionApp.Entities.Models;
using WarhammerProfessionApp.Entities.Models.Enums;
using WarhammerProfessionApp.Utility;

namespace WarhammerProfessionApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class CharactersController : ControllerBase
    {
        private readonly ProfessionsContext context;

        public CharactersController(ProfessionsContext context)
        {
            this.context = context;
        }

        private int GetUserId()
        {
            var principal = Request.HttpContext.Request.HttpContext.User;

            if (!(principal?.Identity is ClaimsIdentity identity))
                return 0;

            var claim = identity.Claims.FirstOrDefault(a => a.Type.Equals(ClaimTypes.Name)).Value;

            return int.Parse(claim);
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

        [HttpGet]
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

        [HttpGet]
        public async Task<ActionResult<ShortProfessionDto>> GetFilteredProfessions()
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.Professions)
                .FirstOrDefault(a => a.UserId == userId);

            var characterProfessions = character.Professions.Select(a => a.ProfessionId).ToList();

            var values = context.Professions.Where(a => !characterProfessions.Contains(a.Id));

            if (character.CurrentProfessionId.HasValue)
                values = values.Where(a => a.EntranceProfessions.Any(b => b.EntranceProfessionId == character.CurrentProfessionId.Value));

            return Ok(values.Select(a => new ShortProfessionDto { Id = a.Id, Name = a.Name }).ToList());
        }

        [HttpGet]
        public async Task<ActionResult<SkillDto>> GetFilteredSkills()
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

            var availableSkills = character.Professions.SelectMany(a => a.Profession.Skills.SelectMany(b => b.Skills.Select(c => c.Skill))).ToList();
            var availableSkillsIds = availableSkills.Select(c => c.Id).ToList();
            var takenSkillsIds = character.Skills.Select(a => a.SkillId).ToList();

            var filteredSkillsIds = availableSkillsIds.Where(a => !takenSkillsIds.Contains(a)).ToList();

            var values = availableSkills.Where(a => filteredSkillsIds.Contains(a.Id)).Select(a => new SkillDto
            {
                Id = a.Id,
                Name = a.Name
            }).ToList();

            return Ok(values);
        }

        [HttpGet]
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
            var availableAbilitiesIds = availableAbilities.Select(c => c.Id).ToList();
            var takenAbilitiesIds = character.Abilities.Select(a => a.AbilityId).ToList();

            var filteredAbilitiesIds = availableAbilitiesIds.Where(a => !takenAbilitiesIds.Contains(a)).ToList();

            var values = availableAbilities.Where(a => filteredAbilitiesIds.Contains(a.Id)).Select(a => new AbilityDto
            {
                Id = a.Id,
                Name = a.Name
            }).ToList();

            return Ok(values);
        }

        [HttpGet]
        public async Task<ActionResult<ItemDto>> GetFilteredItems()
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.Items)
                .FirstOrDefault(a => a.UserId == userId);

            var takenItemsIds = character.Items.Select(a => a.ItemId).ToList();

            var values = context.Items.Where(a => !takenItemsIds.Contains(a.Id)).Select(a => new ItemDto
            {
                Id = a.Id,
                Name = a.Name
            }).ToList();

            return Ok(values);
        }

        [HttpGet]
        public async Task<ActionResult<CharacterDto>> GetCharacter()
        {
            var userId = GetUserId();

            var character = context.Characters
                .Include(a => a.Professions).ThenInclude(a => a.Profession)
                .Include(a => a.Skills).ThenInclude(a => a.Skill)
                .Include(a => a.Abilities).ThenInclude(a => a.Ability)
                .Include(a => a.Items).ThenInclude(a => a.Item)
                .Include(a => a.Statistics).ThenInclude(a => a.Statistic)
                .Include(a => a.AdditionalValues)
                .Include(a => a.AdditionalExcerienceCostValues)
                .FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            return Ok(new CharacterDto
            {
                Money = new MoneyDto
                {
                    Gold = character.Gold,
                    Silver = character.Silver,
                    Bronze = character.Bronze
                },
                BasicValues = new CharacterBasicValuesDto
                {
                    ActualProfessionName = character.CurrentProfession?.Name,
                    ExperienceLeft = character.ExperienceSummary - character.ExperienceUsed,
                    ExperienceSum = character.ExperienceSummary,
                    Name = character.Name,
                    Race = new RaceDto
                    {
                        Id = (int)character.Race,
                        Name = character.Race.ToString()
                    }
                },
                Professions = character.Professions.Select(a => new ShortProfessionDto { Id = a.Profession.Id, Name = a.Profession.Name }).ToList(),
                AdditionalValues = new List<AdditionalCharacterValueDto>
                {
                    new AdditionalCharacterValueDto { Id = 1, Value = "Ajtem namber łan" },
                    new AdditionalCharacterValueDto { Id = 2, Value = "Ajtem tu" },
                    new AdditionalCharacterValueDto { Id = 3, Value = "Ajtem trii" }
                },
                AdditionalExcerienceCostValues = new List<AdditionalCharacterValueDto>
                {
                    new AdditionalCharacterValueDto { Id = 1, Value = "Item za expa 1" },
                    new AdditionalCharacterValueDto { Id = 2, Value = "Item za expa 2" },
                    new AdditionalCharacterValueDto { Id = 3, Value = "Item za expa 3" }
                },
                BasicStatistics = character.Statistics.Where(a => a.Statistic.IsBasicValue).Select(a => new CharacterStatisticDto
                {
                    Name = EnumTranslator.TranslateStaticticValue(a.Statistic.Type),
                    Type = a.Statistic.Type,
                    IsReadOnly = a.Statistic.ValueIsCalculated,
                    IsFreeToChangeValue = a.Statistic.IsChangeFree,
                    BaseValue = a.BaseValue,
                    CurrentValue = a.CurrentValue,
                    MaximumValue = a.MaximumValue,
                    MaximumDescription = $"Bazowe {a.BaseValue} + 0 z rozwoju + 0 z dodatków"
                }).ToList(),
                AdvancedStatistics = character.Statistics.Where(a => !a.Statistic.IsBasicValue).Select(a => new CharacterStatisticDto
                {
                    Name = EnumTranslator.TranslateStaticticValue(a.Statistic.Type),
                    Type = a.Statistic.Type,
                    IsReadOnly = a.Statistic.ValueIsCalculated,
                    IsFreeToChangeValue = a.Statistic.IsChangeFree,
                    BaseValue = a.BaseValue,
                    CurrentValue = a.CurrentValue,
                    MaximumValue = a.MaximumValue,
                    MaximumDescription = $"Bazowe {a.BaseValue} + 0 z rozwoju + 0 z dodatków"
                }).ToList(),
                Skills = character.Skills.Select(a => new SkillDto
                {
                    Id = a.SkillId,
                    Name = a.Skill.Name,
                    Trait = EnumTranslator.TranslateStaticticValue(a.Skill.Trait),
                    Description = a.Skill.Description
                }).ToList(),
                Abilities = character.Abilities.Select(a => new AbilityDto
                {
                    Id = a.AbilityId,
                    Name = a.Ability.Name,
                    Description = a.Ability.Description
                }).ToList(),
                Items = character.Items.Select(a => new CharacterItemDto
                {
                    Id = a.Item.Id,
                    Name = a.Item.Name,
                    Weigth = a.Item.Weigth,
                    Description = a.Item.Description,
                    Quantity = a.Quantity
                }).ToList()
            });
        }

        private bool CheckCharacterExperienceLimit(Character character, int value) => character.ExperienceSummary - character.ExperienceUsed > value;

        [HttpPost(nameof(AddCharacterExcerienceCostValue))]
        public ActionResult<CharacterChangeResponseDto> AddCharacterExcerienceCostValue([FromBody] AdditionalCharacterValueDto value)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.AdditionalExcerienceCostValues).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!CheckCharacterExperienceLimit(character, 100))
                return BadRequest();

            character.AdditionalExcerienceCostValues.Add(new ExperienceAdditionalCharacterValue { Value = value.Value });

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

        [HttpPost(nameof(RemoveCharacterExcerienceCostValue))]
        public ActionResult<CharacterChangeResponseDto> RemoveCharacterExcerienceCostValue([FromBody] int id)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.AdditionalExcerienceCostValues).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!character.AdditionalExcerienceCostValues.Any(a => a.Id == id))
                return BadRequest();

            character.AdditionalExcerienceCostValues.Remove(character.AdditionalExcerienceCostValues.First(a => a.Id == id));

            context.SaveChanges();

            return Ok(false);
        }

        private Character GetUserCharacter()
        {
            var userId = GetUserId();

            return context.Characters.FirstOrDefault(a => a.UserId == userId);
        }

        [HttpPost(nameof(ChangeCharacterMoney))]
        public ActionResult<CharacterChangeResponseDto> ChangeCharacterMoney([FromBody] MoneyDto value)
        {
            var character = GetUserCharacter();

            if (character == null)
                return NotFound();

            var convertedValue = GetUserMoney(value.Gold, value.Silver, value.Bronze);
            var convertedMoney = ConvertMoney(convertedValue);

            character.Gold = convertedMoney.Gold;
            character.Silver = convertedMoney.Silver;
            character.Bronze = convertedMoney.Bronze;

            context.SaveChanges();

            return Ok(false);
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

        [HttpPost(nameof(SetNextCharacterProfession))]
        public ActionResult<CharacterChangeResponseDto> SetNextCharacterProfession([FromBody] int id)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.Professions).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var targetProfession = context.Professions.Include(a => a.EntranceProfessions).FirstOrDefault(a => a.Id == id);

            if (targetProfession == null || character.Professions.Any(a => a.ProfessionId == id))
                return BadRequest();

            if (character.CurrentProfessionId.HasValue && !targetProfession.EntranceProfessions.Any(a => a.EntranceProfessionId == character.CurrentProfessionId.Value))
                return BadRequest();

            var maxProfessionOrder = character.Professions.Any() ? character.Professions.Max(a => a.Order) : (byte)0;

            character.CurrentProfessionId = id;
            character.Professions.Add(new CharacterProfession
            {
                Profession = targetProfession,
                Order = maxProfessionOrder++
            });

            context.SaveChanges();

            return Ok(true);
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

            character.Professions.Remove(character.Professions.First(a => a.Order == maxProfessionOrder));

            context.SaveChanges();

            return Ok(false);
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

        private int GetItemPrice(Item item)
            => item.MoneyType switch
            {
                MoneyType.GoldenCrown => item.Price * goldValue,
                MoneyType.Shilling => item.Price * silverValue,
                MoneyType.Penny => item.Price,
                _ => 0
            };

        private readonly int goldValue = 20 * 12;
        private readonly int silverValue = 12;

        private MoneyDto ConvertMoney(int value)
        {
            var gold = value / goldValue;
            value -= gold * goldValue;

            var silver = value / silverValue;
            value -= silver * silverValue;

            var bronze = value;

            return new MoneyDto
            {
                Gold = gold,
                Silver = silver,
                Bronze = bronze
            };
        }

        private int GetUserMoney(Character character) => GetUserMoney(character.Gold, character.Silver, character.Bronze);

        private int GetUserMoney(int gold, int silver, int bronze) => gold * goldValue + silver * silverValue + bronze;

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
                var userMoney = GetUserMoney(character);
                var itemCost = GetItemPrice(item);

                if (userMoney < itemCost)
                    return BadRequest("No za mało kasiorki byczku");

                var moneyLeft = ConvertMoney(userMoney - itemCost);

                character.Gold = moneyLeft.Gold;
                character.Silver = moneyLeft.Silver;
                character.Bronze = moneyLeft.Bronze;
            }

            character.Items.Add(new CharacterItem
            {
                ItemId = value.Id,
                Quantity = 1
            });

            context.SaveChanges();

            return Ok();
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
            {
                var userMoney = GetUserMoney(character);
                var itemCost = GetItemPrice(item.Item);

                var moneyLeft = ConvertMoney(userMoney + itemCost * item.Quantity);

                character.Gold = moneyLeft.Gold;
                character.Silver = moneyLeft.Silver;
                character.Bronze = moneyLeft.Bronze;
            }

            character.Items.Remove(item);

            context.SaveChanges();

            return Ok();
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
                var userMoney = GetUserMoney(character);
                var itemCost = GetItemPrice(item.Item);
                var change = value.Quantity - item.Quantity;

                if (change != 0)
                {
                    if (change > 0 && userMoney < itemCost * change)
                        return BadRequest("No za mało kasiorki byczku");

                    var moneyLeft = ConvertMoney(userMoney - itemCost * change);

                    character.Gold = moneyLeft.Gold;
                    character.Silver = moneyLeft.Silver;
                    character.Bronze = moneyLeft.Bronze;
                }
            }

            item.Quantity = value.Quantity;

            context.SaveChanges();

            return Ok();
        }

        [HttpPost(nameof(ChangeCharacterStatisticValue))]
        public ActionResult<CharacterChangeResponseDto> ChangeCharacterStatisticValue([FromBody] CharacterStatisticDto value)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.Statistics).ThenInclude(a => a.Statistic).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var characterStatistic = character.Statistics.FirstOrDefault(a => a.Statistic.Type == value.Type);

            var incrementValue = characterStatistic.Statistic.IsBasicValue ? 5 : 1;

            if ((!characterStatistic.Statistic.IsChangeFree && !CheckCharacterExperienceLimit(character, 100)) || characterStatistic.CurrentValue + incrementValue > characterStatistic.MaximumValue)
                return BadRequest();

            if (!characterStatistic.Statistic.IsChangeFree)
                character.ExperienceUsed += 100;

            characterStatistic.CurrentValue += incrementValue;

            context.SaveChanges();

            return Ok(characterStatistic.Statistic.Type == StatisticType.Stamina || characterStatistic.Statistic.Type == StatisticType.Resistance);
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

            if (!context.Skills.Any(a => a.Id == id) || character.Skills.Any(a => a.SkillId == id))
                return BadRequest();

            character.Skills.Add(new CharacterSkill { SkillId = id });

            context.SaveChanges();

            return Ok(false);
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

            character.Abilities.Add(new CharacterAbility { AbilityId = id });

            if (ability.HasImpactOnStatictics)
            {
                var characterStatistic = character.Statistics.FirstOrDefault(a => a.Statistic.Type == ability.ValueToAlter.Value);

                characterStatistic.CurrentValue += ability.ImpactValue.Value;
                characterStatistic.MaximumValue += ability.ImpactValue.Value;
            }

            context.SaveChanges();

            return Ok(ability.HasImpactOnStatictics);
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

            character.Skills.Remove(skill);

            context.SaveChanges();

            return Ok(false);
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

            character.Abilities.Remove(characterAbility);

            if (ability.HasImpactOnStatictics)
            {
                var characterStatistic = character.Statistics.FirstOrDefault(a => a.Statistic.Type == ability.ValueToAlter.Value);

                characterStatistic.CurrentValue -= ability.ImpactValue.Value;
                characterStatistic.MaximumValue -= ability.ImpactValue.Value;
            }

            context.SaveChanges();

            return Ok(ability.HasImpactOnStatictics);
        }
    }
}