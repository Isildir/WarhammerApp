using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WarhammerProfessionApp.Entities;
using WarhammerProfessionApp.Entities.Models.Enums;

namespace WarhammerProfessionApp.Controllers
{
    public class CharacterCreationDto
    {
        public List<CharacterCreationValueDto> Values { get; set; }
    }

    public class CharacterCreationValueDto
    {
        public int DictionaryValueId { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }
    }

    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class CharacterCreatorController : ControllerBase
    {
        private readonly ProfessionsContext context;

        public CharacterCreatorController(ProfessionsContext context)
        {
            this.context = context;
        }

        /*
        [HttpPost]
        public ActionResult<ShortCharacterDto> AddCharacter([FromBody] object model)
        {
        }
        */

        [HttpGet]
        public ActionResult<List<CharacterCreationDto>> GetAbilities(int raceId)
        {
            var race = (Race)raceId;

            var abilitiesList = context.Abilities
                .Where(a => a.IsStartingValue)
                .Select(a => new
                {
                    a.Id,
                    a.Name,
                    a.Type
                }).ToList();

            if (race == Race.Human)
                return Ok(new List<CharacterCreationDto>
                {
                    new CharacterCreationDto
                    {
                        Values = abilitiesList.Select(a => new CharacterCreationValueDto{ Id = a.Id, Name = a.Name }).ToList()
                    },
                    new CharacterCreationDto
                    {
                        Values = abilitiesList.Select(a => new CharacterCreationValueDto{ Id = a.Id, Name = a.Name }).ToList()
                    }
                });

            if (race == Race.Halfing)
                return Ok(new List<CharacterCreationDto>
                {
                    new CharacterCreationDto
                    {
                        Values = abilitiesList.Where(a => a.Type != BuiltInAbilities.SeeingInTheDark).Select(a => new CharacterCreationValueDto{ Id = a.Id, Name = a.Name }).ToList()
                    }
                });

            if (race == Race.Elf)
            {
                var bron = context.Abilities.First(a => a.Type == BuiltInAbilities.SpecialWeapon);
                var zmysl = context.Abilities.First(a => a.Type == BuiltInAbilities.SenseOfMagic);
                var opanowanie = context.Abilities.First(a => a.Type == BuiltInAbilities.SelfControl);
                var blyskotliwosc = context.Abilities.First(a => a.Type == BuiltInAbilities.Brilliance);

                var bronDictionaryValue = context.DictionaryValues.First(a => a.Type == BuiltInDictionaryValues.SpecialWeaponLongBow);

                return Ok(new List<CharacterCreationDto>
                {
                    new CharacterCreationDto
                    {
                        Values = new List<CharacterCreationValueDto>
                        {
                            new CharacterCreationValueDto { Id = bron.Id, Name = $"{bron.Name} ({bronDictionaryValue.Value})", DictionaryValueId = bronDictionaryValue.Id },
                            new CharacterCreationValueDto { Id = zmysl.Id, Name = zmysl.Name }
                        },
                    },
                    new CharacterCreationDto
                    {
                        Values = new List<CharacterCreationValueDto>
                        {
                            new CharacterCreationValueDto { Id = opanowanie.Id, Name = opanowanie.Name },
                            new CharacterCreationValueDto { Id = blyskotliwosc.Id, Name = blyskotliwosc.Name }
                        }
                    }
                });
            }

            return Ok(new List<CharacterCreationDto>());
        }

        [HttpGet]
        public ActionResult<List<CharacterCreationDto>> GetSkills(int raceId)
        {
            var race = (Race)raceId;

            if (race == Race.Halfing)
            {
                var gotowanieDictionaryValue = context.DictionaryValues.First(a => a.Type == BuiltInDictionaryValues.CraftCooking);
                var uprawaDictionaryValue = context.DictionaryValues.First(a => a.Type == BuiltInDictionaryValues.CraftTillage);

                var rzemioslo = context.Skills.First(a => a.Type == BuiltInSkills.Craft);

                return Ok(new List<CharacterCreationDto>
                {
                    new CharacterCreationDto
                    {
                        Values = new List<CharacterCreationValueDto>
                        {
                            new CharacterCreationValueDto { Id = rzemioslo.Id, DictionaryValueId = gotowanieDictionaryValue.Id, Name = $"{rzemioslo.Name} ({gotowanieDictionaryValue.Value})" },
                            new CharacterCreationValueDto { Id = rzemioslo.Id, DictionaryValueId = uprawaDictionaryValue.Id, Name = $"{rzemioslo.Name} ({uprawaDictionaryValue.Value})" }
                        }
                    }
                });
            }

            if (race == Race.Dwarf)
            {
                var gornictwoDictionaryValue = context.DictionaryValues.First(a => a.Type == BuiltInDictionaryValues.CraftMining);
                var kamieniarstwoDictionaryValue = context.DictionaryValues.First(a => a.Type == BuiltInDictionaryValues.CraftMasonry);
                var kowalstwoDictionaryValue = context.DictionaryValues.First(a => a.Type == BuiltInDictionaryValues.CraftBlacksmithing);

                var rzemioslo = context.Skills.First(a => a.Type == BuiltInSkills.Craft);

                return Ok(new List<CharacterCreationDto>
                {
                    new CharacterCreationDto
                    {
                        Values = new List<CharacterCreationValueDto>
                        {
                            new CharacterCreationValueDto { Id = rzemioslo.Id, DictionaryValueId = gornictwoDictionaryValue.Id, Name = $"{rzemioslo.Name} ({gornictwoDictionaryValue.Value})" },
                            new CharacterCreationValueDto { Id = rzemioslo.Id, DictionaryValueId = kamieniarstwoDictionaryValue.Id, Name = $"{rzemioslo.Name} ({kamieniarstwoDictionaryValue.Value})" },
                            new CharacterCreationValueDto { Id = rzemioslo.Id, DictionaryValueId = kowalstwoDictionaryValue.Id, Name = $"{rzemioslo.Name} ({kowalstwoDictionaryValue.Value})" }
                        }
                    }
                });
            }

            return Ok(new List<CharacterCreationDto>());
        }
    }
}