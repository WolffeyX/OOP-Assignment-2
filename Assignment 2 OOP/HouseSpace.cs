using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2_OOP
{
    internal class HouseSpace
    {
        //Things to do:
        //One more method

        //private fields
        private string name; 
        private  List<Item> itemsAvailable = new List<Item>();

        //public properties
        public List<Item> ItemsAvailable 
        { 
            get { return itemsAvailable; } 
            set { itemsAvailable = value; } 
        } 

        public string Name 
        {
            get { return name; }
            set { name = value; }
        }

        //constructor
        public HouseSpace(string givenName) 
        {
            // Initialize the list of items available in the house space
            ItemsAvailable = new List<Item>();
            this.Name = givenName;
        }

        //methods
        public void displayItems() //method to display items in the house space
        {
            for (int i = 0; i < ItemsAvailable.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {ItemsAvailable[i].displayItemName()}");
            }
        }

        public void displayHouseMap()
        {
            const string map = @"
+--------+-----[Window]---+------[Window]----+---------+
|        |                |                  |         |
|  Bath       Bedroom     |  Master Bedroom       Bath |
| room 1 |                |                  |   room 2|
+--------+---  -----------+---------------  -+---------+
|                         |                  |
|                         |                  |
[Win]                     |              [Win]
|       Living Room              Kitchen     |
|                         |                  |
|                         |                  |
+---  ------[Window]-------+-----[Window]-----+
|                                            |
|                                            |
|                   Garage                   |
|                                            |
+--------------------------------------------+
";
            Console.WriteLine(map);
        }
    }
}
