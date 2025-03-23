// MonetisV2.Shared/Expense.cs
namespace MonetisV2.Shared
{
    public class Expense
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty; // Initialize to avoid CS8618 warning
        public decimal Amount { get; set; }
        public string Category { get; set; } = string.Empty; // Initialize to avoid CS8618 warning
        public DateTime Date { get; set; }
    }
}