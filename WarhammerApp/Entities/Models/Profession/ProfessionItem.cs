using System.ComponentModel.DataAnnotations.Schema;

namespace WarhammerApp.API.Entities.Models.ManyToMany
{
    public class ProfessionItem
    {
        [ForeignKey(nameof(ItemId))]
        public virtual Item Item { get; set; }

        public int ItemId { get; set; }

        [ForeignKey(nameof(ProfessionsItemId))]
        public virtual ProfessionItems ProfessionItems { get; set; }

        public int ProfessionsItemId { get; set; }

        public int Quantity { get; set; }
    }
}