using WarhammerProfessionApp.Utility;

namespace WarhammerProfessionApp.Controllers
{
    public class CharacterCreateStatisticDto
    {
        public string Name { get; set; }

        public StatisticType Type { get; set; }

        public int Value { get; set; }
    }
}