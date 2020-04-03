using WarhammerProfessionApp.Utility;

namespace WarhammerProfessionApp.Dtos
{
    public class BaseStatiticValueChangeDto
    {
        public StatisticType Type { get; set; }

        public int Value { get; set; }
    }
}