using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WarhammerApp.API.Entities.Models.ManyToMany
{
    public class ProfessionSkills
    {
        public ProfessionSkills()
        {
            Skills = new List<ProfessionSkill>();
            Characters = new List<CharacterSkill>();
        }

        public virtual List<CharacterSkill> Characters { get; set; }

        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(ProfessionId))]
        public virtual Profession Profession { get; set; }

        public int ProfessionId { get; set; }

        public virtual List<ProfessionSkill> Skills { get; set; }
    }
}