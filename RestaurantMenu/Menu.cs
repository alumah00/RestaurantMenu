using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantMenu
{
    class Menu
    {

        public List<MenuItem> listOfMenuItems = new List<MenuItem>();

        public string MenuName { get; set; }

        public Menu(string name)
        {
            this.MenuName = name;
        }

        public void AddMenuItem(MenuItem item)
        {
            this.listOfMenuItems.Add(item);
        }

        public void PrintMenuItems()
        {
            foreach(MenuItem item in this.listOfMenuItems)
            {
                item.PrintDetails();
            }
        }
    }
}
