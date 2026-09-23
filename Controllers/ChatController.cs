using ChatApi.Services;
using Microsoft.AspNetCore.Mvc;
using WebWomen.Models;

namespace WebWomen.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ChatController : ControllerBase
    {
        private readonly GeminiService _geminiService;

        public ChatController(GeminiService geminiService)
        {
            _geminiService = geminiService;
        }

        [HttpPost("send")]
        public async Task<ActionResult<ChatResponse>> SendMessage([FromBody] ChatRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Message))
            {
                return BadRequest("Message cannot be empty.");
            }

            try
            {
                var reply = await _geminiService.GenerateReplyAsync(request.Message);
                return Ok(new ChatResponse { Reply = reply });
            }
            catch (Exception ex)
            {
                // Log the error as needed in production environment
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}
