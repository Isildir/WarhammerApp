using System.ComponentModel.DataAnnotations.Schema;

namespace WarhammerProfessionApp.Entities.Models
{
    public class ProfessionStatistic
    {
        [ForeignKey(nameof(ProfessionId))]
        public Profession Profession { get; set; }

        public int ProfessionId { get; set; }

        [ForeignKey(nameof(StatisticId))]
        public Statistic Statistic { get; set; }

        public short StatisticId { get; set; }

        public byte Value { get; set; }
    }
}