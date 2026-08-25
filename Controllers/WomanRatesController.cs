
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebWomen.Data;
using WebWomen.Models;


namespace WebWomen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WomanRatesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public WomanRatesController(AppDbContext context)
        {
            _context = context;
        }

        // POST: api/WomanRates
        // Submit a new rating
        [HttpPost]
        public async Task<IActionResult> AddRate([FromBody] CreateRateDto dto)
        {
            var womanExists = await _context.Women.AnyAsync(w => w.Id == dto.WomanId);
            if (!womanExists)
            {
                return NotFound(new { Message = $"Woman with ID {dto.WomanId} does not exist." });
            }

            var newRate = new WomanRate
            {
                WomanId = dto.WomanId,
                Rate = dto.Rate,
                CreatedAt = DateTime.UtcNow
            };

            _context.WomanRates.Add(newRate);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAverageRateForWoman), new { womanId = dto.WomanId }, newRate);
        }

        // GET: api/WomanRates/average/5
        // Get average rating for a single woman by ID
        [HttpGet("average/{womanId}")]
        public async Task<ActionResult<WomanRatingSummaryDto>> GetAverageRateForWoman(int womanId)
        {
            var woman = await _context.Women.FindAsync(womanId);
            if (woman == null)
            {
                return NotFound(new { Message = $"Woman with ID {womanId} was not found." });
            }

            var ratings = _context.WomanRates.Where(r => r.WomanId == womanId);

            var totalCount = await ratings.CountAsync();
            var average = totalCount > 0 ? await ratings.AverageAsync(r => r.Rate) : 0.0;

            return new WomanRatingSummaryDto
            {
                WomanId = woman.Id,
                Name = woman.Name,
                AverageRate = Math.Round(average, 2),
                TotalRatings = totalCount
            };
        }

        // GET: api/WomanRates/averages
        // Get average ratings for ALL women
        [HttpGet("averages")]
        public async Task<ActionResult<IEnumerable<WomanRatingSummaryDto>>> GetAllAverageRates()
        {
            var summary = await _context.Women
                .Select(w => new WomanRatingSummaryDto
                {
                    WomanId = w.Id,
                    Name = w.Name,
                    TotalRatings = _context.WomanRates.Count(r => r.WomanId == w.Id),
                    AverageRate = _context.WomanRates.Where(r => r.WomanId == w.Id).Any()
                        ? Math.Round(_context.WomanRates.Where(r => r.WomanId == w.Id).Average(r => r.Rate), 2)
                        : 0.0
                })
                .ToListAsync();

            return Ok(summary);
        }
    }
}
