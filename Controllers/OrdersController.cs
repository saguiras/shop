using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        private readonly Context _context;

        public OrdersController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrdersController>>> GetOrdersProducts()
        {
            return await _context.Orders.ToListAsync();
        }
    }
}
