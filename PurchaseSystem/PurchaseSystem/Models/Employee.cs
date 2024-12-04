using System.ComponentModel.DataAnnotations;

namespace PurchaseSystem.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        public string? emp_name { get; set; }

    }
}
