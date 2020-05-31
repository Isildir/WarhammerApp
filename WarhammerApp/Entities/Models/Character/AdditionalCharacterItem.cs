using System.ComponentModel.DataAnnotations;

namespace WarhammerApp.API.Entities.Models
{
    public class AdditionalCharacterItem
    {
        public Character Character { get; set; }

        public int CharacterId { get; set; }

        public string Description { get; set; }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }

        public int Weight { get; set; }
    }
}