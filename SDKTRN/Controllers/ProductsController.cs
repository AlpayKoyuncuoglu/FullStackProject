using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SDKTRN.Models;

namespace SDKTRN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //private static readonly string[] Products =
        //{
        //    "samsung s6",
        //    "samsung s7",
        //    "samsung s8",
        //};

        private static List<Product> _products;

        public ProductsController()
        {
            _products = new List<Product>();
            _products.Add(new Product() { ProductId = 1, Name = "Samsung 6", Price = 3000, IsActive = false });
            _products.Add(new Product() { ProductId = 2, Name = "Samsung 7", Price = 4000, IsActive = true });
            _products.Add(new Product() { ProductId = 3, Name = "Samsung 8", Price = 5000, IsActive = true });
            _products.Add(new Product() { ProductId = 4, Name = "Samsung 9", Price = 6000, IsActive = false });
            _products.Add(new Product() { ProductId = 5, Name = "Samsung 10", Price = 7000, IsActive = true });
        }

        [HttpGet]
        public List<Product> GetProducts()
        {
            return _products;
        }

        [HttpGet("{id}")]
        public IActionResult GetProduct(int id)
        {
            var p = _products.FirstOrDefault(i => i.ProductId == id);
            if (p == null)

            {
                return NotFound();
            }
            else
                return Ok(p);
        }
    }
}