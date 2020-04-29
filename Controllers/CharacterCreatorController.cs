using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WarhammerProfessionApp.Entities;
using WarhammerProfessionApp.Entities.Models.Enums;
using WarhammerProfessionApp.Utility;

namespace WarhammerProfessionApp.Controllers
{
    public class CharacterCreateStatisticDto
    {
        public string Name { get; set; }

        public StatisticType Type { get; set; }

        public int Value { get; set; }
    }

    public class CharacterCreationDto
    {
        public CharacterCreationDto()
        {
            SkillsSet = new List<CharacterCreationValueDto>();
            SkillsChoice = new List<CharacterCreationValueGroupDto>();
            AbilitiesSet = new List<CharacterCreationValueDto>();
            AbilitiesChoice = new List<CharacterCreationValueGroupDto>();
        }

        public List<CharacterCreationValueGroupDto> AbilitiesChoice { get; set; }

        public List<CharacterCreationValueDto> AbilitiesSet { get; set; }

        public Race Race { get; set; }

        public string RaceName => Race.ToString();

        public List<CharacterCreationValueGroupDto> SkillsChoice { get; set; }

        public List<CharacterCreationValueDto> SkillsSet { get; set; }

        public List<CharacterCreateStatisticDto> Statistics { get; set; }
    }

    public class CharacterCreationFinishedDto
    {
        public List<CharacterCreationValueDto> Abilities { get; set; }

        public string Name { get; set; }

        public Race Race { get; set; }

        public List<CharacterCreationValueDto> Skills { get; set; }

        public List<CharacterCreateStatisticDto> Statistics { get; set; }
    }

    public class CharacterCreationValueDto
    {
        public int? DictionaryValueId { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }
    }

    public class CharacterCreationValueGroupDto
    {
        public byte Quantity { get; set; } = 1;

        public List<CharacterCreationValueDto> Values { get; set; }
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

        [HttpGet(nameof(GetNewCharacterData))]
        public ActionResult<List<CharacterCreationDto>> GetNewCharacterData()
        {
            var result = new List<CharacterCreationDto>();

            var abilitiesList = context.Abilities
                .Where(a => a.IsStartingValue)
                .Select(a => new
                {
                    a.Id,
                    a.Name,
                    a.Type
                }).ToList();

            var gossip = context.Skills.FirstOrDefault(a => a.Type == BuiltInSkills.Gossip);
            var knowledge = context.Skills.FirstOrDefault(a => a.Type == BuiltInSkills.Knowledge);
            var language = context.Skills.FirstOrDefault(a => a.Type == BuiltInSkills.Language);
            var craft = context.Skills.FirstOrDefault(a => a.Type == BuiltInSkills.Craft);
            var science = context.Skills.FirstOrDefault(a => a.Type == BuiltInSkills.Science);

            var empireKnowledge = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.KnowledgeEmpire);
            var oldworldLanaguage = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.LanguageOldWorld);

