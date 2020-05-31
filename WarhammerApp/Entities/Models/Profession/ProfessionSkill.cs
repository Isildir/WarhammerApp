using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarhammerApp.API.Entities.Models.ManyToMany
{
    public class ProfessionSkill
    {
        public ProfessionSkill()
        {
            AllowedValues = new List<DictionaryValueProfessionSkill>();
        }

        public bool? AllowAllValues { get; set; }

        public List<DictionaryValueProfessionSkill> AllowedValues { get; set; }

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(ProfessionSkillsId))]
        public virtual ProfessionSkills ProfessionSkills { get; set; }

        public int ProfessionSkillsId { get; set; }

        [ForeignKey(nameof(SkillId))]
        public virtual Skill Skill { get; set; }

        public int SkillId { get; set; }
    }
}