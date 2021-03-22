using System.ComponentModel.DataAnnotations;

namespace shop.Models
{
    public class Customers
    {
        [Key]
        public int Customer_id { get; set; }
        public string Customer_name { get; set; }
    }
}
