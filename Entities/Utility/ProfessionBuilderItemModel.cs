using WarhammerProfessionApp.Entities.Models.Enums;

namespace WarhammerProfessionApp.Entities.Models.Utility
{
    public class ProfessionBuilderItemModel
    {
        public ProfessionBuilderItemModel(Item item, int? quantity = null, ItemQuality? quality = null)
        {
            Item = item;
            Quantity = quantity ?? 1;
            Quality = quality ?? ItemQuality.Normal;
        }

        public Item Item { get; set; }

        public ItemQuality Quality { get; set; }

        public int Quantity { get; set; }
    }
}