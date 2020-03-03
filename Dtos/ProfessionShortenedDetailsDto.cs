namespace WarhammerProfessionApp.Dtos
{
    public class ProfessionShortenedDetailsDto : ProfessionDetailsBaseDto
    {
        public string Abilities { get; set; }

        public string Equipment { get; set; }

        public string ProfessionLevel { get; set; }

        public string ProfessionRaceAllowed { get; set; }

        public string Skills { get; set; }
    }
}