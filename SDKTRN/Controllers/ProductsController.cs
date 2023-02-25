using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SDKTRN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private static readonly string[] Products =
        {
            "samsung s6",
            "samsung s7",
            "samsung s8",
        };


        [HttpGet]
        public string[] GetProducts()
        {
            return Products;
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            if (Products.Length - 1 < id)
                return "there is not value like that";
            return Products[id];
        }
    }
}
