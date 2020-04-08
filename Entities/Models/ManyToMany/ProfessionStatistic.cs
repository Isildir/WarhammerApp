namespace WarhammerProfessionApp.Entities.Models
{
    public class ProfessionStatistic
    {
        public Profession Profession { get; set; }

        public int ProfessionId { get; set; }

        public Statistic Statistic { get; set; }

        public byte StatisticId { get; set; }

        public byte Value { get; set; }
    }
}