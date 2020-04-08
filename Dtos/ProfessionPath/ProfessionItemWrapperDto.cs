using System.Collections.Generic;

namespace WarhammerProfessionApp.Dtos
{
    public class ProfessionItemWrapperDto
    {
        public List<ProfessionItemDto> Items { get; set; }

        public byte Quantity { get; set; }
    }
}