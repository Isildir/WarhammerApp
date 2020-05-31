using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarhammerProfession.Commons.Utility;
using WarhammerApp.API.Entities.Models.Enums;

namespace WarhammerApp.API.Entities.Models
{
    public class Character
    {
        public Character()
        {
            Abilities = new List<CharacterAbility>();
            AdditionalValues = new List<AdditionalCharacterValue>();
            AdditionalItems = new List<AdditionalCharacterItem>();
            Professions = new List<CharacterProfession>();
            Items = new List<CharacterItem>();
            Skills = new List<CharacterSkill>();
            Statistics = new List<CharacterStatistic>();
        }

        public List<CharacterAbility> Abilities { get; set; }

        public List<AdditionalCharacterItem> AdditionalItems { get; set; }

        public List<AdditionalCharacterValue> AdditionalValues { get; set; }

        public Profession CurrentProfession { get; set; }

        public int? CurrentProfessionId { get; set; }

        public int ExperienceSummary { get; set; }

        public int ExperienceUsed { get; set; }

        [Key]
        public int Id { get; set; }

        public List<CharacterItem> Items { get; set; }

        public int Money { get; set; }

        public string Name { get; set; }

        public string Notes { get; set; }

        public List<CharacterProfession> Professions { get; set; }

        public Race Race { get; set; }

        public List<CharacterSkill> Skills { get; set; }

        public List<CharacterStatistic> Statistics { get; set; }

        public User User { get; set; }

        public int UserId { get; set; }
    }
}