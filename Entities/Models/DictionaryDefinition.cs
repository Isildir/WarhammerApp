using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WarhammerProfessionApp.Entities.Models
{
    public class DictionaryDefinition
    {
        public bool CanBeDeleted { get; set; }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Skill> Skills { get; set; }

        public List<DictionaryValue> Values { get; set; }
    }
}