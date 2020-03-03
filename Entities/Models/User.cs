using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarhammerProfessionApp.Entities.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(50)]
        public string Login { get; set; }

        public List<Character> Characters { get; set; }

        [Required]
        public byte[] PasswordHash { get; set; }

        [Required]
        public byte[] PasswordSalt { get; set; }
    }
}