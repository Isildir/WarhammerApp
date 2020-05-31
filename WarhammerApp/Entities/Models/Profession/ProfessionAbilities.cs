using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarhammerApp.API.Entities.Models.ManyToMany
{
    public class ProfessionAbilities
    {
        public ProfessionAbilities()
        {
            Abilities = new List<ProfessionAbility>();
            Characters = new List<ProfessionAbility>();
        }

        public virtual List<ProfessionAbility> Abilities { get; set; }

        public virtual List<ProfessionAbility> Characters { get; set; }

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(ProfessionId))]
        public virtual Profession Profession { get; set; }

        public int ProfessionId { get; set; }
    }
}