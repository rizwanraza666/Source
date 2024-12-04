namespace PurchaseSystem.Models
{
    public class Issuance
    {
        [key]
        public int id { get; set; }
        public DateTime iss_date { get; set; }
        public string? emp_name { get; set; }
        public int Qty { get; set; }

    }
}
