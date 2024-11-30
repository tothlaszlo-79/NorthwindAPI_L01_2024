using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindAPI_L01.Data;
using NorthwindAPI_L01.Domain;

namespace NorthwindAPI_L01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly NorthwindContext _context;

        public CategoryController(NorthwindContext context)
        {
            _context = context;
        }

        //[HttpGet]
        //public IEnumerable<Category> GetCategories() { 
        //    return _context.Categories;
        //}



        //[HttpGet("{id}")]
        //public Category GetCategory(int id) { 
        //    return _context.Categories.FirstOrDefault(c => c.CategoryId == id);
        //}


        [HttpGet]
        public IActionResult Get() {
            var result = _context.Categories;

            if (result == null) { return NotFound(); }

            return Ok(result);
        }


        [HttpGet("{id}")]
        public IActionResult GetbyId(int id)
        {
            var result = _context.Categories.FirstOrDefault(c => c.CategoryId == id);

            if (result == null) { return NotFound(); }

            return Ok(result);
        }

        [HttpGet("count")]
        public int Count() => _context.Categories.Count();

        [HttpGet("{id}/products")]
        public IEnumerable<Product> GetProductByCatId(int id)
        {
            return _context.Products.Where(p => p.CategoryId == id);
        }
    }
}
