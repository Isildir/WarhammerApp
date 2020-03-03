using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarhammerProfessionApp.Entities.Models.ManyToMany;
using WarhammerProfessionApp.Utility;

namespace WarhammerProfessionApp.Entities.Models
{
    public class Ability
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public List<ProfessionAbility> Professions { get; set; }

        public string Description { get; set; }

        public List<CharacterAbility> Characters { get; set; }

        public bool HasImpactOnStatictics { get; set; }

        public int? ImpactValue { get; set; }

        public StatisticType? ValueToAlter { get; set; }
    }
}