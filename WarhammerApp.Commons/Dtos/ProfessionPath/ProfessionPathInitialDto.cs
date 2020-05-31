using System.Collections.Generic;

namespace WarhammerApp.Commons.Dtos
{
    public class ProfessionPathInitialDto : ProfessionPathBaseDto
    {
        public string Name { get; set; }

        public Dictionary<string, byte> Statistics { get; set; }
    }
}