            var elvesKnowledge = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.KnowledgeElves);
            var eltharinLanguage = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.LanguageEltharin);

            var miningCraft = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.CraftMining);
            var masonryCraft = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.CraftMasonry);
            var blacksmithingCraft = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.CraftBlacksmithing);
            var khazalidLanguage = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.LanguageKhazalid);
            var dwarvesKnowledge = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.KnowledgeDwarves);

            var genealogyKnowledge = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.ScienceGenealogy);
            var cookingCraft = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.CraftCooking);
            var tillageCraft = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.CraftTillage);
            var halfingsKnowledge = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.KnowledgeHalfings);
            var halfingsLanguage = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.LanguageHalfings);

            var specialWeapon = context.Abilities.FirstOrDefault(a => a.Type == BuiltInAbilities.SpecialWeapon);
            var senseOfMagic = context.Abilities.FirstOrDefault(a => a.Type == BuiltInAbilities.SenseOfMagic);
            var sharpeye = context.Abilities.FirstOrDefault(a => a.Type == BuiltInAbilities.SharpEyesight);
            var selfcontrol = context.Abilities.FirstOrDefault(a => a.Type == BuiltInAbilities.SelfControl);
            var brilliance = context.Abilities.FirstOrDefault(a => a.Type == BuiltInAbilities.Brilliance);
            var darkseeing = context.Abilities.FirstOrDefault(a => a.Type == BuiltInAbilities.SeeingInTheDark);
            var dwarvenExpert = context.Abilities.FirstOrDefault(a => a.Type == BuiltInAbilities.DwarvenExpert);
            var durable = context.Abilities.FirstOrDefault(a => a.Type == BuiltInAbilities.Durable);
            var magicResistance = context.Abilities.FirstOrDefault(a => a.Type == BuiltInAbilities.MagicResistance);
            var courage = context.Abilities.FirstOrDefault(a => a.Type == BuiltInAbilities.Courage);
            var hatred = context.Abilities.FirstOrDefault(a => a.Type == BuiltInAbilities.Hatred);
            var chaosResistance = context.Abilities.FirstOrDefault(a => a.Type == BuiltInAbilities.ChaosResistance);

            var longBow = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.SpecialWeaponLongBow);
            var slingShot = context.DictionaryValues.FirstOrDefault(a => a.Type == BuiltInDictionaryValues.SpecialWeaponSlingShot);

            var human = new CharacterCreationDto
            {
                Race = Race.Human,
                SkillsSet = new List<CharacterCreationValueDto>
                {
                    new CharacterCreationValueDto { Id = gossip.Id, Name = gossip.Name },
                    new CharacterCreationValueDto { Id = knowledge.Id, Name = $"{knowledge.Name} ({empireKnowledge.Value})", DictionaryValueId = empireKnowledge.Id },
                    new CharacterCreationValueDto { Id = language.Id, Name = $"{language.Name} ({oldworldLanaguage.Value})", DictionaryValueId = oldworldLanaguage.Id }
                },
                AbilitiesChoice = new List<CharacterCreationValueGroupDto>
                {
                    new CharacterCreationValueGroupDto { Quantity = 2, Values = abilitiesList.Select(a => new CharacterCreationValueDto{ Id = a.Id, Name = a.Name }).ToList() }
                },
                Statistics = new List<CharacterCreateStatisticDto>
                {
                    new CharacterCreateStatisticDto { Type = StatisticType.CloseCombat, Name = StatisticType.CloseCombat.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Shooting, Name = StatisticType.Shooting.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Stamina, Name = StatisticType.Stamina.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Resistance, Name = StatisticType.Resistance.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Agility, Name = StatisticType.Agility.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Inteligence, Name = StatisticType.Inteligence.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Willpower, Name = StatisticType.Willpower.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Polish, Name = StatisticType.Polish.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Hitpoints, Name = StatisticType.Hitpoints.ToString(), Value = 0 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Destiny, Name = StatisticType.Destiny.ToString(), Value = 0 },
                }
            };

            result.Add(human);

            var elf = new CharacterCreationDto
            {
                Race = Race.Elf,
                SkillsSet = new List<CharacterCreationValueDto>
                {
                    new CharacterCreationValueDto { Id = knowledge.Id, Name = $"{knowledge.Name} ({elvesKnowledge.Value})", DictionaryValueId = elvesKnowledge.Id },
                    new CharacterCreationValueDto { Id = language.Id, Name = $"{language.Name} ({eltharinLanguage.Value})", DictionaryValueId = eltharinLanguage.Id },
                    new CharacterCreationValueDto { Id = language.Id, Name = $"{language.Name} ({oldworldLanaguage.Value})", DictionaryValueId = oldworldLanaguage.Id }
                },
                AbilitiesSet = new List<CharacterCreationValueDto>
                {
                    new CharacterCreationValueDto { Id = sharpeye.Id, Name = sharpeye.Name },
                    new CharacterCreationValueDto { Id = darkseeing.Id, Name = darkseeing.Name },
                },
                AbilitiesChoice = new List<CharacterCreationValueGroupDto>
                {
                    new CharacterCreationValueGroupDto
                    {
                        Values = new List<CharacterCreationValueDto>
                        {
                            new CharacterCreationValueDto { Id = specialWeapon.Id, Name = $"{specialWeapon.Name} ({longBow.Value})", DictionaryValueId = longBow.Id },
                            new CharacterCreationValueDto { Id = senseOfMagic.Id, Name = senseOfMagic.Name }
                        }
                    },
                    new CharacterCreationValueGroupDto
                    {
                        Values = new List<CharacterCreationValueDto>
                        {
                            new CharacterCreationValueDto { Id = selfcontrol.Id, Name = selfcontrol.Name },
                            new CharacterCreationValueDto { Id = brilliance.Id, Name = brilliance.Name }
                        }
                    },
                },
                Statistics = new List<CharacterCreateStatisticDto>
                {
                    new CharacterCreateStatisticDto { Type = StatisticType.CloseCombat, Name = StatisticType.CloseCombat.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Shooting, Name = StatisticType.Shooting.ToString(), Value = 30 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Stamina, Name = StatisticType.Stamina.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Resistance, Name = StatisticType.Resistance.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Agility, Name = StatisticType.Agility.ToString(), Value = 30 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Inteligence, Name = StatisticType.Inteligence.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Willpower, Name = StatisticType.Willpower.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Polish, Name = StatisticType.Polish.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Hitpoints, Name = StatisticType.Hitpoints.ToString(), Value = 0 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Destiny, Name = StatisticType.Destiny.ToString(), Value = 0 },
                }
            };

            result.Add(elf);

            var dwarf = new CharacterCreationDto
            {
                Race = Race.Dwarf,
                SkillsSet = new List<CharacterCreationValueDto>
                {
                    new CharacterCreationValueDto { Id = knowledge.Id, Name = $"{knowledge.Name} ({dwarvesKnowledge.Value})", DictionaryValueId = dwarvesKnowledge.Id },
                    new CharacterCreationValueDto { Id = language.Id, Name = $"{language.Name} ({khazalidLanguage.Value})", DictionaryValueId = khazalidLanguage.Id },
                    new CharacterCreationValueDto { Id = language.Id, Name = $"{language.Name} ({oldworldLanaguage.Value})", DictionaryValueId = oldworldLanaguage.Id }
                },
                SkillsChoice = new List<CharacterCreationValueGroupDto>
                {
                    new CharacterCreationValueGroupDto
                    {
                        Values = new List<CharacterCreationValueDto>
                        {
                            new CharacterCreationValueDto { Id = craft.Id, Name = $"{craft.Name} ({miningCraft.Value})", DictionaryValueId = miningCraft.Id },
                            new CharacterCreationValueDto { Id = craft.Id, Name = $"{craft.Name} ({masonryCraft.Value})", DictionaryValueId = masonryCraft.Id },
                            new CharacterCreationValueDto { Id = craft.Id, Name = $"{craft.Name} ({blacksmithingCraft.Value})", DictionaryValueId = blacksmithingCraft.Id }
                        }
                    }
                },
                AbilitiesSet = new List<CharacterCreationValueDto>
                {
                    new CharacterCreationValueDto { Id = dwarvenExpert.Id, Name = dwarvenExpert.Name },
                    new CharacterCreationValueDto { Id = durable.Id, Name = durable.Name },
                    new CharacterCreationValueDto { Id = magicResistance.Id, Name = magicResistance.Name },
                    new CharacterCreationValueDto { Id = courage.Id, Name = courage.Name },
                    new CharacterCreationValueDto { Id = darkseeing.Id, Name = darkseeing.Name },
                    new CharacterCreationValueDto { Id = hatred.Id, Name = hatred.Name },
                },
                Statistics = new List<CharacterCreateStatisticDto>
                {
                    new CharacterCreateStatisticDto { Type = StatisticType.CloseCombat, Name = StatisticType.CloseCombat.ToString(), Value = 30 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Shooting, Name = StatisticType.Shooting.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Stamina, Name = StatisticType.Stamina.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Resistance, Name = StatisticType.Resistance.ToString(), Value = 30 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Agility, Name = StatisticType.Agility.ToString(), Value = 10 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Inteligence, Name = StatisticType.Inteligence.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Willpower, Name = StatisticType.Willpower.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Polish, Name = StatisticType.Polish.ToString(), Value = 10 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Hitpoints, Name = StatisticType.Hitpoints.ToString(), Value = 0 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Destiny, Name = StatisticType.Destiny.ToString(), Value = 0 },
                }
            };

            result.Add(dwarf);

            var halfing = new CharacterCreationDto
            {
                Race = Race.Halfing,
                SkillsSet = new List<CharacterCreationValueDto>
                {
                    new CharacterCreationValueDto { Id = gossip.Id, Name = gossip.Name },
                    new CharacterCreationValueDto { Id = science.Id, Name = $"{science.Name} ({genealogyKnowledge.Value})", DictionaryValueId = genealogyKnowledge.Id },
                    new CharacterCreationValueDto { Id = knowledge.Id, Name = $"{knowledge.Name} ({halfingsKnowledge.Value})", DictionaryValueId = halfingsKnowledge.Id },
                    new CharacterCreationValueDto { Id = language.Id, Name = $"{language.Name} ({halfingsLanguage.Value})", DictionaryValueId = halfingsLanguage.Id },
                    new CharacterCreationValueDto { Id = language.Id, Name = $"{language.Name} ({oldworldLanaguage.Value})", DictionaryValueId = oldworldLanaguage.Id }
                },
                SkillsChoice = new List<CharacterCreationValueGroupDto>
                {
                    new CharacterCreationValueGroupDto
                    {
                        Values = new List<CharacterCreationValueDto>
                        {
                            new CharacterCreationValueDto { Id = craft.Id, Name = $"{craft.Name} ({cookingCraft.Value})", DictionaryValueId = cookingCraft.Id },
                            new CharacterCreationValueDto { Id = craft.Id, Name = $"{craft.Name} ({tillageCraft.Value})", DictionaryValueId = tillageCraft.Id }
                        }
                    }
                },
                AbilitiesSet = new List<CharacterCreationValueDto>
                {
                    new CharacterCreationValueDto { Id = specialWeapon.Id, Name = $"{specialWeapon.Name} ({slingShot.Value})", DictionaryValueId = slingShot.Id },
                    new CharacterCreationValueDto { Id = darkseeing.Id, Name = darkseeing.Name },
                    new CharacterCreationValueDto { Id = chaosResistance.Id, Name = chaosResistance.Name },
                },
                AbilitiesChoice = new List<CharacterCreationValueGroupDto>
                {
                    new CharacterCreationValueGroupDto { Values = abilitiesList.Where(a => a.Type != BuiltInAbilities.SeeingInTheDark).Select(a => new CharacterCreationValueDto{ Id = a.Id, Name = a.Name }).ToList() },
                },
                Statistics = new List<CharacterCreateStatisticDto>
                {
                    new CharacterCreateStatisticDto { Type = StatisticType.CloseCombat, Name = StatisticType.CloseCombat.ToString(), Value = 10 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Shooting, Name = StatisticType.Shooting.ToString(), Value = 30 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Stamina, Name = StatisticType.Stamina.ToString(), Value = 10 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Resistance, Name = StatisticType.Resistance.ToString(), Value = 10 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Agility, Name = StatisticType.Agility.ToString(), Value = 30 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Inteligence, Name = StatisticType.Inteligence.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Willpower, Name = StatisticType.Willpower.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Polish, Name = StatisticType.Polish.ToString(), Value = 30 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Hitpoints, Name = StatisticType.Hitpoints.ToString(), Value = 0 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Destiny, Name = StatisticType.Destiny.ToString(), Value = 0 },
                }
            };

            result.Add(halfing);

            return Ok(result);
        }
    }
}