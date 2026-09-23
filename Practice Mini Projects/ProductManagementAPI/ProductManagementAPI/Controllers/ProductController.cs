using BusniessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;

namespace ProductManagementAPI.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class ProductController : ControllerBase
    {
        private IProductBL _productBL;
        public ProductController(IProductBL productBL)
        {
            _productBL = productBL;
        }


        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productBL.AddProduct(product);
            return Ok(product);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product=_productBL.GetProductById(id);
            if (product is null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet]
        public IActionResult GetAllProducts()
        {
            List<Product> products= _productBL.GetAllProducts();
            if (products is null)
            {
                return NotFound();
            }
            return Ok(products);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, Product product)
        {
            var updatedProduct=_productBL.UpdateProduct(id, product);
            if(updatedProduct is null)
            {
                return NotFound();
            }
            return Ok(updatedProduct);
        }

        [HttpDelete("id/{id}")]
        public IActionResult DeleteProduct(int id)
        {
            var deleted = _productBL.DeleteProduct(id);

            if (!deleted)
            {
                return NotFound();
            }

            return Ok("Product Deleted!");
        }
        [HttpGet("category/{category}")]
        public IActionResult SearchProductByCategory(string category)
        {
           List<Product> products=_productBL.SearchProductByCategory(category);
           if(products is null)
           {
                return NotFound();
           }
            return Ok(products);
        }

        // Validate Product
    }
}
