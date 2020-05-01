using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarhammerProfessionApp.Entities.Models.Enums;

namespace WarhammerProfessionApp.Entities.Models
{
    public class DictionaryDefinition
    {
        public List<Ability> Abilities { get; set; }

        public bool CanBeDeleted { get; set; }

        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public List<Skill> Skills { get; set; }

        public BuiltInDictionaries? Type { get; set; }

        public List<DictionaryValue> Values { get; set; }
    }
}