using Microsoft.AspNetCore.Mvc;
using Panchito.Store.Application.Dtos;
using Panchito.Store.Application.Interfaces;

namespace Panchito.Store.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductApplication _productApplication;

        public ProductsController(IProductApplication productApplication)
        {
            _productApplication = productApplication;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProductDto>>> GetProducts()
        {
            var products = await _productApplication.GetProductsAsync();
            return products;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<ProductDto>> GetProductById(int id)
        {
            var product = await _productApplication.GetProductByIdAsync(id);
            return product;
        }
    }
}
