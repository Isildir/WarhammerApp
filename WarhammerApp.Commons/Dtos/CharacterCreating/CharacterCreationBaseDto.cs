using System.Collections.Generic;

namespace WarhammerApp.Commons.Dtos
{
    public abstract class CharacterCreationBaseDto
    {
        public CharacterCreationBaseDto()
        {
            SkillsSet = new List<CharacterCreationValueDto>();
            SkillsChoice = new List<CharacterCreationValueGroupDto>();
            AbilitiesSet = new List<CharacterCreationValueDto>();
            AbilitiesChoice = new List<CharacterCreationValueGroupDto>();
        }

        public List<CharacterCreationValueGroupDto> AbilitiesChoice { get; set; }

        public List<CharacterCreationValueDto> AbilitiesSet { get; set; }

        public List<CharacterCreationValueGroupDto> SkillsChoice { get; set; }

        public List<CharacterCreationValueDto> SkillsSet { get; set; }
    }
}