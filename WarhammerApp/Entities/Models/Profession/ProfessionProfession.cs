using System.ComponentModel.DataAnnotations.Schema;

namespace WarhammerApp.API.Entities.Models.ManyToMany
{
    public class ProfessionProfession
    {
        [ForeignKey(nameof(EntranceProfessionId))]
        public virtual Profession EntranceProfession { get; set; }

        public int EntranceProfessionId { get; set; }

        [ForeignKey(nameof(OutputProfessionId))]
        public virtual Profession OutputProfession { get; set; }

        public int OutputProfessionId { get; set; }
    }
}