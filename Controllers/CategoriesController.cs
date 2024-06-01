using ItemsApi.Data;
using ItemsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItemsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly itemsContext _context;
        public CategoriesController(itemsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Categories>>> GetCategories()
        {
            if(_context.Categories == null)
            {
                return NotFound();
            }
            return await _context.Categories.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult> PostCategories(Categories categories)
        {
            if(categories == null)
            {
                return NotFound();
            }
            _context.Categories.Add(categories);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetCategories", new { id = categories.CategoryID }, categories);
        }
    }
}
