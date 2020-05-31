using System;

namespace WarhammerApp.Commons.Dtos
{
    public class CharacterInListDto
    {
        public int Id { get; set; }

        public DateTime LastLoginDate { get; set; }

        public string Name { get; set; }

        public string Race { get; set; }
    }
}