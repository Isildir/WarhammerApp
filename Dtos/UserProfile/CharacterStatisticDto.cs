using WarhammerProfessionApp.Utility;

namespace WarhammerProfessionApp.Dtos
{
    public class CharacterStatisticDto
    {
        public StatisticType Type { get; set; }

        public string Name { get; set; }

        public int BaseValue { get; set; }

        public int CurrentValue { get; set; }

        public int MaximumValue { get; set; }

        public bool IsBasicValue { get; set; }
    }
}