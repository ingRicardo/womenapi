
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebWomen.Data;
using WebWomen.Models;

namespace WebWomen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WomenController : ControllerBase
    {
        private readonly AppDbContext _context;

        public WomenController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Women
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Woman>>> GetWomen()
        {
            return await _context.Women.ToListAsync();
        }

        // GET: api/Women/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Woman>> GetWoman(int id)
        {
            var woman = await _context.Women.FindAsync(id);

            if (woman == null)
            {
                return NotFound(new { Message = $"Woman with ID {id} was not found." });
            }

            return woman;
        }

        // POST: api/Women
        [HttpPost]
        public async Task<ActionResult<Woman>> CreateWoman(Woman woman)
        {
            
            _context.Women.Add(woman);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetWoman), new { id = woman.Id }, woman);
        }

        // PUT: api/Women/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateWoman(int id, Woman woman)
        {
            if (id != woman.Id)
            {
                return BadRequest(new { Message = "ID in route parameter does not match payload ID." });
            }

            _context.Entry(woman).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!WomanExists(id))
                {
                    return NotFound(new { Message = $"Woman with ID {id} was not found." });
                }
                throw;
            }

            return NoContent();
        }

        // DELETE: api/Women/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWoman(int id)
        {
            var woman = await _context.Women.FindAsync(id);
            if (woman == null)
            {
                return NotFound(new { Message = $"Woman with ID {id} was not found." });
            }

            _context.Women.Remove(woman);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool WomanExists(int id)
        {
            return _context.Women.Any(e => e.Id == id);
        }
    }
}
