using System.ComponentModel.DataAnnotations;

namespace WarhammerProfessionApp.Entities.Models
{
    public class AdditionalCharacterValue
    {
        public Character Character { get; set; }

        public int CharacterId { get; set; }

        [Key]
        public long Id { get; set; }

        public string Value { get; set; }
    }
}