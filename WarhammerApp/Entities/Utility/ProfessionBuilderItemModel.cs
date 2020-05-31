namespace WarhammerApp.API.Entities.Models.Utility
{
    public class ProfessionBuilderItemModel
    {
        public ProfessionBuilderItemModel(Item item, int? quantity = null)
        {
            Item = item;
            Quantity = quantity ?? 1;
        }

        public Item Item { get; set; }

        public int Quantity { get; set; }
    }
}