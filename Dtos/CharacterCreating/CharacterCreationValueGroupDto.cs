using System.Collections.Generic;

namespace WarhammerProfessionApp.Controllers
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