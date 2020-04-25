using System;
using System.Collections.Generic;
using System.Linq;
using WarhammerProfessionApp.Entities.Models.Enums;
using WarhammerProfessionApp.Entities.Models.ManyToMany;
using WarhammerProfessionApp.Utility;

namespace WarhammerProfessionApp.Entities.Models.Utility
{
    public class ProfessionBuilder
    {
        private readonly Profession profession;

        public ProfessionBuilder()
        {
            profession = new Profession();
        }

        public ProfessionBuilder AddAbilities(params Ability[] abilities)
        {
            var wrapper = new ProfessionAbilities { Profession = profession };

            foreach (var ability in abilities)
                wrapper.Abilities.Add(new ProfessionAbility
                {
                    ProfessionAbilities = wrapper,
                    Ability = ability
                });

            profession.Abilities.Add(wrapper);

            return this;
        }

        public ProfessionBuilder AddDictionarySkills(Skill skill, Skill dictionarySkill, params string[] values)
        {
            var wrapper = new ProfessionSkills { Profession = profession };

            wrapper.Skills.Add(new ProfessionSkill
            {
                ProfessionSkills = wrapper,
                Skill = skill
            });

            wrapper.Skills.Add(new ProfessionSkill
            {
                ProfessionSkills = wrapper,
                Skill = dictionarySkill,
                AllowAllValues = !values.Any(),
                AllowedValues = dictionarySkill.Dictionary.Values.Where(a => values.Contains(a.Value)).Select(a => new DictionaryValueProfessionSkill { DictionaryValue = a }).ToList()
            });

            profession.Skills.Add(wrapper);

            return this;
        }

        public ProfessionBuilder AddDictionarySkills(params Tuple<Skill, string[]>[] skills)
        {
            var wrapper = new ProfessionSkills { Profession = profession };

            foreach (var skill in skills)
                wrapper.Skills.Add(new ProfessionSkill
                {
                    ProfessionSkills = wrapper,
                    Skill = skill.Item1,
                    AllowAllValues = !skill.Item2.Any(),
                    AllowedValues = skill.Item1.Dictionary.Values.Where(a => skill.Item2.Contains(a.Value)).Select(a => new DictionaryValueProfessionSkill { DictionaryValue = a }).ToList()
                });

            profession.Skills.Add(wrapper);

            return this;
        }

        public ProfessionBuilder AddDictionarySkills(Skill skill, params string[] values)
        {
            var wrapper = new ProfessionSkills { Profession = profession };

            wrapper.Skills.Add(new ProfessionSkill
            {
                ProfessionSkills = wrapper,
                Skill = skill,
                AllowAllValues = !values.Any(),
                AllowedValues = skill.Dictionary.Values.Where(a => values.Contains(a.Value)).Select(a => new DictionaryValueProfessionSkill { DictionaryValue = a }).ToList()
            });

            profession.Skills.Add(wrapper);

            return this;
        }

        public ProfessionBuilder AddEquipment(params ProfessionBuilderItemModel[] items)
        {
            var wrapper = new ProfessionItems { Profession = profession };

            foreach (var item in items)
                wrapper.Items.Add(new ProfessionItem
                {
                    ProfessionItems = wrapper,
                    Item = item.Item,
                    Quantity = item.Quantity
                });

            profession.Equipment.Add(wrapper);

            return this;
        }

        public void AddOutputProfession(Profession outputProfession)
                                                    => profession.OutputProfessions.Add(new ProfessionProfession { OutputProfession = outputProfession });

        public ProfessionBuilder AddSkills(params Skill[] skills)
        {
            var wrapper = new ProfessionSkills { Profession = profession };

            foreach (var skill in skills)
                wrapper.Skills.Add(new ProfessionSkill
                {
                    ProfessionSkills = wrapper,
                    Skill = skill
                });

            profession.Skills.Add(wrapper);

            return this;
        }

        public Profession GetResult() => profession;

        public ProfessionBuilder SetBasicValues(string name, ProfessionLevel professionLevel, Race professionRaceForbidden = 0,
            string description = null, string additionalInformations = null)
        {
            Race allProfessionRaces = 0;

            foreach (Race race in Enum.GetValues(typeof(Race)))
                allProfessionRaces |= race;

            profession.Name = name;
            profession.Description = description;
            profession.AdditionalInformations = additionalInformations;
            profession.ProfessionLevel = professionLevel;
            profession.ProfessionRaceAllowed = allProfessionRaces &= ~professionRaceForbidden;

            return this;
        }

        public ProfessionBuilder SetStatistics(byte closeCombat, byte shooting, byte stamina, byte resistance, byte agility,
            byte inteligence, byte willpower, byte polish, byte attacks, byte hitpoints, byte magic, byte speed, IEnumerable<Statistic> statistics)
        {
            profession.Statistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.CloseCombat), Profession = profession, Value = closeCombat });
            profession.Statistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Speed), Profession = profession, Value = speed });
            profession.Statistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Shooting), Profession = profession, Value = shooting });
            profession.Statistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Stamina), Profession = profession, Value = stamina });
            profession.Statistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Resistance), Profession = profession, Value = resistance });
            profession.Statistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Inteligence), Profession = profession, Value = inteligence });
            profession.Statistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Agility), Profession = profession, Value = agility });
            profession.Statistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Willpower), Profession = profession, Value = willpower });
            profession.Statistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Polish), Profession = profession, Value = polish });
            profession.Statistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Attacks), Profession = profession, Value = attacks });
            profession.Statistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Hitpoints), Profession = profession, Value = hitpoints });
            profession.Statistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Magic), Profession = profession, Value = magic });

            return this;
        }
    }
}