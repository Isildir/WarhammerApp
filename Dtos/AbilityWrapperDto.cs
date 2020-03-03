using System.Collections.Generic;

namespace WarhammerProfessionApp.Dtos
{
    public class AbilityWrapperDto
    {
        public byte Quantity { get; set; }

        public List<AbilityDto> Abilities { get; set; }
    }
}