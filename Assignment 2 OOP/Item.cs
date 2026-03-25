    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_OOP
{
    internal class Item
    {
        //Private fields
        private string name;
        private HouseSpace location;

        //Public properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public HouseSpace Location 
        {
            get { return location; }
            set { location = value; }
        }

        //Constructor
        public Item(string givenName, HouseSpace givenLocation)
        {
            this.Name = givenName;
            this.Location = givenLocation;
        }

        //Methods
        public string displayItemName() //method to display information about the item
        {
            return Name;
        }

        public void goTo()
        {
            Console.WriteLine($"Going to {Name}....\n");
        }
    }
}
