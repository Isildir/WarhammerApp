using System.ComponentModel.DataAnnotations.Schema;

namespace WarhammerProfessionApp.Entities.Models
{
    public class CharacterStatistic
    {
        public int BaseValue { get; set; }

        [ForeignKey(nameof(CharacterId))]
        public Character Character { get; set; }

        public int CharacterId { get; set; }

        public int CurrentValue { get; set; }

        [ForeignKey(nameof(StatisticId))]
        public Statistic Statistic { get; set; }

        public short StatisticId { get; set; }
    }
}