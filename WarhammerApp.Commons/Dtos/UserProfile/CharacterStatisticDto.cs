using WarhammerProfession.Commons.Utility;

namespace WarhammerApp.Commons.Dtos
{
    public class CharacterStatisticDto
    {
        public int BaseValue { get; set; }

        public bool CanBeDecreased { get; set; }

        public bool CanBeIncreased { get; set; }

        public int CurrentValue { get; set; }

        public string Details { get; set; }

        public bool IsReadOnly { get; set; }

        public int MaximumValue { get; set; }

        public string Name { get; set; }

        public StatisticType Type { get; set; }
    }
}