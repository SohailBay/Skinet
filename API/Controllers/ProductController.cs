using System.Linq;
using Infrastructure.Data;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly StoreContext _context;
        public ProductController(StoreContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("GetProducts")]
        public async Task<ActionResult<List<Products>>> GetProducts()
        {
            var products = await _context.MyProperty.ToListAsync();
            return Ok(products);
        }

        [HttpGet]
        [Route("GetProduct")]
        public async Task<ActionResult<Products>> GetProduct(int Id)
        {
            return await _context.MyProperty.FindAsync(Id);
        }
    }
}