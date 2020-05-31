using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarhammerApp.API.Entities.Models
{
    public class Image
    {
        public byte[] Content { get; set; }

        [Key]
        public int Id { get; set; }

        [Required]
        public string MimeType { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public virtual List<Profession> Professions { get; set; }
    }
}