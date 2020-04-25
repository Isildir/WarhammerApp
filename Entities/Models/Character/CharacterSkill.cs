using System.ComponentModel.DataAnnotations.Schema;
using WarhammerProfessionApp.Entities.Models.ManyToMany;

namespace WarhammerProfessionApp.Entities.Models
{
    public class CharacterSkill
    {
        [ForeignKey(nameof(CharacterId))]
        public Character Character { get; set; }

        public int CharacterId { get; set; }

        [ForeignKey(nameof(DictionaryValueId))]
        public DictionaryValue DictionaryValue { get; set; }

        public int? DictionaryValueId { get; set; }

        [ForeignKey(nameof(ProfessionSkillsId))]
        public ProfessionSkills ProfessionSkills { get; set; }

        public int ProfessionSkillsId { get; set; }

        [ForeignKey(nameof(SkillId))]
        public Skill Skill { get; set; }

        public int SkillId { get; set; }
    }
}