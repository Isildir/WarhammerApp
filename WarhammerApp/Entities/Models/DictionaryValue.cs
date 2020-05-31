using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarhammerApp.API.Entities.Models.Enums;

namespace WarhammerApp.API.Entities.Models
{
    public class DictionaryValue
    {
        public List<DictionaryValueProfessionAbility> Abilities { get; set; }

        public bool CanBeDeleted { get; set; }

        public List<CharacterAbility> CharacterAbilities { get; set; }

        public List<CharacterSkill> CharacterSkills { get; set; }

        public DictionaryDefinition Definition { get; set; }

        public int DefinitionId { get; set; }

        [Key]
        public int Id { get; set; }

        public List<DictionaryValueProfessionSkill> Skills { get; set; }

        public BuiltInDictionaryValues? Type { get; set; }

        public string Value { get; set; }
    }
}