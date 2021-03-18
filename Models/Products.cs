using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Products
    {
        [Key]
        public int id { get; set; }
        public decimal price { get; set; }
    }
}
