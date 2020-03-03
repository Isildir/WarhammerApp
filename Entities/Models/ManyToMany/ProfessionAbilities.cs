using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarhammerProfessionApp.Entities.Models.ManyToMany
{
    public class ProfessionAbilities
    {
        public virtual List<ProfessionAbility> Abilities { get; set; }

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(ProfessionId))]
        public virtual Profession Profession { get; set; }

        public int ProfessionId { get; set; }

        public byte Quantity { get; set; }
    }
}