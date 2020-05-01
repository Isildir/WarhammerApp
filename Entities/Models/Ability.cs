using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarhammerProfessionApp.Entities.Models.Enums;
using WarhammerProfessionApp.Entities.Models.ManyToMany;
using WarhammerProfessionApp.Utility;

namespace WarhammerProfessionApp.Entities.Models
{
    public class Ability
    {
        public List<CharacterAbility> Characters { get; set; }

        public string Description { get; set; }

        public DictionaryDefinition Dictionary { get; set; }

        public int? DictionaryId { get; set; }

        public bool HasImpactOnStatictics { get; set; }

        [Key]
        public int Id { get; set; }

        public int? ImpactValue { get; set; }

        public bool IsStartingValue { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public List<ProfessionAbility> Professions { get; set; }

        public BuiltInAbilities? Type { get; set; }

        public StatisticType? ValueToAlter { get; set; }
    }
}