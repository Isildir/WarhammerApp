using System.Collections.Generic;

namespace WarhammerProfessionApp.Dtos
{
    public class AbilityWrapperDto
    {
        public List<AbilityDto> Abilities { get; set; }

        public byte Quantity { get; set; }
    }
}