using System.Collections.Generic;

namespace WarhammerProfessionApp.Dtos
{
    public struct StatisticCompare
    {
        public StatisticCompare(byte originalValue, byte newValue)
        {
            OriginalValue = originalValue;
            NewValue = newValue;
        }

        public byte NewValue { get; set; }

        public byte OriginalValue { get; set; }
    }

    public class ProfessionItemDto
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }
    }

    public class ProfessionItemWrapperDto
    {
        public List<ProfessionItemDto> Items { get; set; }

        public byte Quantity { get; set; }
    }

    public class ProfessionPathBaseDto
    {
        public List<string> AbilitiesToLearn { get; set; }

        public List<string> SkillsToLearn { get; set; }
    }

    public class ProfessionPathDto
    {
        public ProfessionPathDto()
        {
            Steps = new List<ProfessionPathStepDto>();
        }

        public List<ProfessionPathStepDto> Steps { get; set; }

        public ProfessionPathSummaryDto Summary { get; set; }
    }

    public abstract class ProfessionPathExtendedDto : ProfessionPathBaseDto
    {
        public int MaximumExperienceCost { get; set; }

        public int MinimalExperienceCost { get; set; }

        public Dictionary<string, StatisticCompare> Statistics { get; set; }
    }

    public class ProfessionPathInitialDto : ProfessionPathBaseDto
    {
        public string Name { get; set; }

        public Dictionary<string, byte> Statistics { get; set; }
    }

    public class ProfessionPathStepDto : ProfessionPathExtendedDto
    {
        public string Name { get; set; }
    }

    public class ProfessionPathSummaryDto : ProfessionPathExtendedDto
    {
        public string Path { get; set; }
    }

    public class ProfessionPathWrapperDto
    {
        public ProfessionPathWrapperDto()
        {
            Paths = new List<ProfessionPathDto>();
        }

        public ProfessionPathInitialDto InitialValues { get; set; }

        public List<ProfessionPathDto> Paths { get; set; }
    }
}