using System.ComponentModel.DataAnnotations.Schema;

namespace WarhammerProfessionApp.Entities.Models.ManyToMany
{
    public class ProfessionSkill
    {
        [ForeignKey(nameof(ProfessionSkillsId))]
        public virtual ProfessionSkills ProfessionSkills { get; set; }

        public int ProfessionSkillsId { get; set; }

        [ForeignKey(nameof(SkillId))]
        public virtual Skill Skill { get; set; }

        public int SkillId { get; set; }
    }
}