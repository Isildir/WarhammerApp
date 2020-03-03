using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarhammerProfessionApp.Entities.Models
{
    public class Character
    {
        public int UserId { get; set; }

        public User User { get; set; }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int ExperienceUsed { get; set; }

        public int ExperienceSummary { get; set; }

        public int? CurrentProfessionId { get; set; }

        public Profession CurrentProfession { get; set; }

        public int Gold { get; set; }

        public int Silver { get; set; }

        public int Bronze { get; set; }

        public List<CharacterStatistic> Statistics { get; set; }

        public List<ExperienceAdditionalCharacterValue> AdditionalExcerienceCostValues { get; set; }

        public List<AdditionalCharacterValue> AdditionalValues { get; set; }

        public List<CharacterProfession> Professions { get; set; }

        public List<CharacterSkill> Skills { get; set; }

        public List<CharacterAbility> Abilities { get; set; }

        public List<CharacterItem> Items { get; set; }
    }
}