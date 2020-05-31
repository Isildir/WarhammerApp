namespace WarhammerApp.Commons.Dtos
{
    public class CharacterBasicValuesDto
    {
        public string ActualProfessionName { get; set; }

        public string CurrentLoad { get; set; }

        public int ExperienceLeft { get; set; }

        public int ExperienceSum { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Notes { get; set; }

        public RaceDto Race { get; set; }
    }
}