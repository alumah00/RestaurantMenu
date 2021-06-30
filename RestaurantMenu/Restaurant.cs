using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class Restaurant
    {
        public static void Main(string[] args) 
        {
            Menu HamulaMenu = new Menu("Hamula");
            //add items to the menu
            MenuItem item1 = new MenuItem
                (
                "Bread", 5.00, "Loaf of bread.", "Appetizer"
                );
            MenuItem item2 = new MenuItem
                (
                "Pizza", 10.00, "Pineapple Only.", "Entree"
                );
            MenuItem item3 = new MenuItem
                (
                "Mac 'n Cheese", 8.00, "Cheddar Cheesy goodness.", "Entree"
                );
            MenuItem item4 = new MenuItem
                (
                "Cake", 7.00, "Chocolate Sprinkles.", "Dessert"
                );

            HamulaMenu.AddMenuItem(item1);
            HamulaMenu.AddMenuItem(item2);
            HamulaMenu.AddMenuItem(item3);
            HamulaMenu.AddMenuItem(item4);


            //Print entire menu

            HamulaMenu.PrintMenuItems();


            //Print individual item

            //item2.PrintDetails();

            //Delete and item and reprint the menu



        }
    }
}
