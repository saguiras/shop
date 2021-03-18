using Models;

namespace shop.DTO
{
    public class ProductsDTO : Orders
    {
        public decimal Products_price { get; set; }
        public string Products_name { get; set; }
        public string Products_description { get; set; }
    }
}