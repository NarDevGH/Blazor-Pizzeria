using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2_Razer_Pizzeria.Data;
using WebApplication2_Razer_Pizzeria.Model;

namespace WebApplication2_Razer_Pizzeria.Pages
{
    public class OrdersModel : PageModel
    {
        public List<PizzaDBModel> PizzaOrders = new();

        private readonly ApplicationDbContext _context;
        public OrdersModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            PizzaOrders = _context.PizzaOrders.ToList();
        }
    }
}
