using System.Collections.Generic;

namespace WarhammerApp.Commons.Dtos
{
    public class SkillWrapperDto
    {
        public byte Quantity { get; set; }

        public List<SkillDto> Skills { get; set; }
    }
}