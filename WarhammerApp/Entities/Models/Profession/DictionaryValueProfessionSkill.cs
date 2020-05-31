using System.ComponentModel.DataAnnotations.Schema;
using WarhammerApp.API.Entities.Models.ManyToMany;

namespace WarhammerApp.API.Entities.Models
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