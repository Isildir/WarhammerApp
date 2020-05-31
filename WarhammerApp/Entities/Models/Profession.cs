using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarhammerProfession.Commons.Utility;
using WarhammerApp.API.Entities.Models.Enums;
using WarhammerApp.API.Entities.Models.ManyToMany;

namespace WarhammerApp.API.Entities.Models
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
            Statistics = new List<ProfessionStatistic>();
        }

        public virtual List<ProfessionAbilities> Abilities { get; set; }

        [StringLength(150)]
        public string AdditionalInformations { get; set; }

        public List<CharacterProfession> Characters { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public virtual List<ProfessionProfession> EntranceProfessions { get; set; }

        public virtual List<ProfessionItems> Equipment { get; set; }

        [Key]
        public int Id { get; set; }

        public virtual Image Image { get; set; }

        public int? ImageId { get; set; }

        public bool IsBasicLevel { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public virtual List<ProfessionProfession> OutputProfessions { get; set; }

        public Race ProfessionRaceAllowed { get; set; }

        public virtual List<ProfessionSkills> Skills { get; set; }

        public virtual List<ProfessionStatistic> Statistics { get; set; }
    }
}