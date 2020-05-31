using WarhammerProfession.Commons.Utility;

namespace WarhammerApp.Commons.Dtos
{
    public class StatiticValueChangeDto
    {
        public bool IncrementingValue { get; set; }

        public StatisticType Type { get; set; }
    }
}