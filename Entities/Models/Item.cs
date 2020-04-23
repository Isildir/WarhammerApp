﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using WarhammerProfessionApp.Entities.Models.Enums;
using WarhammerProfessionApp.Entities.Models.ManyToMany;

namespace WarhammerProfessionApp.Entities.Models
{
    public class Item
    {
        public List<CharacterItem> Characters { get; set; }

        public string Description { get; set; }

        [Key]
        public int Id { get; set; }

        public ItemType ItemType { get; set; }

        [Required, StringLength(50)]
        public string Name { get; set; }

        public int Price { get; set; }

        public List<ProfessionItem> Professions { get; set; }

        public ItemRarity Rarity { get; set; }

        public int Weight { get; set; }
    }
}