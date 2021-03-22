using Microsoft.AspNetCore.Mvc;
using shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;
using shop.Models;

namespace shop.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly Context _context;

        public CustomersController(Context context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
        public ActionResult<CustomersDTO> GetCustomer_byId(int id)
        {
            var order = from orders in _context.Orders
            join customers in _context.Customers on id equals customers.Customer_id
            join products in _context.Products on orders.Product_id equals products.Product_id
            select new OrdersDTO
            {
                Customer_id = customers.Customer_id,
                Customer_name = customers.Customer_name,
                Product_id = orders.Product_id,
                Price = products.Price,
                Order_date = orders.Order_date,
                Product_name = products.Product_name,
                Order_id = orders.Order_id
            };

            List<Orders> customer_orders = new List<Orders>();
            foreach (var o in order)
            {
                if (o.Customer_id == id)
                    customer_orders.Add(new Orders(o.Order_id, o.Product_id, o.Customer_id, o.Order_date));
            }

            var customer = from customers in _context.Customers
            where id == customers.Customer_id
            select new CustomersDTO
            {
                customer_orders = customer_orders,
                customer_name = customers.Customer_name,
                customer_id = customers.Customer_id
            };

            var customer_by_id = customer.ToList().Find(x => x.customer_id == id);


            if (customer_by_id == null)
                return NotFound();
            return customer_by_id;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CustomersDTO>> GetCustomers()
        {

            var customer = from customers in _context.Customers
            select new CustomersDTO
            {
                customer_name = customers.Customer_name,
                customer_id = customers.Customer_id
            };

            var getCustomers = customer.ToList();

            if (getCustomers == null)
                return NotFound();
            return getCustomers;

        }



    }
}
