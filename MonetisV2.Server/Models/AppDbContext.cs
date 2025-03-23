// MonetisV2.Server/Models/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using MonetisV2.Shared;

namespace MonetisV2.Server.Models
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Expense> Expenses { get; set; }
    }
}