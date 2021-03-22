using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shop.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using shop.Models;
using DTO;
using shop.DTO;

namespace shop.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly Context _context;

        public ProductsController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<ProductsDTO>> GetProducts()
        {
            var product = from products in _context.Products
            select new ProductsDTO
            {
                Product_name = products.Product_name,
                Product_id = products.Product_id,
                Price = products.Price,
                Sell = products.Sell
            };

            var getProducts = product.ToList();

            if (getProducts == null)
                return NotFound();
            return getProducts;
        }

        [HttpGet("{id}")]
        public ActionResult<ProductsDTO> GetProducts_byId(int id)
        {
            var product = from products in _context.Products
            select new ProductsDTO
            {
                Product_name = products.Product_name,
                Product_id = products.Product_id,
                Price = products.Price,
                Sell = products.Sell
            };

            var getProducts = product.ToList().Find(x => x.Product_id == id);

            if (getProducts == null)
                return NotFound();

            return getProducts;
        }
    }
}