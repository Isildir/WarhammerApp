using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WarhammerProfessionApp.Utility
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
                StatisticType.CloseCombat => statisticType.ToString(), //return localizer.GetString("StatisticsCloseCombat"),
                StatisticType.Shooting => statisticType.ToString(),
                StatisticType.Stamina => statisticType.ToString(),
                StatisticType.Resistance => statisticType.ToString(),
                StatisticType.Agility => statisticType.ToString(),
                StatisticType.Inteligence => statisticType.ToString(),
                StatisticType.Willpower => statisticType.ToString(),
                StatisticType.Polish => statisticType.ToString(),
                StatisticType.Attacks => statisticType.ToString(),
                StatisticType.Hitpoints => statisticType.ToString(),
                StatisticType.Strength => statisticType.ToString(),
                StatisticType.Hardness => statisticType.ToString(),
                StatisticType.Speed => statisticType.ToString(),
                StatisticType.Magic => statisticType.ToString(),
                StatisticType.Insanity => statisticType.ToString(),
                StatisticType.Destiny => statisticType.ToString(),
                _ => string.Empty
            };
    }
}
