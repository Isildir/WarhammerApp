namespace WarhammerProfessionApp.Dtos
{
    public class CharacterBasicValuesDto
    {
        public string ActualProfessionName { get; set; }

        public int ExperienceLeft { get; set; }

        public int ExperienceSum { get; set; }

        public string Name { get; set; }

        public string Notes { get; set; }

        public RaceDto Race { get; set; }
    }
}