// MonetisV2.Server/Models/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using MonetisV2.Shared;

namespace MonetisV2.Server.Models
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Expense> Expenses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Expense>().HasData(
                new Expense { Id = 1, Description = "Coffee", Amount = 4.50m, Category = "Food", Date = DateTime.Today.AddDays(-2) },
                new Expense { Id = 2, Description = "Gas", Amount = 30.00m, Category = "Transport", Date = DateTime.Today.AddDays(-1) },
                new Expense { Id = 3, Description = "Groceries", Amount = 80.75m, Category = "Food", Date = DateTime.Today },
                new Expense { Id = 4, Description = "Netflix", Amount = 12.99m, Category = "Entertainment", Date = DateTime.Today.AddDays(-7) },
                new Expense { Id = 5, Description = "Books", Amount = 25.00m, Category = "Education", Date = DateTime.Today.AddDays(-3) }
            );
        }

    }


}
