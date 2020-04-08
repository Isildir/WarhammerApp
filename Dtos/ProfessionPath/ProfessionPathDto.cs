using System.Collections.Generic;

namespace WarhammerProfessionApp.Dtos
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