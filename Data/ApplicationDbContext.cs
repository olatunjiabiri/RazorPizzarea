using Microsoft.EntityFrameworkCore;
using RazorPizzarea.Models;

namespace RazorPizzarea.Data
{
    public class ApplicationDbContext: DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) 
            : base(options)
        {

        }
    }
}
