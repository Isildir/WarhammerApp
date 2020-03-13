using System.Collections.Generic;

namespace WarhammerProfessionApp.Dtos
{
    public class CharacterDto
    {
        public CharacterDto()
        {
            Professions = new List<ShortProfessionDto>();
            BasicStatistics = new List<CharacterStatisticDto>();
            AdvancedStatistics = new List<CharacterStatisticDto>();
            AdditionalExcerienceCostValues = new List<AdditionalCharacterValueDto>();
            AdditionalValues = new List<AdditionalCharacterValueDto>();
            Skills = new List<SkillDto>();
            Abilities = new List<AbilityDto>();
            Items = new List<CharacterItemDto>();
        }

        public string Name { get; set; }

        public int ExperienceLeft { get; set; }

        public int ExperienceSum { get; set; }

        public string ActualProfessionName { get; set; }

        public List<ShortProfessionDto> Professions { get; set; }

        public MoneyDto Money { get; set; }

        public List<CharacterStatisticDto> BasicStatistics { get; set; }

        public List<CharacterStatisticDto> AdvancedStatistics { get; set; }

        public List<AdditionalCharacterValueDto> AdditionalExcerienceCostValues { get; set; }

        public List<AdditionalCharacterValueDto> AdditionalValues { get; set; }

        public List<SkillDto> Skills { get; set; }

        public List<AbilityDto> Abilities { get; set; }

        public List<CharacterItemDto> Items { get; set; }
    }
}