namespace WarhammerProfessionApp.Entities.Models
{
    public class CharacterSkill
    {
        public Character Character { get; set; }

        public int CharacterId { get; set; }

        public byte Level { get; set; }

        public Skill Skill { get; set; }

        public int SkillId { get; set; }
    }
}