using System.Collections.Generic;

namespace WarhammerApp.Commons.Dtos
{
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