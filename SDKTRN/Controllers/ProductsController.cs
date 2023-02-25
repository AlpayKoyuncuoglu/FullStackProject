using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SDKTRN.Data;
using SDKTRN.Models;

namespace SDKTRN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
   
        private readonly SocialContext _context;
        public ProductsController(SocialContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetProducts()
        {
            var products = await _context.Products.ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var p = await _context.Products.FirstOrDefaultAsync(i => i.ProductId == id);
            if (p == null)

            {
                return NotFound();
            }
            else
                return Ok(p);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(Product entity)
        {
            _context.Products.Add(entity);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProduct),new { id=entity.ProductId},entity );
            //return Ok();
        }

    
    }
}