using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarhammerProfession.Commons.Utility;
using WarhammerApp.API.Entities.Models.Enums;
using WarhammerApp.API.Entities.Models.ManyToMany;

namespace WarhammerApp.API.Entities.Models
{
    public class Skill
    {
        public List<CharacterSkill> Characters { get; set; }

        public string Description { get; set; }

        public DictionaryDefinition Dictionary { get; set; }

        public int? DictionaryId { get; set; }

        [Key]
        public int Id { get; set; }

        public bool IsBasicLevel { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public List<ProfessionSkill> Professions { get; set; }

        public StatisticType Trait { get; set; }

        public BuiltInSkills? Type { get; set; }
    }
}