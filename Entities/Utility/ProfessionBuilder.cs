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
        public ProfessionBuilder()
        {
            profession = new Profession();
        }

        public void Clear()
        {
            profession = new Profession();
            skillWrappers.Clear();
            professionSkills.Clear();
            itemWrappers.Clear();
            professionItems.Clear();
            abilityWrappers.Clear();
            professionAbilities.Clear();
        }

        public Dictionary<Type, object> GetAllRelations() => new Dictionary<Type, object>
            {
                { typeof(ProfessionSkills), skillWrappers },
                { typeof(ProfessionSkill), professionSkills },
                { typeof(ProfessionItems), itemWrappers },
                { typeof(ProfessionItem), professionItems },
                { typeof(ProfessionAbilities), abilityWrappers },
                { typeof(ProfessionAbility), professionAbilities },
                { typeof(ProfessionStatistic), professionStatistics },
            };

        public Profession GetResult() => profession;

        public ProfessionBuilder SetAbilities(params Ability[] abilities) => SetAbilities(1, abilities);

        public ProfessionBuilder SetAbilities(byte numberAllowed, params Ability[] abilities)
        {
            var wrapper = new ProfessionAbilities { Quantity = numberAllowed, Profession = profession };

            profession.Abilities.Add(wrapper);
            abilityWrappers.Add(wrapper);

            foreach (var ability in abilities)
                professionAbilities.Add(new ProfessionAbility
                {
                    ProfessionAbilities = wrapper,
                    Ability = ability
                });

            return this;
        }

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

        public ProfessionBuilder SetEquipment(params ProfessionBuilderItemModel[] items) => SetEquipment(1, items);

        public ProfessionBuilder SetEquipment(byte numberAllowed, params ProfessionBuilderItemModel[] items)
        {
            var wrapper = new ProfessionItems { Quantity = numberAllowed, Profession = profession };

            profession.Equipment.Add(wrapper);
            itemWrappers.Add(wrapper);

            foreach (var item in items)
                professionItems.Add(new ProfessionItem
                {
                    ProfessionItems = wrapper,
                    Item = item.Item,
                    Quantity = item.Quantity
                });

            return this;
        }

        public ProfessionBuilder SetSkills(params Skill[] skills) => SetSkills(1, skills);

        public ProfessionBuilder SetSkills(byte numberAllowed, params Skill[] skills)
        {
            var wrapper = new ProfessionSkills { Quantity = numberAllowed, Profession = profession };

            profession.Skills.Add(wrapper);
            skillWrappers.Add(wrapper);

            foreach (var skill in skills)
                professionSkills.Add(new ProfessionSkill
                {
                    ProfessionSkills = wrapper,
                    Skill = skill
                });

            return this;
        }

        public ProfessionBuilder SetStatistics(byte closeCombat, byte shooting, byte stamina, byte resistance, byte agility,
            byte inteligence, byte willpower, byte polish, byte attacks, byte hitpoints, byte magic, byte speed, IEnumerable<Statistic> statistics)
        {
            professionStatistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.CloseCombat), Profession = profession, Value = closeCombat });
            professionStatistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Speed), Profession = profession, Value = speed });
            professionStatistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Shooting), Profession = profession, Value = shooting });
            professionStatistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Stamina), Profession = profession, Value = stamina });
            professionStatistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Resistance), Profession = profession, Value = resistance });
            professionStatistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Inteligence), Profession = profession, Value = inteligence });
            professionStatistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Agility), Profession = profession, Value = agility });
            professionStatistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Willpower), Profession = profession, Value = willpower });
            professionStatistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Polish), Profession = profession, Value = polish });
            professionStatistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Attacks), Profession = profession, Value = attacks });
            professionStatistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Hitpoints), Profession = profession, Value = hitpoints });
            professionStatistics.Add(new ProfessionStatistic { Statistic = statistics.FirstOrDefault(a => a.Type == StatisticType.Magic), Profession = profession, Value = magic });

            return this;
        }

        private readonly List<ProfessionAbilities> abilityWrappers = new List<ProfessionAbilities>();
        private readonly List<ProfessionItems> itemWrappers = new List<ProfessionItems>();
        private readonly List<ProfessionAbility> professionAbilities = new List<ProfessionAbility>();
        private readonly List<ProfessionItem> professionItems = new List<ProfessionItem>();
        private readonly List<ProfessionSkill> professionSkills = new List<ProfessionSkill>();
        private readonly List<ProfessionStatistic> professionStatistics = new List<ProfessionStatistic>();
        private readonly List<ProfessionSkills> skillWrappers = new List<ProfessionSkills>();
        private Profession profession;
    }
}