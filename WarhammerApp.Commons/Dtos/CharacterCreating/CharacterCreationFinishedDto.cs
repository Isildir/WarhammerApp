using System.Collections.Generic;
using WarhammerProfession.Commons.Utility;

namespace WarhammerApp.Commons.Dtos
{
    public class CharacterCreationFinishedDto
    {
        public string Name { get; set; }

        public List<CharacterCreationValueDto> ProfessionAbilities { get; set; }

        public int ProfessionId { get; set; }

        public List<CharacterCreationValueDto> ProfessionSkills { get; set; }

        public Race Race { get; set; }

        public List<CharacterCreationValueDto> RaceAbilities { get; set; }

        public List<CharacterCreationValueDto> RaceSkills { get; set; }

        public List<CharacterCreateStatisticDto> Statistics { get; set; }
    }
}