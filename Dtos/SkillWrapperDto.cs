using System.Collections.Generic;

namespace WarhammerProfessionApp.Dtos
{
    public class SkillWrapperDto
    {
        public byte Quantity { get; set; }

        public List<SkillDto> Skills { get; set; }
    }
}