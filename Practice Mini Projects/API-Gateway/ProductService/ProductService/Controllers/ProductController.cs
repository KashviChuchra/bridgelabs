using Microsoft.AspNetCore.Mvc;
using ModelLayer;
using System.Collections.Generic;


namespace ProductService.Controllers
{
    [ApiController]
    [Route("api/products")]
    public class ProductController : ControllerBase
    {

        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = new List<ProductModel>
            {
                new ProductModel { Id = 1, Name = "Laptop", Price = 50000 },
                new ProductModel { Id = 2, Name = "Mouse", Price = 1000 },
                new ProductModel { Id = 3, Name = "Keyboard", Price = 2000 }
            };
            return Ok(products);

        }
    }
}
