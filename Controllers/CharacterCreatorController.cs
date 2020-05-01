using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using WarhammerProfessionApp.Entities;
using WarhammerProfessionApp.Entities.Models;
using WarhammerProfessionApp.Entities.Models.Enums;
using WarhammerProfessionApp.Utility;

namespace WarhammerProfessionApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController, Authorize]
    public class CharacterCreatorController : ControllerBase
    {
        private static readonly BuiltInAbilities[] abilitiesTypes = new BuiltInAbilities[]
        {
                BuiltInAbilities.SpecialWeapon,
                BuiltInAbilities.SenseOfMagic,
                BuiltInAbilities.SharpEyesight,
                BuiltInAbilities.SelfControl,
                BuiltInAbilities.Brilliance,
                BuiltInAbilities.SeeingInTheDark,
                BuiltInAbilities.DwarvenExpert,
                BuiltInAbilities.Durable,
                BuiltInAbilities.MagicResistance,
                BuiltInAbilities.Courage,
                BuiltInAbilities.Hatred,
                BuiltInAbilities.ChaosResistance
        };

        private static readonly BuiltInDictionaryValues[] dictionaryValuesTypes = new BuiltInDictionaryValues[]
        {
                BuiltInDictionaryValues.KnowledgeEmpire,
                BuiltInDictionaryValues.LanguageOldWorld,
                BuiltInDictionaryValues.KnowledgeElves,
                BuiltInDictionaryValues.LanguageEltharin,
                BuiltInDictionaryValues.CraftMining,
                BuiltInDictionaryValues.CraftMasonry,
                BuiltInDictionaryValues.CraftBlacksmithing,
                BuiltInDictionaryValues.LanguageKhazalid,
                BuiltInDictionaryValues.KnowledgeDwarves,
                BuiltInDictionaryValues.ScienceGenealogy,
                BuiltInDictionaryValues.CraftCooking,
                BuiltInDictionaryValues.CraftTillage,
                BuiltInDictionaryValues.KnowledgeHalfings,
                BuiltInDictionaryValues.LanguageHalfings,
                BuiltInDictionaryValues.SpecialWeaponLongBow,
                BuiltInDictionaryValues.SpecialWeaponSlingShot
        };

        private static readonly BuiltInSkills[] skillsTypes = new BuiltInSkills[]
        {
                BuiltInSkills.Gossip,
                BuiltInSkills.Language,
                BuiltInSkills.Knowledge,
                BuiltInSkills.Craft,
                BuiltInSkills.Science,
        };

        private static readonly Dictionary<StatisticType, Dictionary<Race, int>> startingRaceStatistics = new Dictionary<StatisticType, Dictionary<Race, int>>
            {
                { StatisticType.CloseCombat, new Dictionary<Race, int>{ { Race.Human, 20}, { Race.Elf, 20 }, { Race.Dwarf, 30 }, {Race.Halfing, 10 }} },
                { StatisticType.Shooting, new Dictionary<Race, int>{ { Race.Human, 20}, { Race.Elf, 30 }, { Race.Dwarf, 20 }, {Race.Halfing, 30 }} },
                { StatisticType.Stamina, new Dictionary<Race, int>{ { Race.Human, 20}, { Race.Elf, 20 }, { Race.Dwarf, 20 }, {Race.Halfing, 10 }} },
                { StatisticType.Resistance, new Dictionary<Race, int>{ { Race.Human, 20}, { Race.Elf, 20 }, { Race.Dwarf, 30 }, {Race.Halfing, 10 }} },
                { StatisticType.Agility, new Dictionary<Race, int>{ { Race.Human, 20}, { Race.Elf, 30 }, { Race.Dwarf, 10 }, {Race.Halfing, 30 }} },
                { StatisticType.Polish, new Dictionary<Race, int>{ { Race.Human, 20}, { Race.Elf, 20 }, { Race.Dwarf, 10 }, {Race.Halfing, 30 }} },
            };

        private readonly ProfessionsContext context;

        public CharacterCreatorController(ProfessionsContext context)
        {
            this.context = context;
        }

        [HttpGet(nameof(GetNewCharacterData))]
        public ActionResult<List<CharacterCreationDto>> GetNewCharacterData()
        {
            var result = new List<CharacterCreationDto>();

            var abilitiesPool = context.Abilities
                .Where(a => a.IsStartingValue || (a.Type.HasValue && abilitiesTypes.Contains(a.Type.Value)))
                .AsNoTracking()
                .Select(a => new Ability
                {
                    Id = a.Id,
                    Name = a.Name,
                    Type = a.Type,
                    IsStartingValue = a.IsStartingValue
                }).ToList();

            var skillsPool = context.Skills
                .Where(a => a.Type.HasValue && skillsTypes.Contains(a.Type.Value))
                .AsNoTracking()
                .Select(a => new Skill
                {
                    Id = a.Id,
                    Name = a.Name,
                    Type = a.Type
                }).ToList();

            var dictionaryValuesPool = context.DictionaryValues
                .Where(a => a.Type.HasValue && dictionaryValuesTypes.Contains(a.Type.Value))
                .AsNoTracking()
                .Select(a => new DictionaryValue
                {
                    Id = a.Id,
                    Value = a.Value,
                    Type = a.Type
                }).ToList();

            var races = new Race[] { Race.Human, Race.Elf, Race.Dwarf, Race.Halfing };

            foreach (var race in races)
                result.Add(new CharacterCreationDto
                {
                    Race = race,
                    SkillsSet = GetRequiredSkillsSortedByRace(race, skillsPool, dictionaryValuesPool),
                    SkillsChoice = GetOptionalSkillsSortedByRace(race, skillsPool, dictionaryValuesPool),
                    AbilitiesSet = GetRequiredAbilitiesSortedByRace(race, abilitiesPool, dictionaryValuesPool),
                    AbilitiesChoice = GetOptionalAbilitiesSortedByRace(race, abilitiesPool, dictionaryValuesPool),
                    Statistics = GetBaseStatisticsSortedByRace(race)
                });

            return Ok(result);
        }

        [HttpPost(nameof(PostFinishedCharacter))]
        public ActionResult<CharacterInListDto> PostFinishedCharacter([FromBody] CharacterCreationFinishedDto character)
        {
            var optionalSkills = GetOptionalSkillsSortedByRace(character.Race, null, null);
            var optionalAbilities = GetOptionalSkillsSortedByRace(character.Race, null, null);
            var minimumStatistics = GetBaseStatisticsSortedByRace(character.Race);

            var selectedProfession = context.Professions
                .Include(a => a.Skills).ThenInclude(a => a.Skills).ThenInclude(a => a.Skill)
                .Include(a => a.Skills).ThenInclude(a => a.Skills).ThenInclude(a => a.AllowedValues)
                .Include(a => a.Abilities).ThenInclude(a => a.Abilities).ThenInclude(a => a.Ability)
                .Include(a => a.Abilities).ThenInclude(a => a.Abilities).ThenInclude(a => a.AllowedValues)
                .FirstOrDefault(a => a.Id == character.ProfessionId && a.IsBasicLevel);

            if (selectedProfession == null)
                return BadRequest();

            var conditions = new bool[7];

            conditions.Append(optionalSkills.All(a => a.Values.Any(b => character.RaceSkills.Any(c => c.Id == b.Id))));
            conditions.Append(optionalAbilities.All(a => a.Values.Any(b => character.RaceAbilities.Any(c => c.Id == b.Id))));
            conditions.Append(minimumStatistics.All(a => character.Statistics.Any(b => b.Type == a.Type && b.Value > a.Value)));
            conditions.Append(optionalSkills.Count == character.RaceSkills.Count && optionalAbilities.Count == character.RaceAbilities.Count);
            conditions.Append(selectedProfession.Skills.All(a => a.Skills.Any(b => character.ProfessionSkills.Any(c => c.Id == b.Id && (!b.Skill.DictionaryId.HasValue || b.AllowedValues.Any(d => d.DictionaryValueId == c.DictionaryValueId))))));
            conditions.Append(selectedProfession.Abilities.All(a => a.Abilities.Any(b => character.ProfessionAbilities.Any(c => c.Id == b.Id && (!b.Ability.DictionaryId.HasValue || b.AllowedValues.Any(d => d.DictionaryValueId == c.DictionaryValueId))))));
            conditions.Append(selectedProfession.Skills.Count == character.ProfessionSkills.Count && selectedProfession.Abilities.Count == character.ProfessionAbilities.Count);

            if (conditions.Any(a => !a))
                return BadRequest();

            var skills = GetRequiredSkillsSortedByRace(character.Race, null, null).Union(character.RaceSkills)
                .Select(a => new CharacterSkill
                {
                    SkillId = a.Id,
                    DictionaryValueId = a.DictionaryValueId,
                    IsAdditionalValue = true,
                }).Union(character.ProfessionSkills.Select(a => new CharacterSkill
                {
                    SkillId = a.Id,
                    DictionaryValueId = a.DictionaryValueId
                }));

            var abilities = GetRequiredSkillsSortedByRace(character.Race, null, null).Union(character.RaceAbilities)
                .Select(a => new CharacterAbility
                {
                    AbilityId = a.Id,
                    DictionaryValueId = a.DictionaryValueId,
                    IsAdditionalValue = true,
                }).Union(character.ProfessionAbilities.Select(a => new CharacterAbility
                {
                    AbilityId = a.Id,
                    DictionaryValueId = a.DictionaryValueId
                }));

            var statistics = context.Statistics.Select(a => new { a.Id, a.Type }).ToList();

            var record = new Character
            {
                Name = character.Name,
                Race = character.Race,
                UserId = ClaimsReader.GetUserId(Request),
                CurrentProfessionId = character.ProfessionId,
                Abilities = abilities.ToList(),
                Skills = skills.ToList()
            };

            foreach (var statistic in statistics)
            {
                var value = character.Statistics.FirstOrDefault(b => b.Type == statistic.Type)?.Value ?? 0;

                if (statistic.Type == StatisticType.Attacks)
                    value = 1;
                else if (statistic.Type == StatisticType.Speed)
                    value = character.Race == Race.Elf ? 5 : character.Race == Race.Dwarf ? 3 : 4;

                record.Statistics.Add(new CharacterStatistic { StatisticId = statistic.Id, BaseValue = value, CurrentValue = value });
            }

            context.Characters.Add(record);

            try
            {
                context.SaveChanges();

                return Ok(record.Id);
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

        private List<CharacterCreateStatisticDto> GetBaseStatisticsSortedByRace(Race race)
        {
            return new List<CharacterCreateStatisticDto>
                {
                    new CharacterCreateStatisticDto { Type = StatisticType.CloseCombat, Name = StatisticType.CloseCombat.ToString(), Value = startingRaceStatistics[StatisticType.CloseCombat][race] },
                    new CharacterCreateStatisticDto { Type = StatisticType.Shooting, Name = StatisticType.Shooting.ToString(), Value = startingRaceStatistics[StatisticType.CloseCombat][race] },
                    new CharacterCreateStatisticDto { Type = StatisticType.Stamina, Name = StatisticType.Stamina.ToString(), Value = startingRaceStatistics[StatisticType.CloseCombat][race] },
                    new CharacterCreateStatisticDto { Type = StatisticType.Resistance, Name = StatisticType.Resistance.ToString(), Value = startingRaceStatistics[StatisticType.CloseCombat][race] },
                    new CharacterCreateStatisticDto { Type = StatisticType.Agility, Name = StatisticType.Agility.ToString(), Value = startingRaceStatistics[StatisticType.CloseCombat][race] },
                    new CharacterCreateStatisticDto { Type = StatisticType.Polish, Name = StatisticType.Polish.ToString(), Value = startingRaceStatistics[StatisticType.CloseCombat][race] },
                    new CharacterCreateStatisticDto { Type = StatisticType.Inteligence, Name = StatisticType.Inteligence.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Willpower, Name = StatisticType.Willpower.ToString(), Value = 20 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Hitpoints, Name = StatisticType.Hitpoints.ToString(), Value = 0 },
                    new CharacterCreateStatisticDto { Type = StatisticType.Destiny, Name = StatisticType.Destiny.ToString(), Value = 0 },
                };
        }

        private List<CharacterCreationValueGroupDto> GetOptionalAbilitiesSortedByRace(Race race, IEnumerable<Ability> abilitiesPool, IEnumerable<DictionaryValue> dictionaryValuesPool)
        {
            if (race == Race.Human)
            {
                var values = (abilitiesPool ?? context.Abilities.Where(a => a.IsStartingValue)).Select(a => new { a.Id, a.Name });

                return new List<CharacterCreationValueGroupDto>
                {
                    new CharacterCreationValueGroupDto { Quantity = 2, Values = values.Select(a => new CharacterCreationValueDto{ Id = a.Id, Name = a.Name }).ToList() }
                };
            }
            else if (race == Race.Elf)
            {
                var specialWeapon = (abilitiesPool ?? context.Abilities).FirstOrDefault(a => a.Type == BuiltInAbilities.SpecialWeapon);
                var senseOfMagic = (abilitiesPool ?? context.Abilities).FirstOrDefault(a => a.Type == BuiltInAbilities.SenseOfMagic);
                var selfcontrol = (abilitiesPool ?? context.Abilities).FirstOrDefault(a => a.Type == BuiltInAbilities.SelfControl);
                var brilliance = (abilitiesPool ?? context.Abilities).FirstOrDefault(a => a.Type == BuiltInAbilities.Brilliance);

                var longBow = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.SpecialWeaponLongBow);

                return new List<CharacterCreationValueGroupDto>
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
                };
            }
            else if (race == Race.Halfing)
            {
                var values = (abilitiesPool ?? context.Abilities).Where(a => a.IsStartingValue && a.Type != BuiltInAbilities.SeeingInTheDark).Select(a => new { a.Id, a.Name }).ToList();

                return new List<CharacterCreationValueGroupDto>
                {
                    new CharacterCreationValueGroupDto { Values = values.Select(a => new CharacterCreationValueDto{ Id = a.Id, Name = a.Name }).ToList() },
                };
            }
            else
                return new List<CharacterCreationValueGroupDto>();
        }

        private List<CharacterCreationValueGroupDto> GetOptionalSkillsSortedByRace(Race race, IEnumerable<Skill> skillsPool, IEnumerable<DictionaryValue> dictionaryValuesPool)
        {
            if (race == Race.Dwarf)
            {
                var craft = (skillsPool ?? context.Skills).FirstOrDefault(a => a.Type == BuiltInSkills.Craft);

                var miningCraft = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.CraftMining);
                var masonryCraft = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.CraftMasonry);
                var blacksmithingCraft = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.CraftBlacksmithing);

                return new List<CharacterCreationValueGroupDto>
                {
                    new CharacterCreationValueGroupDto
                    {
                        Values = new List<CharacterCreationValueDto>
                        {
                            new CharacterCreationValueDto
                            {
                                Id = craft.Id,
                                Name = $"{craft.Name} ({miningCraft.Value})",
                                DictionaryValueId = miningCraft.Id
                            },
                            new CharacterCreationValueDto
                            {
                                Id = craft.Id,
                                Name = $"{craft.Name} ({masonryCraft.Value})",
                                DictionaryValueId = masonryCraft.Id
                            },
                            new CharacterCreationValueDto
                            {
                                Id = craft.Id,
                                Name = $"{craft.Name} ({blacksmithingCraft.Value})",
                                DictionaryValueId = blacksmithingCraft.Id
                            }
                        }
                    }
                };
            }
            else if (race == Race.Halfing)
            {
                var craft = (skillsPool ?? context.Skills).FirstOrDefault(a => a.Type == BuiltInSkills.Craft);

                var cookingCraft = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.CraftCooking);
                var tillageCraft = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.CraftTillage);

                return new List<CharacterCreationValueGroupDto>
                {
                    new CharacterCreationValueGroupDto
                    {
                        Values = new List<CharacterCreationValueDto>
                        {
                            new CharacterCreationValueDto { Id = craft.Id, Name = $"{craft.Name} ({cookingCraft.Value})", DictionaryValueId = cookingCraft.Id },
                            new CharacterCreationValueDto { Id = craft.Id, Name = $"{craft.Name} ({tillageCraft.Value})", DictionaryValueId = tillageCraft.Id }
                        }
                    }
                };
            }
            else
                return new List<CharacterCreationValueGroupDto>();
        }

        private List<CharacterCreationValueDto> GetRequiredAbilitiesSortedByRace(Race race, IEnumerable<Ability> abilitiesPool, IEnumerable<DictionaryValue> dictionaryValuesPool)
        {
            if (race == Race.Elf)
            {
                var sharpeye = (abilitiesPool ?? context.Abilities).FirstOrDefault(a => a.Type == BuiltInAbilities.SharpEyesight);
                var darkseeing = (abilitiesPool ?? context.Abilities).FirstOrDefault(a => a.Type == BuiltInAbilities.SeeingInTheDark);

                return new List<CharacterCreationValueDto>
                {
                    new CharacterCreationValueDto { Id = sharpeye.Id, Name = sharpeye.Name },
                    new CharacterCreationValueDto { Id = darkseeing.Id, Name = darkseeing.Name },
                };
            }
            else if (race == Race.Dwarf)
            {
                var darkseeing = (abilitiesPool ?? context.Abilities).FirstOrDefault(a => a.Type == BuiltInAbilities.SeeingInTheDark);
                var dwarvenExpert = (abilitiesPool ?? context.Abilities).FirstOrDefault(a => a.Type == BuiltInAbilities.DwarvenExpert);
                var durable = (abilitiesPool ?? context.Abilities).FirstOrDefault(a => a.Type == BuiltInAbilities.Durable);
                var magicResistance = (abilitiesPool ?? context.Abilities).FirstOrDefault(a => a.Type == BuiltInAbilities.MagicResistance);
                var courage = (abilitiesPool ?? context.Abilities).FirstOrDefault(a => a.Type == BuiltInAbilities.Courage);
                var hatred = (abilitiesPool ?? context.Abilities).FirstOrDefault(a => a.Type == BuiltInAbilities.Hatred);

                return new List<CharacterCreationValueDto>
                {
                    new CharacterCreationValueDto { Id = dwarvenExpert.Id, Name = dwarvenExpert.Name },
                    new CharacterCreationValueDto { Id = durable.Id, Name = durable.Name },
                    new CharacterCreationValueDto { Id = magicResistance.Id, Name = magicResistance.Name },
                    new CharacterCreationValueDto { Id = courage.Id, Name = courage.Name },
                    new CharacterCreationValueDto { Id = darkseeing.Id, Name = darkseeing.Name },
                    new CharacterCreationValueDto { Id = hatred.Id, Name = hatred.Name },
                };
            }
            else if (race == Race.Halfing)
            {
                var darkseeing = (abilitiesPool ?? context.Abilities).FirstOrDefault(a => a.Type == BuiltInAbilities.SeeingInTheDark);
                var specialWeapon = (abilitiesPool ?? context.Abilities).FirstOrDefault(a => a.Type == BuiltInAbilities.SpecialWeapon);
                var chaosResistance = (abilitiesPool ?? context.Abilities).FirstOrDefault(a => a.Type == BuiltInAbilities.ChaosResistance);
                var slingShot = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.SpecialWeaponSlingShot);

                return new List<CharacterCreationValueDto>
                {
                    new CharacterCreationValueDto { Id = specialWeapon.Id, Name = $"{specialWeapon.Name} ({slingShot.Value})", DictionaryValueId = slingShot.Id },
                    new CharacterCreationValueDto { Id = darkseeing.Id, Name = darkseeing.Name },
                    new CharacterCreationValueDto { Id = chaosResistance.Id, Name = chaosResistance.Name },
                };
            }
            else
                return new List<CharacterCreationValueDto>();
        }

        private List<CharacterCreationValueDto> GetRequiredSkillsSortedByRace(Race race, IEnumerable<Skill> skillsPool, IEnumerable<DictionaryValue> dictionaryValuesPool)
        {
            var knowledge = (skillsPool ?? context.Skills).FirstOrDefault(a => a.Type == BuiltInSkills.Knowledge);
            var language = (skillsPool ?? context.Skills).FirstOrDefault(a => a.Type == BuiltInSkills.Language);
            var oldworldLanaguage = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.LanguageOldWorld);

            if (race == Race.Human)
            {
                var gossip = (skillsPool ?? context.Skills).FirstOrDefault(a => a.Type == BuiltInSkills.Gossip);
                var empireKnowledge = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.KnowledgeEmpire);

                return new List<CharacterCreationValueDto>
                {
                    new CharacterCreationValueDto { Id = gossip.Id, Name = gossip.Name },
                    new CharacterCreationValueDto { Id = knowledge.Id, Name = $"{knowledge.Name} ({empireKnowledge.Value})", DictionaryValueId = empireKnowledge.Id },
                    new CharacterCreationValueDto { Id = language.Id, Name = $"{language.Name} ({oldworldLanaguage.Value})", DictionaryValueId = oldworldLanaguage.Id }
                };
            }
            else if (race == Race.Elf)
            {
                var elvesKnowledge = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.KnowledgeElves);
                var eltharinLanguage = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.LanguageEltharin);

                return new List<CharacterCreationValueDto>
                {
                    new CharacterCreationValueDto { Id = knowledge.Id, Name = $"{knowledge.Name} ({elvesKnowledge.Value})", DictionaryValueId = elvesKnowledge.Id },
                    new CharacterCreationValueDto { Id = language.Id, Name = $"{language.Name} ({eltharinLanguage.Value})", DictionaryValueId = eltharinLanguage.Id },
                    new CharacterCreationValueDto { Id = language.Id, Name = $"{language.Name} ({oldworldLanaguage.Value})", DictionaryValueId = oldworldLanaguage.Id }
                };
            }
            else if (race == Race.Dwarf)
            {
                var khazalidLanguage = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.LanguageKhazalid);
                var dwarvesKnowledge = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.KnowledgeDwarves);

                return new List<CharacterCreationValueDto>
                {
                    new CharacterCreationValueDto { Id = knowledge.Id, Name = $"{knowledge.Name} ({dwarvesKnowledge.Value})", DictionaryValueId = dwarvesKnowledge.Id },
                    new CharacterCreationValueDto { Id = language.Id, Name = $"{language.Name} ({khazalidLanguage.Value})", DictionaryValueId = khazalidLanguage.Id },
                    new CharacterCreationValueDto { Id = language.Id, Name = $"{language.Name} ({oldworldLanaguage.Value})", DictionaryValueId = oldworldLanaguage.Id }
                };
            }
            else if (race == Race.Halfing)
            {
                var gossip = (skillsPool ?? context.Skills).FirstOrDefault(a => a.Type == BuiltInSkills.Gossip);
                var science = (skillsPool ?? context.Skills).FirstOrDefault(a => a.Type == BuiltInSkills.Science);
                var genealogyKnowledge = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.ScienceGenealogy);
                var halfingsKnowledge = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.KnowledgeHalfings);
                var halfingsLanguage = (dictionaryValuesPool ?? context.DictionaryValues).FirstOrDefault(a => a.Type == BuiltInDictionaryValues.LanguageHalfings);

                return new List<CharacterCreationValueDto>
                {
                    new CharacterCreationValueDto { Id = gossip.Id, Name = gossip.Name },
                    new CharacterCreationValueDto { Id = science.Id, Name = $"{science.Name} ({genealogyKnowledge.Value})", DictionaryValueId = genealogyKnowledge.Id },
                    new CharacterCreationValueDto { Id = knowledge.Id, Name = $"{knowledge.Name} ({halfingsKnowledge.Value})", DictionaryValueId = halfingsKnowledge.Id },
                    new CharacterCreationValueDto { Id = language.Id, Name = $"{language.Name} ({halfingsLanguage.Value})", DictionaryValueId = halfingsLanguage.Id },
                    new CharacterCreationValueDto { Id = language.Id, Name = $"{language.Name} ({oldworldLanaguage.Value})", DictionaryValueId = oldworldLanaguage.Id }
                };
            }
            else
                return new List<CharacterCreationValueDto>();
        }
    }
}