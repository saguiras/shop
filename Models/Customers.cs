using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Customers
    {
        [Key]
        public int Id { get; set; }
        public string Orders { get; set; }
    }
}
