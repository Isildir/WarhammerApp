using WarhammerProfession.Commons.Utility;

namespace WarhammerApp.API.Utility
{
    public static class EnumTranslator
    {
        //IStringLocalizer<SharedResources> localizer;

        //public EnumTranslator(IStringLocalizer<SharedResources> localizer)
        //{
        //    this.localizer = localizer;
        //}

        public static string TranslateStaticticValue(StatisticType statisticType)
            => statisticType switch
            {
                StatisticType.CloseCombat => "Walka wręcz", //return localizer.GetString("StatisticsCloseCombat"),
                StatisticType.Shooting => "Umiejętności strzeleckie",
                StatisticType.Stamina => "Krzepa",
                StatisticType.Resistance => "Odporność",
                StatisticType.Agility => "Zręczność",
                StatisticType.Inteligence => "Inteligencja",
                StatisticType.Willpower => "Siła woli",
                StatisticType.Polish => "Ogłada",
                StatisticType.Attacks => "Ataki",
                StatisticType.Hitpoints => "Punkty życia",
                StatisticType.Strength => "Siła",
                StatisticType.Hardness => "Wytrzymałość",
                StatisticType.Speed => "Szybkość",
                StatisticType.Magic => "Punkty magii",
                StatisticType.Insanity => "Punkty obłędu",
                StatisticType.Destiny => "Punkty przeznaczenia",
                _ => string.Empty
            };
    }
}