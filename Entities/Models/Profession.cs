using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarhammerProfessionApp.Entities.Models.Enums;
using WarhammerProfessionApp.Entities.Models.ManyToMany;

namespace WarhammerProfessionApp.Entities.Models
{
    public class Profession
    {
        public Profession()
        {
            Skills = new List<ProfessionSkills>();
            Abilities = new List<ProfessionAbilities>();
            Equipment = new List<ProfessionItems>();
            EntranceProfessions = new List<ProfessionProfession>();
            OutputProfessions = new List<ProfessionProfession>();
            Characters = new List<CharacterProfession>();
        }

        public virtual List<ProfessionAbilities> Abilities { get; set; }

        [StringLength(150)]
        public string AdditionalInformations { get; set; }

        public byte Agility { get; set; }

        public byte Attacks { get; set; }

        public List<CharacterProfession> Characters { get; set; }

        public byte CloseCombat { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public virtual List<ProfessionProfession> EntranceProfessions { get; set; }

        public virtual List<ProfessionItems> Equipment { get; set; }

        public byte Hitpoints { get; set; }

        [Key]
        public int Id { get; set; }

        public virtual Image Image { get; set; }

        public int? ImageId { get; set; }

        public byte Inteligence { get; set; }

        public byte Magic { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public virtual List<ProfessionProfession> OutputProfessions { get; set; }

        public byte Polish { get; set; }

        public ProfessionLevel ProfessionLevel { get; set; }

        public Race ProfessionRaceAllowed { get; set; }

        public byte Resistance { get; set; }

        public byte Shooting { get; set; }

        public virtual List<ProfessionSkills> Skills { get; set; }

        public byte Speed { get; set; }

        public byte Stamina { get; set; }

        public byte Willpower { get; set; }
    }
}