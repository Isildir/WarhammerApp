using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarhammerProfessionApp.Entities.Models
{
    public class User
    {
        public List<Character> Characters { get; set; }

        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Login { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }
    }
}