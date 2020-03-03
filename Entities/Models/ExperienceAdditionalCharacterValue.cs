using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WarhammerProfessionApp.Entities.Models
{
    public class ExperienceAdditionalCharacterValue
    {
        [Key]
        public long Id { get; set; }

        public string Value { get; set; }

        [DefaultValue(100)]
        public int Cost { get; set; }

        public Character Character { get; set; }

        public int CharacterId { get; set; }
    }
}