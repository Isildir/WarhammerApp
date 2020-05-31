using System.Collections.Generic;

namespace WarhammerApp.Commons.Dtos
{
    public class ProfessionPathDto
    {
        public ProfessionPathDto()
        {
            Steps = new List<ProfessionPathStepDto>();
        }

        public List<ProfessionPathStepDto> Steps { get; set; }

        public ProfessionPathSummaryDto Summary { get; set; }
    }
}