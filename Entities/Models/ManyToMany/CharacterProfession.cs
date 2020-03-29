namespace WarhammerProfessionApp.Entities.Models
{
    public class CharacterProfession
    {
        public Character Character { get; set; }

        public int CharacterId { get; set; }

        public byte Order { get; set; }

        public Profession Profession { get; set; }

        public int ProfessionId { get; set; }
    }
}