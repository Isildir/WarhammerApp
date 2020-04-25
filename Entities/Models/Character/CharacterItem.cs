using System.ComponentModel.DataAnnotations.Schema;

namespace WarhammerProfessionApp.Entities.Models
{
    public class CharacterItem
    {
        [ForeignKey(nameof(CharacterId))]
        public Character Character { get; set; }

        public int CharacterId { get; set; }

        [ForeignKey(nameof(ItemId))]
        public Item Item { get; set; }

        public int ItemId { get; set; }

        public int Quantity { get; set; }
    }
}