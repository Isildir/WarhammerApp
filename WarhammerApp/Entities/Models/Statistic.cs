using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarhammerProfession.Commons.Utility;

namespace WarhammerApp.API.Entities.Models
{
    public class Statistic
    {
        public Statistic()
        {
            Characters = new List<CharacterStatistic>();
            Professions = new List<ProfessionStatistic>();
        }

        public List<CharacterStatistic> Characters { get; set; }

        [Key]
        public short Id { get; set; }

        public bool IsBasicValue { get; set; }

        public bool IsCalculatedValue { get; set; }

        public bool IsReadOnly { get; set; }

        public List<ProfessionStatistic> Professions { get; set; }

        public StatisticType Type { get; set; }
    }
}