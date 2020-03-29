namespace WarhammerProfessionApp.Entities.Models
{
    public class CharacterAbility
    {
        public Ability Ability { get; set; }

        public int AbilityId { get; set; }

        public Character Character { get; set; }

        public int CharacterId { get; set; }
    }
}