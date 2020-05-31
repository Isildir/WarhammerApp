using System.ComponentModel.DataAnnotations.Schema;
using WarhammerApp.API.Entities.Models.ManyToMany;

namespace WarhammerApp.API.Entities.Models
{
    public class CharacterAbility
    {
        [ForeignKey(nameof(AbilityId))]
        public Ability Ability { get; set; }

        public int AbilityId { get; set; }

        [ForeignKey(nameof(CharacterId))]
        public Character Character { get; set; }

        public int CharacterId { get; set; }

        [ForeignKey(nameof(DictionaryValueId))]
        public DictionaryValue DictionaryValue { get; set; }

        public int? DictionaryValueId { get; set; }

        public bool IsAdditionalValue { get; set; }

        [ForeignKey(nameof(ProfessionAbilitiesId))]
        public ProfessionAbilities ProfessionAbilities { get; set; }

        public int? ProfessionAbilitiesId { get; set; }
    }
}