using System.Collections.Generic;

namespace WarhammerProfessionApp.Dtos
{
    public class ProfessionPathBaseDto
    {
        public List<string> AbilitiesToLearn { get; set; }

        public List<string> SkillsToLearn { get; set; }
    }
}