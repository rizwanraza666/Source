namespace PurchaseSystem.Models
{
    public class Item
    {
        [key]
        public int id { get; set; }
        public string? item_name { get; set; }
        public string? item_status { get; set; }
    }
}
