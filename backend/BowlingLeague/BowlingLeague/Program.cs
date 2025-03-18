using BowlingLeague.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();

// Add CORS policy to allow React frontend
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAllOrigins",
        policy =>
        {
            policy.AllowAnyOrigin()
                  .AllowAnyMethod()
                  .AllowAnyHeader();
        });
});

// Configure database context with SQLite
builder.Services.AddDbContext<BowlerDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("BowlingLeagueDb")));
builder.Services.AddScoped<BowlerRepository>();
var app = builder.Build();

// Middleware pipeline
app.UseHttpsRedirection();
app.UseCors("AllowAllOrigins"); // Place AFTER UseHttpsRedirection, BEFORE UseAuthorization
app.UseAuthorization();
app.MapControllers();

app.Run();
