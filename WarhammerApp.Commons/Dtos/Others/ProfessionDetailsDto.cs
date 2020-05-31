using System.Collections.Generic;
using WarhammerProfession.Commons.Utility;

namespace WarhammerApp.Commons.Dtos
{
    public class ProfessionDetailsDto : ProfessionDetailsBaseDto
    {
        public List<AbilityWrapperDto> Abilities { get; set; }

        public List<ProfessionItemWrapperDto> Equipment { get; set; }

        public string ProfessionLevel { get; set; }

        public Race ProfessionRaceAllowed { get; set; }

        public List<SkillWrapperDto> Skills { get; set; }
    }
}