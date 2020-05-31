using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarhammerApp.API.Entities.Models.ManyToMany
{
    public class ProfessionItems
    {
        public ProfessionItems()
        {
            Items = new List<ProfessionItem>();
        }

        [Key]
        public int Id { get; set; }

        public virtual List<ProfessionItem> Items { get; set; }

        [ForeignKey(nameof(ProfessionId))]
        public virtual Profession Profession { get; set; }

        public int ProfessionId { get; set; }
    }
}