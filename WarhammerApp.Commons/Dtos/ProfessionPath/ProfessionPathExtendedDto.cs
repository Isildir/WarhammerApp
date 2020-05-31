using System.Collections.Generic;
using WarhammerProfession.Commons.Utility;

namespace WarhammerApp.Commons.Dtos
{
    public abstract class ProfessionPathExtendedDto : ProfessionPathBaseDto
    {
        public int MaximumExperienceCost { get; set; }

        public int MinimalExperienceCost { get; set; }

        public Dictionary<StatisticType, StatisticCompare> Statistics { get; set; }
    }
}