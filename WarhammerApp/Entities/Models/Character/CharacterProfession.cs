using System.ComponentModel.DataAnnotations.Schema;

namespace WarhammerApp.API.Entities.Models
{
    public class CharacterProfession
    {
        [ForeignKey(nameof(CharacterId))]
        public Character Character { get; set; }

        public int CharacterId { get; set; }

        public byte Order { get; set; }

        [ForeignKey(nameof(ProfessionId))]
        public Profession Profession { get; set; }

        public int ProfessionId { get; set; }
    }
}