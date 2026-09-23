using BusinessLayer.Interface;
using Microsoft.AspNetCore.Mvc;
using ModelLayer;

namespace WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductController: ControllerBase
    {
        private IProductBL _productBL;
        public ProductController(IProductBL productBL)
        {
            this._productBL = productBL;
        }
        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            var product = _productBL.GetProductById(id);
            if(product is null)
            {
                return NotFound();
            }

            ResponseModel<Product> response = new ResponseModel<Product>
            {
                Success = true,
                Message = "Product retrieved successfully",
                Data = product
            };

            return Ok(response);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            _productBL.AddProduct(product);
            ResponseModel<Product> response = new ResponseModel<Product>
            {
                Success = true,
                Message = "Product retrieved successfully",
                Data = product
            };
            return Ok(response);
        }
    }
}

