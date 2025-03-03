using Microsoft.EntityFrameworkCore;
using Monetis.Server.Models;

var builder = WebApplication.CreateBuilder(args);

// Register the DbContext with SQLite as the database provider
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=monetis.db"));

builder.Services.AddControllers(); // Add support for API controllers
builder.Services.AddSwaggerGen(); // Add Swagger for API documentation

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(); // Enable Swagger
    app.UseSwaggerUI(); // Enable Swagger UI
}

app.UseHttpsRedirection(); // Redirect HTTP requests to HTTPS
app.UseAuthorization(); // Enable authorization

app.MapControllers(); // Map API controllers

app.Run(); // Start the application