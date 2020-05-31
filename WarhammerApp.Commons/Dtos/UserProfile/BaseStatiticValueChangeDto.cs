using WarhammerProfession.Commons.Utility;

namespace WarhammerApp.Commons.Dtos
{
    public class BaseStatiticValueChangeDto
    {
        public StatisticType Type { get; set; }

        public int Value { get; set; }
    }
}