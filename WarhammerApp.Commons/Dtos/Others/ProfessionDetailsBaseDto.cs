using System.Collections.Generic;

namespace WarhammerApp.Commons.Dtos
{
    public abstract class ProfessionDetailsBaseDto
    {
        public byte Agility { get; set; }

        public byte Attacks { get; set; }

        public byte CloseCombat { get; set; }

        public string Description { get; set; }

        public List<ShortProfessionDto> EntranceProfessions { get; set; }

        public byte Hitpoints { get; set; }

        public int Id { get; set; }

        public int? ImageId { get; set; }

        public byte Inteligence { get; set; }

        public byte Magic { get; set; }

        public string Name { get; set; }

        public List<ShortProfessionDto> OutputProfessions { get; set; }

        public byte Polish { get; set; }

        public byte Resistance { get; set; }

        public byte Shooting { get; set; }

        public byte Speed { get; set; }

        public byte Stamina { get; set; }

        public byte Willpower { get; set; }
    }
}