namespace WarhammerProfessionApp.Entities.Models
{
    public class CharacterItem
    {
        public Character Character { get; set; }

        public int CharacterId { get; set; }

        public Item Item { get; set; }

        public int ItemId { get; set; }

        public int Quantity { get; set; }
    }
}