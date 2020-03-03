namespace WarhammerProfessionApp.Entities.Models
{

    public class CharacterStatistic
    {
        public int BaseValue { get; set; }

        public int CurrentValue { get; set; }

        public int MaximumValue { get; set; }

        public Statistic Statistic { get; set; }

        public byte StatisticId { get; set; }

        public Character Character { get; set; }

        public int CharacterId { get; set; }
    }
}