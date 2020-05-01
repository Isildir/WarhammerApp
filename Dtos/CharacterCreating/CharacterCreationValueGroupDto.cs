using System.Collections.Generic;

namespace WarhammerProfessionApp.Controllers
{
    public class CharacterCreationValueGroupDto
    {
        public byte Quantity { get; set; } = 1;

        public List<CharacterCreationValueDto> Values { get; set; }
    }
}