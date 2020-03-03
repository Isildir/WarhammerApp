using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WarhammerProfessionApp.Dtos;
using WarhammerProfessionApp.Entities;
using WarhammerProfessionApp.Entities.Models;
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
                Gold = character.Gold,
                Silver = character.Silver,
                Bronze = character.Bronze,
                Name = character.Name,
                ActualProfessionName = character.CurrentProfession?.Name,
                ExperienceUsed = character.ExperienceUsed,
                ExperienceSummary = character.ExperienceSummary,
                Professions = character.Professions.Select(a => new ShortProfessionDto { Id = a.ProfessionId, Name = a.Profession.Name }).ToList(),
                AdditionalValues = character.AdditionalValues.Select(a => new AdditionalCharacterDto { Id = a.Id, Value = a.Value }).ToList(),
                AdditionalExcerienceCostValues = character.AdditionalExcerienceCostValues.Select(a => new AdditionalCharacterDto { Id = a.Id, Value = a.Value }).ToList(),
                CharacterStatistics = character.Statistics.Select(a => new CharacterStatisticDto
                {
                    Name = EnumTranslator.TranslateStaticticValue(a.Statistic.Type),
                    Type = a.Statistic.Type,
                    IsBasicValue = a.Statistic.IsBasicValue,
                    BaseValue = a.BaseValue,
                    CurrentValue = a.CurrentValue,
                    MaximumValue = a.MaximumValue
                }).ToList(),
                CharacterSkills = character.Skills.Select(a => new SkillDto { Id = a.SkillId, Name = a.Skill.Name }).ToList(),
                CharacterAbilities = character.Abilities.Take(5).Select(a => new AbilityDto { Id = a.AbilityId, Name = a.Ability.Name }).ToList(),
                CharacterItems = character.Items.Select(a => new ItemDto { Id = a.ItemId, Name = a.Item.Name }).ToList()
            });
        }

        private bool CheckCharacterExperienceLimit(Character character, int value) => character.ExperienceSummary - character.ExperienceUsed > value;

        [HttpPost(nameof(AddCharacterExcerienceCostValue))]
        public ActionResult<int> AddCharacterExcerienceCostValue([FromBody] AdditionalCharacterDto value)
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
        public ActionResult<int> ModifyCharacterExcerienceCostValue([FromBody] AdditionalCharacterDto value)
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
        public ActionResult<int> RemoveCharacterExcerienceCostValue([FromBody] int id)
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
        public ActionResult<bool> ChangeCharacterMoney([FromBody] MoneyChangeDto value)
        {
            var character = GetUserCharacter();

            if (character == null)
                return NotFound();

            character.Gold = value.Gold;
            character.Silver = value.Silver;
            character.Bronze = value.Bronze;

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(ChangeCharacterMaximumExperience))]
        public ActionResult<bool> ChangeCharacterMaximumExperience([FromBody] int value)
        {
            var character = GetUserCharacter();

            if (character == null)
                return NotFound();

            character.ExperienceSummary= value;

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(ChangeCharacterName))]
        public ActionResult<bool> ChangeCharacterName([FromBody] string name)
        {
            var character = GetUserCharacter();

            if (character == null)
                return NotFound();

            character.Name = name;

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(SetCharacterProfession))]
        public ActionResult<bool> SetCharacterProfession([FromBody] int id)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.Professions).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!character.Professions.Any(a => a.ProfessionId == id))
                return BadRequest();

            character.CurrentProfessionId = id;

            context.SaveChanges();

            return Ok(true);
        }

        [HttpPost(nameof(AddCharacterProfession))]
        public ActionResult<bool> AddCharacterProfession([FromBody] int id)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.Professions).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            if (!context.Professions.Any(a => a.Id == id) || character.Professions.Any(a => a.ProfessionId == id))
                return BadRequest();

            character.Professions.Add(new CharacterProfession { ProfessionId = id });

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(RemoveCharacterProfession))]
        public ActionResult<bool> RemoveCharacterProfession([FromBody] int id)
        {
            var userId = GetUserId();

            var character = context.Characters.Include(a => a.Professions).FirstOrDefault(a => a.UserId == userId);

            if (character == null)
                return NotFound();

            var profession = character.Professions.FirstOrDefault(a => a.ProfessionId == id);

            if (profession == null)
                return BadRequest();

            character.Professions.Remove(profession);

            context.SaveChanges();

            return Ok(false);
        }

        [HttpPost(nameof(AddCharacterAdditionalValue))]
        public ActionResult<int> AddCharacterAdditionalValue([FromBody] AdditionalCharacterDto value)
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
        public ActionResult<int> ModifyCharacterAdditionalValue([FromBody] AdditionalCharacterDto value)
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
        public ActionResult<int> RemoveCharacterAdditionalValue([FromBody] int id)
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

        /*
        
        [HttpPost(nameof(AddCharacterItem))]
        public ActionResult<int> AddCharacterItem(int id)
        {
        }
        
        [HttpPost(nameof(RemoveCharacterItem))]
        public ActionResult<int> RemoveCharacterItem(int id)
        {
        }
        
        [HttpPost(nameof(ModifyCharacterItem))]
        public ActionResult<int> ModifyCharacterItem(ItemDto value)
        {
        }

        */

        [HttpPost(nameof(ChangeCharacterStatisticValue))]
        public ActionResult<int> ChangeCharacterStatisticValue([FromBody] CharacterStatisticDto value)
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
        public ActionResult<int> AddCharacterSkill([FromBody] int id)
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
        public ActionResult<int> AddCharacterAbility([FromBody] int id)
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

        [HttpPost(nameof(RemoveCharacterSkill))]
        public ActionResult<int> RemoveCharacterSkill([FromBody] int id)
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

        [HttpPost(nameof(RemoveCharacterAbility))]
        public ActionResult<int> RemoveCharacterAbility([FromBody] int id)
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