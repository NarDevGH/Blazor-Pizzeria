using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2_Razer_Pizzeria.Data;
using WebApplication2_Razer_Pizzeria.Model;

namespace WebApplication2_Razer_Pizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> Pizzas = new();

        private readonly ApplicationDbContext _context;

        public PizzaModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            Pizzas = _context.Pizzas.ToList();
        }
    }
}
