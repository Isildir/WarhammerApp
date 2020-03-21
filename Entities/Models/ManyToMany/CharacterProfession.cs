namespace WarhammerProfessionApp.Entities.Models
{
    public class CharacterProfession
    {
        public int CharacterId { get; set; }

        public Character Character { get; set; }

        public int ProfessionId { get; set; }

        public Profession Profession { get; set; }

        public byte Order { get; set; }
    }
}