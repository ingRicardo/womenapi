using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using WebWomen.Models;

namespace ChatApi.Services;

public class GeminiService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey;

    public GeminiService(HttpClient httpClient, IConfiguration configuration)
    {
        _httpClient = httpClient;
        _apiKey = configuration["GeminiApiKey"] ?? throw new ArgumentNullException("Gemini API key is missing.");
    }

    public async Task<string> GenerateReplyAsync(string userMessage)
    {
        // Fix: Updated model identifier to the universally supported gemini-3.8-flash
        var url = "https://generativelanguage.googleapis.com/v1beta/models/gemini-3.8-flash:generateContent";

        var requestBody = new
        {
            contents = new[]
            {
            new { parts = new[] { new { text = userMessage } } }
        }
        };

        var jsonPayload = JsonSerializer.Serialize(requestBody);

        int maxRetries = 3;
        int delayMilliseconds = 1500; // Start with a 1.5-second wait

        for (int i = 0; i < maxRetries; i++)
        {
            try
            {
                // Always create a fresh StringContent for each retry attempt
                var content = new StringContent(jsonPayload, Encoding.UTF8, "application/json");

                _httpClient.DefaultRequestHeaders.Clear();
                _httpClient.DefaultRequestHeaders.Add("x-goog-api-key", _apiKey.Trim());

                var response = await _httpClient.PostAsync(url, content);

                // If the server returns a 503 (Service Unavailable) or 429 (Too Many Requests), trigger a retry
                if (response.StatusCode == System.Net.HttpStatusCode.ServiceUnavailable ||
                    response.StatusCode == (System.Net.HttpStatusCode)429)
                {
                    if (i == maxRetries - 1) response.EnsureSuccessStatusCode(); // Throws on final failure

                    // Wait progressively longer: 1.5s, then 3.0s, then 6.0s
                    await Task.Delay(delayMilliseconds);
                    delayMilliseconds *= 2;
                    continue;
                }

                response.EnsureSuccessStatusCode();

                var jsonResponse = await response.Content.ReadAsStringAsync();
                using var doc = JsonDocument.Parse(jsonResponse);

                var replyText = doc.RootElement
                    .GetProperty("candidates")[0]
                    .GetProperty("content")
                    .GetProperty("parts")[0]
                    .GetProperty("text")
                    .GetString();

                return replyText ?? "No response generated.";
            }
            catch (HttpRequestException) when (i < maxRetries - 1)
            {
                // Catch network hiccup exceptions and naturally allow the loop to try again
                await Task.Delay(delayMilliseconds);
                delayMilliseconds *= 2;
            }
        }

        return "The AI service is temporarily overloaded. Please try again in a moment.";

    }


}
