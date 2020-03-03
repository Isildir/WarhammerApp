using System.Collections.Generic;
using WarhammerProfessionApp.Entities.Models.Enums;

namespace WarhammerProfessionApp.Dtos
{
    public class ProfessionDetailsDto : ProfessionDetailsBaseDto
    {
        public List<AbilityWrapperDto> Abilities { get; set; }

        public List<ProfessionItemWrapperDto> Equipment { get; set; }

        public ProfessionLevel ProfessionLevel { get; set; }

        public ProfessionRaceAllowed ProfessionRaceAllowed { get; set; }

        public List<SkillWrapperDto> Skills { get; set; }
    }
}