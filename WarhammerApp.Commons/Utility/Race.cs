using System;

namespace WarhammerProfession.Commons.Utility
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