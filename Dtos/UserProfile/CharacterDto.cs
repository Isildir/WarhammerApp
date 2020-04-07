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
            AdditionalValues = new List<AdditionalCharacterValueDto>();
            AdditionalItems = new List<CharacterItemDto>();
            Skills = new List<CharacterSkillDto>();
            Abilities = new List<AbilityDto>();
            Items = new List<CharacterItemDto>();
        }

        public List<AbilityDto> Abilities { get; set; }

        public List<CharacterItemDto> AdditionalItems { get; set; }

        public List<AdditionalCharacterValueDto> AdditionalValues { get; set; }

        public List<CharacterStatisticDto> AdvancedStatistics { get; set; }

        public List<CharacterStatisticDto> BasicStatistics { get; set; }

        public CharacterBasicValuesDto BasicValues { get; set; }

        public List<CharacterItemDto> Items { get; set; }

        public MoneyDto Money { get; set; }

        public List<ShortProfessionDto> Professions { get; set; }

        public List<CharacterSkillDto> Skills { get; set; }
    }
}