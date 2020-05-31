using WarhammerProfession.Commons.Utility;

namespace WarhammerApp.Commons.Dtos
{
    public class CharacterCreateStatisticDto
    {
        public string Name { get; set; }

        public StatisticType Type { get; set; }

        public int Value { get; set; }
    }
}