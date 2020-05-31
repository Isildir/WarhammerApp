namespace WarhammerApp.Commons.Dtos
{
    public class CharacterSkillGetDto : CharacterSkillAddDto
    {
        public string Description { get; set; }

        public int Level { get; set; }

        public string Name { get; set; }

        public string Trait { get; set; }
    }
}