using System.ComponentModel.DataAnnotations.Schema;
using WarhammerProfessionApp.Entities.Models.ManyToMany;

namespace WarhammerProfessionApp.Entities.Models
{
    public class DictionaryValueProfessionAbility
    {
        [ForeignKey(nameof(DictionaryValueId))]
        public DictionaryValue DictionaryValue { get; set; }

        public int DictionaryValueId { get; set; }

        [ForeignKey(nameof(ProfessionAbilityId))]
        public ProfessionAbility ProfessionAbility { get; set; }

        public int ProfessionAbilityId { get; set; }
    }
}