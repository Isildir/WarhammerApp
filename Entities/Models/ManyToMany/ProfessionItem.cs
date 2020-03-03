using System.ComponentModel.DataAnnotations.Schema;
using WarhammerProfessionApp.Entities.Models.Enums;

namespace WarhammerProfessionApp.Entities.Models.ManyToMany
{
    public class ProfessionItem
    {
        [ForeignKey(nameof(ItemId))]
        public virtual Item Item { get; set; }

        public int ItemId { get; set; }

        [ForeignKey(nameof(ProfessionsItemId))]
        public virtual ProfessionItems ProfessionItems { get; set; }

        public int ProfessionsItemId { get; set; }

        public ItemQuality Quality { get; set; }

        public int Quantity { get; set; }
    }
}