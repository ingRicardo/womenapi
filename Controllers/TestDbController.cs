
using Microsoft.AspNetCore.Mvc;
using WebWomen.Data;

namespace WebWomen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TestDbController : ControllerBase
    {
        private readonly AppDbContext _context;

        public TestDbController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("check-connection")]
        public async Task<IActionResult> CheckConnection()
        {
            try
            {
                bool canConnect = await _context.Database.CanConnectAsync();
                if (canConnect)
                {
                    return Ok(new { Status = "Success", Message = "Connected to PostgreSQL database 'womendb' successfully." });
                }
                return StatusCode(500, new { Status = "Error", Message = "Cannot connect to the database." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Status = "Error", Details = ex.Message });
            }
        }
    }
}
