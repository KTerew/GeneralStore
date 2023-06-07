using GeneralStoreAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GeneralStoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private GeneralStoreDBContext _db;
        public ProductController(GeneralStoreDBContext db) {
            _db = db;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<IActionResult> CreateProduct([FromForm]ProductEdit newProduct) {
            Product product = new Product() {
                Name = newProduct.Name,
                Price = newProduct.Price,
                QuantityInStock = newProduct.Quantity,
            };

        _db.Products.Add(product);
        await _db.SaveChangesAsync();
        return Ok("Successfully Created!");
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProducts() {
            var products = await _db.Products.ToListAsync();
            return Ok(products);
        }
    }
}