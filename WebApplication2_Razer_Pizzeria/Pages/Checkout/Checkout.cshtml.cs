using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2_Razer_Pizzeria.Data;
using WebApplication2_Razer_Pizzeria.Model;

namespace WebApplication2_Razer_Pizzeria.Pages.Checkout
{
    [BindProperties(SupportsGet = true)]
    public class CheckoutModel : PageModel
    {
        public string PizzaName { get; set; }
        public float PizzaPrice { get; set; }
        public string ImageTitle { get; set; }

        private readonly ApplicationDbContext _context;
        public CheckoutModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
            if (string.IsNullOrWhiteSpace(PizzaName)) 
            {
                PizzaName = "Custom";
            }
            if (string.IsNullOrWhiteSpace(ImageTitle))
            {
                ImageTitle = "Create";
            }

            PizzaDBModel pizzaOrder = new();
            // No hace falta asignarle una Id ya que EntityFramework detecta solo que es una llave primaria y se encarga solo de asignarle un valor
            pizzaOrder.PizzaName = PizzaName;
            pizzaOrder.Price = PizzaPrice;

            _context.PizzaOrders.Add(pizzaOrder);

            // Siempre que se realide alguna operacion sobre la base de dato se debe de guardar haciendo _context.SaveChanges()
            // para que los cambios se hagan, de otra forma no se cambiara nada en la base de datos.
            _context.SaveChanges(); 
        }
    }
}
