// Program.cs (MonetisV2.Server)

using Microsoft.EntityFrameworkCore;
using MonetisV2.Server.Models;
using Microsoft.AspNetCore.ResponseCompression;
using MonetisV2.Server.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Register SQLite DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=monetis.db"));

// Add Controllers and Swagger
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS to allow Blazor client to access API
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins("https://localhost:6004") // Client port
              .AllowAnyHeader()
              .AllowAnyMethod();
    });
});
// Add response compression
builder.Services.AddResponseCompression(opts =>
{
    string[] extraMimeTypes = new[] { "application/octet-stream" };
    opts.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(MimeTypes.Extra);
});

var app = builder.Build();

// Use CORS before routing
app.UseCors();

// Use compression
app.UseResponseCompression();

// Dev environment
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
