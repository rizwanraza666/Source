namespace PurchaseSystem.Models
{
    public class Purchase
    {
        [key]
        public int id { get; set; }
        public string? pur_item { get; set; }
        public int Qty { get; set; }
        public DateTime pur_date { get; set; }
        public int price { get; set; }
        public string? vendor { get; set; }



    }
}
