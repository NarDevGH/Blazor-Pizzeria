using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication2_Razer_Pizzeria.Model;

namespace WebApplication2_Razer_Pizzeria.Pages.Froms
{
    public class CustomPizzaModel : PageModel
    {
        [BindProperty]
        public PizzasModel Pizza { get; set; }
        public float PizzaPrice { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost() 
        {
            PizzaPrice = Pizza.BasePrice;

            if (Pizza.TomatoSauce) PizzaPrice += 10;
            if (Pizza.Cheese) PizzaPrice += 20;
            if (Pizza.Peperoni) PizzaPrice += 30;
            if (Pizza.Mushrooms) PizzaPrice += 40;
            if (Pizza.Tuna) PizzaPrice += 50;
            if (Pizza.Ham) PizzaPrice += 50;

            return RedirectToPage("/Checkout/Checkout",new {Pizza.PizzaName, PizzaPrice});
        }
    }
}
