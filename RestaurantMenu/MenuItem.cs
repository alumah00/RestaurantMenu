using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class MenuItem
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public DateTime DateAdded { get; set; }

        public MenuItem(string name, double price, string description, string category)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Category = category;
            //this.DateAdded = date;
        }

        public void PrintDetails()
        {
            Console.WriteLine($"{this.Name} ${this.Price} \n {this.Description}");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~");
        }


        public int Age
        {
            get
            {
                TimeSpan timeSpan = DateTime.Today - DateAdded;

                int years = timeSpan.Days / 365;
                int months = years / 12;

                return years;
                // Age = years
            }
        }

        


        public void DisplayMenu()
        {
            Console.WriteLine($"{this.Name} {this.Price} {this.Description} {this.Category} {Age}");
            if (Age <= 30)
            {
                Console.WriteLine("NEW!!!");
            }
        }

    }
}
