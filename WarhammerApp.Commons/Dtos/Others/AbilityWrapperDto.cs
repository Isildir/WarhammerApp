using System.Collections.Generic;

namespace WarhammerApp.Commons.Dtos
{
    public class AbilityWrapperDto
    {
        public List<AbilityDto> Abilities { get; set; }

        public byte Quantity { get; set; }
    }
}