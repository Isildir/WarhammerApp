using System.ComponentModel.DataAnnotations.Schema;

namespace WarhammerProfessionApp.Entities.Models.ManyToMany
{
    public class ProfessionAbility
    {
        [ForeignKey(nameof(AbilityId))]
        public virtual Ability Ability { get; set; }

        public int AbilityId { get; set; }

        [ForeignKey(nameof(ProfessionAbilitiesId))]
        public virtual ProfessionAbilities ProfessionAbilities { get; set; }

        public int ProfessionAbilitiesId { get; set; }
    }
}