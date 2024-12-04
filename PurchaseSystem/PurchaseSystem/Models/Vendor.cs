using System.ComponentModel.DataAnnotations;

namespace PurchaseSystem.Models
{
    public class Vendor
    {
        [Key]
        public int Id { get; set; }
        public string? vendor_name { get; set; }
    }
}
