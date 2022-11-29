using Microsoft.EntityFrameworkCore;
using RazorPizza.Model;
using RazorPizza.Pages.Checkout;

namespace RazorPizza.Data
{ 
    public class ApplicationDbContext : DbContext
    {
        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    }
}