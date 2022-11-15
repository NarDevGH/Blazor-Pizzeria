namespace WebApplication2_Razer_Pizzeria.Model
{
    public class PizzasModel
    {
        public int Id { get; set; }
        public string ImageTitle { get; set; }
        public string PizzaName { get; set; }
        public float BasePrice { get; set; }
        public float FinalPrice { get; set; }
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Mushrooms { get; set; }
        public bool Tuna { get; set; }
        public bool Ham { get; set;  }

    }
}
