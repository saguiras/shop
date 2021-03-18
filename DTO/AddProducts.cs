using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class AddProducts
    {
        [Required]
        public string Products_name { get; set; }
        [Required]
        public string Products_description { get; set; }
        [Required]
        public decimal Products_price { get; set; }
    }
}