using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shop.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Models;
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
        public async Task<ActionResult<IEnumerable<ProductsDTO>>> GetProducts()
        {
            var products = from Products in _context.Products
                           join Products_descriptions in _context.Products_Description on Products.id equals Products_descriptions.products_id
                           select new ProductsDTO
                           {
                               Products_id = Products.id,
                               Products_price = Products.price,
                               Products_name = Products_descriptions.products_name,
                               Products_description = Products_descriptions.products_description
                           };

            return await products.ToListAsync();
        }

        [HttpGet("{id}")]
        public ActionResult<ProductsDTO> GetProducts_byId(int id)
        {
            var products = from Products in _context.Products
                           join Products_descriptions in _context.Products_Description on Products.id equals Products_descriptions.products_id
                           select new ProductsDTO
                           {
                               Products_id = Products.id,
                               Products_price = Products.price,
                               Products_name = Products_descriptions.products_name,
                               Products_description = Products_descriptions.products_description
                           };

            var products_by_id = products.ToList().Find(x => x.Products_id == id);

            if (products_by_id == null)
            {
                return NotFound();
            }
            return products_by_id;
        }


        [HttpPost]
        public async Task<ActionResult<AddProducts>> Add_Products(AddProducts ProductsDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var products = new Products()
            {
                price = ProductsDTO.Products_price
            };
            await _context.Products.AddAsync(products);
            await _context.SaveChangesAsync();

            var products_description = new Products_description()
            {
                products_id = products.id,
                products_name = ProductsDTO.Products_name,
                products_description = ProductsDTO.Products_description
            };
            await _context.AddAsync(products_description);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProducts", new { id = products.id }, ProductsDTO);
        }

    }

}