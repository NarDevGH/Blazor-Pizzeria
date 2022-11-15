using Microsoft.EntityFrameworkCore;
using WebApplication2_Razer_Pizzeria.Model;

namespace WebApplication2_Razer_Pizzeria.Data
{
    public class ApplicationDbContext :DbContext
    {
        public DbSet<PizzaDBModel> PizzaOrders { get; set; } // declarando tabla de la base de datos
        public DbSet<PizzasModel> Pizzas { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
    }
}
