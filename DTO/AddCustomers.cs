using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class AddCustomers
    {
        [Required]
        public string Customers_name { get; set; }
        [Required]
        public string Customers_description { get; set; }
        [Required]
        public decimal Customers_price { get; set; }
        [Required]
        public string ISBN { get; set; }
    }
}
