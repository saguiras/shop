using DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly Context _context;

        public OrdersController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<OrdersDTO>> GetOrders()
        {
            var order = from orders in _context.Orders
            join customers in _context.Customers on orders.Customer_id equals customers.Customer_id
            join products in _context.Products on orders.Product_id equals products.Product_id
            select new OrdersDTO
            {
                Customer_id = orders.Customer_id,
                Customer_name = customers.Customer_name,
                Product_id = orders.Product_id,
                Price = products.Price,
                Order_date = orders.Order_date,
                Product_name = products.Product_name,
                Order_id = orders.Order_id

            };
            var getOrders = order.ToList();

            if (getOrders == null)
                return NotFound();
            return getOrders;

        }

        [HttpGet("{id}")]
        public ActionResult<OrdersDTO> GetOrders_byId(int id)
        {
            var order = from orders in _context.Orders
            join customers in _context.Customers on orders.Customer_id equals customers.Customer_id
            join products in _context.Products on orders.Product_id equals products.Product_id
            select new OrdersDTO
            {
                Customer_id = orders.Customer_id,
                Customer_name = customers.Customer_name,
                Product_id = orders.Product_id,
                Price = products.Price,
                Order_date = orders.Order_date,
                Product_name = products.Product_name,
                Order_id = orders.Order_id

            };
            var getOrders_byId = order.ToList().Find(x => x.Order_id == id);

            if (getOrders_byId == null)
                return NotFound();
            return getOrders_byId;
        }

    }
}