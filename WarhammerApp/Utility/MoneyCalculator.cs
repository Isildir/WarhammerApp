using WarhammerApp.Commons.Dtos;

namespace WarhammerApp.API.Utility
{
    public static class MoneyCalculator
    {
        internal static readonly int goldValue = 20 * 12;

        internal static readonly int silverValue = 12;

        internal static MoneyDto ConvertMoney(int value)
        {
            var gold = value / goldValue;
            value -= gold * goldValue;

            var silver = value / silverValue;
            value -= silver * silverValue;

            var bronze = value;

            return new MoneyDto
            {
                Gold = gold,
                Silver = silver,
                Bronze = bronze
            };
        }

        internal static int GetUserMoney(int gold, int silver, int bronze) => gold * goldValue + silver * silverValue + bronze;
    }
}