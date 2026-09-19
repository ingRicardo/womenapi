
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebWomen.Data; // Adjust namespace to match your DbContext
using WebWomen.Models;


namespace WebWomen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BillServicesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public BillServicesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/BillServices
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BillService>>> GetBillServices()
        {
            return await _context.BillServices.ToListAsync();
        }

        // GET: api/BillServices/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BillService>> GetBillService(int id)
        {
            var billService = await _context.BillServices.FindAsync(id);

            if (billService == null)
            {
                return NotFound();
            }

            return billService;
        }

        // POST: api/BillServices
        [HttpPost]
        public async Task<ActionResult<BillService>> PostBillService(BillService billService)
        {
            _context.BillServices.Add(billService);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetBillService), new { id = billService.Id }, billService);
        }

        // PUT: api/BillServices/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBillService(int id, BillService billService)
        {
            if (id != billService.Id)
            {
                return BadRequest("ID mismatch.");
            }

            _context.Entry(billService).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BillServiceExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/BillServices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBillService(int id)
        {
            var billService = await _context.BillServices.FindAsync(id);
            if (billService == null)
            {
                return NotFound();
            }

            _context.BillServices.Remove(billService);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool BillServiceExists(int id)
        {
            return _context.BillServices.Any(e => e.Id == id);
        }

        // GET: api/BillServices/search?name=John&email=john@example.com
        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<BillService>>> SearchBillServices(
            [FromQuery] string name,
            [FromQuery] string email)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email))
            {
                return BadRequest("Both 'name' and 'email' parameters are required.");
            }

            var results = await _context.BillServices
                .Where(b => EF.Functions.ILike(b.Name, $"%{name}%") &&
                            EF.Functions.ILike(b.Email!, $"%{email}%"))
                .ToListAsync();

            return Ok(results);
        }


    }

}

