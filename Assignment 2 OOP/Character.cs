using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_2_OOP
{
    internal class Character
    {
        //Private fields
        private string name;
        private HouseSpace currentLocation;
        private List<HouseSpace> houseSpaceList = new List<HouseSpace>();

        //Public properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public HouseSpace CurrentLocation
        {
            get { return currentLocation; }
            set { currentLocation = value; }
        }

        public List<HouseSpace> HouseSpaceList
        {
            get { return houseSpaceList; }
            set { houseSpaceList = value; }
        }

        //Constructor
        public Character(string givenName, HouseSpace givenLocation)
        {
            this.Name = givenName;
            this.CurrentLocation = givenLocation;
        }

        //Methods
        public void displayDialogue(string text, int speed, string textColor, string resetColor) //method to display character dialogue
        {
            Console.WriteLine();
            Console.Write(textColor);
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }

            Console.Write($"{this.Name}: ");

            bool skipDelay = false;

            foreach (char c in text)
            {
                Console.Write(c);

                if (!skipDelay) //if skipDelay is false
                {
                    // CHECK: If player press any key
                    if (Console.KeyAvailable)
                    {
                        skipDelay = true; // Cut the delay!
                        Console.ReadKey(true); // Discard the key press that was made by the user in ordere to skip the delay, so that it won't interfere with any subsequent key presses.
                    }
                    else
                    {
                        Thread.Sleep(speed);
                    }
                }
            }
            // Reset the console text color to default 
            Console.Write(resetColor);
            Console.WriteLine();
        }

        public Item exploreHouse(List<HouseSpace> allRooms)
        {
            HouseSpace space = this.CurrentLocation;
            Console.WriteLine($"CURRENT LOCATION: {space.Name}");
            Console.Write("Press 'M' to display the house map, 'E' to identify available primary(main) items in the current location, and 'C' to go to another location: ");
            try
            {
                char input = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (input == 'M')
                {
                    Console.WriteLine("===========================================================================");
                    Console.WriteLine("\nHOUSE MAP:");
                    space.displayHouseMap();
                    Console.WriteLine("===========================================================================");
                }
                else if (input == 'E')
                {
                    Console.WriteLine($"\n");
                    Console.WriteLine($"Available items/furnitures in {space.Name}:\n");
                    space.displayItems();
                    Console.WriteLine("\nSelect item number to check: ");
                    if (int.TryParse(Console.ReadLine(), out int itemChoice) && itemChoice >= 1 && itemChoice <= space.ItemsAvailable.Count)
                    {
                        Item selectedItem = space.ItemsAvailable[itemChoice - 1];
                        selectedItem.goTo();
                        return selectedItem;
                    }
                    else
                    {
                        Console.WriteLine("Invalid item selection.");
                        return null;
                    }
                }
                else if (input == 'C')
                {
                    Console.WriteLine("\n");
                    Console.WriteLine($"[Current Location: {this.CurrentLocation.Name}]\n");
                    Console.WriteLine($"Available locations (rooms/space) in the house:\n");
                    
                    for (int i = 0; i < allRooms.Count; i++)
                    {
                        Console.WriteLine($"{i + 1}. {allRooms[i].Name}");
                    }
                    Console.WriteLine("\nSelect room number to go: ");
                    if (int.TryParse(Console.ReadLine(), out int roomChoice) && roomChoice >= 1 && roomChoice <= allRooms.Count)
                    {
                        HouseSpace selectedRoom = allRooms[roomChoice - 1];
                        Console.WriteLine($"\nGoing to to {selectedRoom.Name}.");
                        this.CurrentLocation = selectedRoom;
                    }
                    else
                    {
                        Console.WriteLine("Invalid room selection.");
                    }
                    return null;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please try again.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
            return null;
        }
    }
    internal class Cat : Character
    {
        //Public enums
        public enum actionType
        {
            Observe,
            Grab,
            Bury,
            Claw,
            Shove,
            Scatter
        }

        public enum fightingOptions
        {
            Claw,
            Kick,
            Bite,
            //Can add one more fighting option here if you want or change above options as well.
        }

        //Private fields
        private actionType catActionType;
        private fightingOptions catFightingOptions;

        //Public properties
        public actionType CatActionType
        {
            get { return catActionType; }
            set { catActionType = value; }
        }

        public fightingOptions CatFightingOptions
        {
            get { return catFightingOptions; }
            set { catFightingOptions = value; }
        }


        //Constructor
        public Cat(string givenName, HouseSpace givenLocation) : base(givenName, givenLocation)
        {
        }
        //Methods

    }

    internal class MainCharacter : Cat
    {
        //private HouseSpace currentLocation;

        ////Properties
        //public HouseSpace CurrentLocation
        //{
        //    get { return currentLocation; }
        //    set { currentLocation = value; }
        //}
        //Constructor
        public MainCharacter(string givenName, HouseSpace givenLocation) : base(givenName, givenLocation)
        {
            this.CurrentLocation = givenLocation;
            this.Name = givenName;
        }
        //Methods
    }
}
