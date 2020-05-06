using System.Collections.Generic;
using WarhammerProfessionApp.Entities.Models.Enums;

namespace WarhammerProfessionApp.Controllers
{
    public class CharacterCreationDto : CharacterCreationBaseDto
    {
        public CharacterCreationDto() : base()
        {
            Statistics = new List<CharacterCreateStatisticDto>();
        }

        public Race Race { get; set; }

        public string RaceName => Race.ToString();

        public List<CharacterCreateStatisticDto> Statistics { get; set; }
    }
}