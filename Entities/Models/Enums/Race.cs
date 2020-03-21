using System;

namespace WarhammerProfessionApp.Entities.Models.Enums
{
    [Flags]
    public enum Race : byte
    {
        Human = 1,
        Elf = 2,
        Dwarf = 4,
        Halfing = 8,
    }
}