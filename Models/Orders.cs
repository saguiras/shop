using System;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public int Cusumers_id { get; set; }
        public int Products_id { get; set; }
    }
}
