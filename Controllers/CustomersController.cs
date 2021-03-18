using Microsoft.AspNetCore.Mvc;
using shop.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DTO;

namespace backend_database_HTTP_Requests.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Customers : ControllerBase
    {
        private readonly Context _context;
        public Customers(Context context)
        {
            _context = context;
        }
    }

}
