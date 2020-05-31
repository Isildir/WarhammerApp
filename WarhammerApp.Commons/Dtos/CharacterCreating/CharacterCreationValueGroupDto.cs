using System.Collections.Generic;

namespace WarhammerApp.Commons.Dtos
{
    public class CharacterCreationValueGroupDto
    {
        public CharacterCreationValueGroupDto()
        {
            Values = new List<CharacterCreationValueDto>();
        }

        public byte Quantity { get; set; } = 1;

        public List<CharacterCreationValueDto> Values { get; set; }
    }
}