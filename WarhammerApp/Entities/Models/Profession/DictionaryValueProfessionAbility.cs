using System.ComponentModel.DataAnnotations.Schema;
using WarhammerApp.API.Entities.Models.ManyToMany;

namespace WarhammerApp.API.Entities.Models
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