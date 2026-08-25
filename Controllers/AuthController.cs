
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebWomen.Data;
using WebWomen.Models;

namespace WebWomen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly AppDbContext _context;

        public AuthController(AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("login")]
        public async Task<ActionResult<User>> Login([FromBody] User loginDto)
        {
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Username == loginDto.Username);

            if (user == null)
            {
                return NotFound(new { Message = "User not found." });
            }

            // Simple password check (Note: Use hashed password comparison in production)
            if (user.Password != loginDto.Password)
            {
                return Unauthorized(new { Message = "Invalid credentials." });
            }

            return Ok(user);
        }
    }
}
