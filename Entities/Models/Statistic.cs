using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarhammerProfessionApp.Utility;

namespace WarhammerProfessionApp.Entities.Models
{
    public class Statistic
    {
        public List<CharacterStatistic> Characters { get; set; }

        [Key]
        public byte Id { get; set; }

        public bool IsBasicValue { get; set; }

        public bool IsChangeFree { get; set; }

        public StatisticType Type { get; set; }

        public bool ValueIsCalculated { get; set; }
    }
}