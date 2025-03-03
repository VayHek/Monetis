using Microsoft.EntityFrameworkCore;

namespace Monetis.Server.Models
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Shared.Models.Expense> Expenses { get; set; }
    }
}