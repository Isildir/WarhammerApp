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

        public bool IsCalculatedValue { get; set; }

        public bool IsReadOnly { get; set; }

        public List<ProfessionStatistic> Professions { get; set; }

        public StatisticType Type { get; set; }
    }
}