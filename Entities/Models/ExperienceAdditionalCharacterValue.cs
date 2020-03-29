using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WarhammerProfessionApp.Entities.Models
{
    public class ExperienceAdditionalCharacterValue
    {
        public Character Character { get; set; }

        public int CharacterId { get; set; }

        [DefaultValue(100)]
        public int Cost { get; set; }

        [Key]
        public long Id { get; set; }

        public string Value { get; set; }
    }
}