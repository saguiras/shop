using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace shop.DTO
{
    public class ProductsDTO
    {
        [Required]
        public string Product_name { get; set; }
        [Required]
        public int Product_id { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public bool Sell { get; set; }
    }
}