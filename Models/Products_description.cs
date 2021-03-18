using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Products_description
    {
        [Key]
        public int id { get; set; }
        public int products_id { get; set; }
        public string products_name { get; set; }
        public string products_description { get; set; }
    }
}
