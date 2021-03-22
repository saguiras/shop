using System;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class OrdersDTO
    {
        [Required]
        public int Order_id { get; set; }
        [Required]
        public int Customer_id { get; set; }
        [Required]
        public int Product_id { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public string Product_name { get; set; }
        [Required]
        public string Customer_name { get; set; }
        [Required]
        public DateTime Order_date { get; set; }
    }
}