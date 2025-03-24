// MonetisV2.Server/Controllers/ExpensesController.cs
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MonetisV2.Shared;
using MonetisV2.Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MonetisV2.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        // GET: api/expenses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Expense>>> GetExpenses()
        {
            return await _context.Expenses.ToListAsync();
        }

        // GET: api/expenses/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Expense>> GetExpense(int id)
        {
            var expense = await _context.Expenses.FindAsync(id);
            if (expense == null) return NotFound();
            return expense;
        }

        // POST: api/expenses
        [HttpPost]
        public async Task<ActionResult<Expense>> PostExpense(Expense expense)
        {
            _context.Expenses.Add(expense);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetExpense), new { id = expense.Id }, expense);
        }

        // PUT: api/expenses/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> PutExpense(int id, Expense expense)
        {
            if (id != expense.Id) return BadRequest();
            _context.Entry(expense).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // DELETE: api/expenses/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteExpense(int id)
        {
            var expense = await _context.Expenses.FindAsync(id);
            if (expense == null) return NotFound();
            _context.Expenses.Remove(expense);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        // GET: api/expenses/total
        [HttpGet("total")]
        public async Task<ActionResult<decimal>> GetTotalSpent()
        {
            return await _context.Expenses.SumAsync(e => e.Amount);
        }

        // GET: api/expenses/category/{category}
        [HttpGet("category/{category}")]
        public async Task<ActionResult<IEnumerable<Expense>>> GetByCategory(string category)
        {
            return await _context.Expenses
                .Where(e => e.Category.ToLower() == category.ToLower())
                .ToListAsync();
        }

        // GET: api/expenses/range?start=2025-03-01&end=2025-03-31
        [HttpGet("range")]
        public async Task<ActionResult<IEnumerable<Expense>>> GetInRange([FromQuery] DateTime start, [FromQuery] DateTime end)
        {
            return await _context.Expenses
                .Where(e => e.Date >= start && e.Date <= end)
                .ToListAsync();
        }

    }
}