using System;
using System.Collections.Generic;
using WarhammerProfessionApp.Entities.Models.Enums;
using WarhammerProfessionApp.Entities.Models.ManyToMany;

namespace WarhammerProfessionApp.Entities.Models.Utility
{
    public class ProfessionBuilder
    {
        private readonly List<ProfessionAbilities> abilityWrappers = new List<ProfessionAbilities>();
        private readonly List<ProfessionItems> itemWrappers = new List<ProfessionItems>();
        private readonly List<ProfessionAbility> professionAbilities = new List<ProfessionAbility>();
        private readonly List<ProfessionItem> professionItems = new List<ProfessionItem>();
        private readonly List<ProfessionSkill> professionSkills = new List<ProfessionSkill>();
        private readonly List<ProfessionSkills> skillWrappers = new List<ProfessionSkills>();
        private Profession profession;

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

        public ProfessionBuilder SetBasicValues(string name, ProfessionLevel professionLevel, ProfessionRaceAllowed professionRaceForbidden = 0,
            string description = null, string additionalInformations = null)
        {
            ProfessionRaceAllowed allProfessionRaces = 0;

            foreach (ProfessionRaceAllowed race in Enum.GetValues(typeof(ProfessionRaceAllowed)))
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
                    Quality = item.Quality,
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
            byte inteligence, byte willpower, byte polish, byte attacks, byte hitpoints, byte magic, byte speed)
        {
            profession.CloseCombat = closeCombat;
            profession.Speed = speed;
            profession.Shooting = shooting;
            profession.Stamina = stamina;
            profession.Resistance = resistance;
            profession.Inteligence = inteligence;
            profession.Agility = agility;
            profession.Willpower = willpower;
            profession.Polish = polish;
            profession.Attacks = attacks;
            profession.Hitpoints = hitpoints;
            profession.Magic = magic;

            return this;
        }
    }
}