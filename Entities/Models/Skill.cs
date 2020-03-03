using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarhammerProfessionApp.Entities.Models.Enums;
using WarhammerProfessionApp.Entities.Models.ManyToMany;
using WarhammerProfessionApp.Utility;

namespace WarhammerProfessionApp.Entities.Models
{
    public class Skill
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public List<ProfessionSkill> Professions { get; set; }

        public SkillLevel SkillLevel { get; set; }

        public StatisticType Trait { get; set; }

        public string Description { get; set; }

        public List<CharacterSkill> Characters { get; set; }
    }
}