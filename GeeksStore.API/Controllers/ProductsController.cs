using GeeksStore.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace GeeksStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly AdventureWorks2017Context _context;
        public ProductsController(AdventureWorks2017Context Context)
        {
            this._context = Context;
        }

        [HttpGet("GetAllProducts")]
        public List<Product> GetAllProducts()
        {            
            return _context.Products.ToList();   
        }
    }
}
