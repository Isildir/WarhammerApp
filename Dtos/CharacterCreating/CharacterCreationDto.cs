using System.Collections.Generic;
using WarhammerProfessionApp.Entities.Models.Enums;

namespace WarhammerProfessionApp.Controllers
{
    public class CharacterCreationDto
    {
        public CharacterCreationDto()
        {
            SkillsSet = new List<CharacterCreationValueDto>();
            SkillsChoice = new List<CharacterCreationValueGroupDto>();
            AbilitiesSet = new List<CharacterCreationValueDto>();
            AbilitiesChoice = new List<CharacterCreationValueGroupDto>();
        }

        public List<CharacterCreationValueGroupDto> AbilitiesChoice { get; set; }

        public List<CharacterCreationValueDto> AbilitiesSet { get; set; }

        public Race Race { get; set; }

        public string RaceName => Race.ToString();

        public List<CharacterCreationValueGroupDto> SkillsChoice { get; set; }

        public List<CharacterCreationValueDto> SkillsSet { get; set; }

        public List<CharacterCreateStatisticDto> Statistics { get; set; }
    }
}