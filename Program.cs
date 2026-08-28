using Microsoft.EntityFrameworkCore;
using WebWomen.Data;

var builder = WebApplication.CreateBuilder(args);

// 1. Define CORS policy name
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// 2. Configure CORS service
builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
        policy =>
        {
            policy.SetIsOriginAllowed(origin =>
            {
                // Allow local development
                if (origin.StartsWith("http://localhost:")) return true;

                // Allow any Vercel domain under your account or project
                if (origin.EndsWith(".vercel.app")) return true;

                return false;
            })
                  .AllowAnyHeader()
                  .AllowAnyMethod()
                  .AllowCredentials(); // Keep if passing credentials/auth headers
        });

});




// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddControllers();
builder.Services.AddAuthorization(); // <--- ADD THIS LINE
builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Configure EF Core with PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"),
    npgsqlOptions =>
    {
        // Enables resilience against brief network glitches between Render and Supabase
        npgsqlOptions.EnableRetryOnFailure(
                    maxRetryCount: 5,
                    maxRetryDelay: TimeSpan.FromSeconds(10),
                    errorCodesToAdd: null);
    }
    ));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseHttpsRedirection();
}

app.UseHttpsRedirection();

// 2. Enable CORS Middleware BEFORE MapControllers/UseAuthorization
app.UseRouting();
// 3. Enable CORS middleware BEFORE UseAuthorization and MapControllers
app.UseCors(MyAllowSpecificOrigins);

app.UseAuthorization();
app.MapControllers();

app.Run();
 
