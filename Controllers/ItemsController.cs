using ItemsApi.Data;
using ItemsApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ItemsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly itemsContext _context;

        public ItemsController(itemsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Items>>> GetItems()
        {
            if(_context.Items == null)
            {
                return NotFound();
            }

            return await _context.Items.ToListAsync();
        }

        [HttpGet("ItemsById")]
        public async Task<ActionResult<IEnumerable<Items>>> GetItemsById(int id)
        {
            if(_context.Items == null)
            {
                return NotFound();
            }
            var items = await _context.Items.FindAsync(id);
            if(items == null)
            {
                return NotFound();
            }
            return Ok(items);

        }

        [HttpPost]
        public async Task<ActionResult> PostItems(Items items)
        {
            if(items == null)
            {
                return NotFound();
            }
            _context.Items.Add(items);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetItems", new {id = items.Id}, items);
        }
    }
}
