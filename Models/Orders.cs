using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace shop.Models
{
    public class Orders
    {
        [Key]
        public int Order_id { get; set; }
        public int Product_id { get; set; }
        public int Customer_id { get; set; }
        public DateTime Order_date { get; set; }

        public Orders(int _Order_id, int _Product_id, int _Customer_id, DateTime _Order_date)
        {
            Order_id = _Order_id;
            Product_id = _Product_id;
            Customer_id = _Customer_id;
            Order_date = _Order_date;
        }

    }
}
