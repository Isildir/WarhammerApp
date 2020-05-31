using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WarhammerApp.API.Entities.Models
{
    public class AdditionalCharacterValue
    {
        public Character Character { get; set; }

        public int CharacterId { get; set; }

        [DefaultValue(100)]
        public int Cost { get; set; }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
    }
}