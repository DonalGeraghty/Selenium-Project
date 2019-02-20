using System;

namespace SeleniumDemoCSharp{
    public class About : Navbar
    {
        public string listDrinks { get; set; } = "s-list-drinks";
        public string listDrinksCoffee { get; set; } = "s-list-Coffee";
        public string listDrinksTea { get; set; } = "s-list-Tea";
        public string listDrinksMilk { get; set; } = "s-list-Milk";
        public string dropdownCars { get; set; } = "s-dropdown-cars";
        public string dropdownCarsVolvo { get; set; } = "s-dropdown-Volvo";
        public string dropdownCarsSaab { get; set; } = "s-dropdown-Saab";
        public string dropdownCarsOpel { get; set; } = "s-dropdown-Opel";
        public string dropdownCarsAudi { get; set; } = "s-dropdown-Audi";

        public string buttonDemo { get; set; } = "s-button-demo";
        public string paragraphDemo { get; set; } = "s-paragraph-demo";
    }
}
