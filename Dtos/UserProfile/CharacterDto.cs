using System.Collections.Generic;

namespace WarhammerProfessionApp.Dtos
{
    public class CharacterDto
    {
        public CharacterDto()
        {
            Professions = new List<ShortProfessionDto>();
            CharacterStatistics = new List<CharacterStatisticDto>();
            AdditionalExcerienceCostValues = new List<AdditionalCharacterDto>();
            AdditionalValues = new List<AdditionalCharacterDto>();
            CharacterSkills = new List<SkillDto>();
            CharacterAbilities = new List<AbilityDto>();
            CharacterItems = new List<ItemDto>();
        }

        public string Name { get; set; }

        public int ExperienceUsed { get; set; }

        public int ExperienceSummary { get; set; }

        public string ActualProfessionName { get; set; }

        public List<ShortProfessionDto> Professions { get; set; }

        public int Gold { get; set; }

        public int Silver { get; set; }

        public int Bronze { get; set; }

        public List<CharacterStatisticDto> CharacterStatistics { get; set; }

        public List<AdditionalCharacterDto> AdditionalExcerienceCostValues { get; set; }

        public List<AdditionalCharacterDto> AdditionalValues { get; set; }

        public List<SkillDto> CharacterSkills { get; set; }

        public List<AbilityDto> CharacterAbilities { get; set; }

        public List<ItemDto> CharacterItems { get; set; }
    }
}