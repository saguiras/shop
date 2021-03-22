using System;
using shop.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class CustomersDTO
    {
        [Required]
        public List<Orders> customer_orders { get; set; }
        [Required]
        public string customer_name { get; set; }
        [Required]
        public int customer_id { get; set; }
    }
}
