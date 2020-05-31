using System.Collections.Generic;

namespace WarhammerApp.Commons.Dtos
{
    public class ProfessionItemWrapperDto
    {
        public List<ProfessionItemDto> Items { get; set; }

        public byte Quantity { get; set; }
    }
}