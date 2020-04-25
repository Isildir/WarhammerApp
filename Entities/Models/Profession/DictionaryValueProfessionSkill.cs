using System.ComponentModel.DataAnnotations.Schema;
using WarhammerProfessionApp.Entities.Models.ManyToMany;

namespace WarhammerProfessionApp.Entities.Models
{
    public class DictionaryValueProfessionSkill
    {
        [ForeignKey(nameof(DictionaryValueId))]
        public DictionaryValue DictionaryValue { get; set; }

        public int DictionaryValueId { get; set; }

        [ForeignKey(nameof(ProfessionSkillId))]
        public ProfessionSkill ProfessionSkill { get; set; }

        public int ProfessionSkillId { get; set; }
    }
}