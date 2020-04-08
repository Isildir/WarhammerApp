namespace WarhammerProfessionApp.Dtos
{
    public struct StatisticCompare
    {
        public StatisticCompare(byte originalValue, byte newValue)
        {
            OriginalValue = originalValue;
            NewValue = newValue;
        }

        public byte NewValue { get; set; }

        public byte OriginalValue { get; set; }
    }
}