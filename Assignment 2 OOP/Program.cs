using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Assignment_2_OOP
{
    internal class Program
    {
        private string resetColorField = "\x1b[0m"; //ANSI code
        static void Main(string[] args)
        {
            Program program = new Program();

            //---CREATING OBJECTS---
            //1. Creating objects of HouseSpace class
            HouseSpace Bathroom1 = new HouseSpace("Bathroom 1");
            HouseSpace Bedroom = new HouseSpace("Bedroom 1");
            HouseSpace MasterBedroom = new HouseSpace("Master Bedroom");
            HouseSpace Bathroom2 = new HouseSpace("Bathroom 2");
            HouseSpace LivingRoom = new HouseSpace("Living Room");
            HouseSpace Kitchen = new HouseSpace("Kitchen");
            HouseSpace Garage = new HouseSpace("Garage");
            

            //2. Creating objects of Item class

            //Bathroom 1 items
            Item Bathroom1ToiletBowl = new Item("Toilet Bowl", Bathroom1);
            Item Bathroom1Pail = new Item("Pail", Bathroom1);
            Item Bathroom1Tap = new Item("Tap", Bathroom1);

            //Bedroom  items
            Item BedroomBed = new Item("Bed", Bedroom);
            Item BedroomCloset = new Item("Closet", Bedroom);
            Item BedroomMiniTable1 = new Item("Mini Table 1", Bedroom);
            Item BedroomMiniTable2 = new Item("Mini Table 2", Bedroom);

            //Master Bedroom items
            Item MasterBedroomBed = new Item("Bed", MasterBedroom);
            Item MasterBedroomCloset = new Item("Closet", MasterBedroom);
            Item MasterBedroomMiniTable1 = new Item("Mini Table 1", MasterBedroom);
            Item MasterBedroomMiniTable2 = new Item("Mini Table 2", MasterBedroom);

            //Bathroom 2 items
            Item Bathroom2ToiletBowl = new Item("Toilet Bowl", Bathroom2);
            Item Bathroom2Pail = new Item("Pail", Bathroom2);
            Item Bathroom2Tap = new Item("Tap", Bathroom2);

            //Living Room items
            Item LRSofa1 = new Item("Sofa 1", LivingRoom);
            Item LRSofa2 = new Item("Sofa 2", LivingRoom);
            Item LRCoffeeTable = new Item("Coffee Table", LivingRoom);
            Item LRTVCabinet = new Item("TV Cabinet", LivingRoom);

            //Kitchen items
            Item KitchenLaundryBasket = new Item("Laundry Basket", Kitchen);
            Item KitchenFridge = new Item("Fridge", Kitchen);
            Item KitchenOven = new Item("Oven", Kitchen);
            Item KitchenSink = new Item("Sink", Kitchen);
            Item KitchenBarTable = new Item("Bar Table", Kitchen);

            //Garage items
            Item GarageHusbandCar = new Item("Husband Car", Garage);
            Item GarageWifeCar = new Item("Wife Car", Garage);
            Item GarageCatCage = new Item("Cat Cage", Garage);
            Item GarageCatFoodSack = new Item("Cat Food Sack", Garage);
            Item GarageToolBox = new Item("Tool Box", Garage);
            Item GarageShoeRack = new Item("Shoe Rack", Garage);

            //3. Creating objects of Character class
            

            Bathroom1.ItemsAvailable.Add(Bathroom1ToiletBowl);
            Bathroom1.ItemsAvailable.Add(Bathroom1Pail);
            Bathroom1.ItemsAvailable.Add(Bathroom1Tap);

            Bedroom.ItemsAvailable.Add(BedroomBed);
            Bedroom.ItemsAvailable.Add(BedroomCloset);
            Bedroom.ItemsAvailable.Add(BedroomMiniTable1);
            Bedroom.ItemsAvailable.Add(BedroomMiniTable2);

            MasterBedroom.ItemsAvailable.Add(MasterBedroomBed);
            MasterBedroom.ItemsAvailable.Add(MasterBedroomCloset);
            MasterBedroom.ItemsAvailable.Add(MasterBedroomMiniTable1);
            MasterBedroom.ItemsAvailable.Add(MasterBedroomMiniTable2);

            Bathroom2.ItemsAvailable.Add(Bathroom2ToiletBowl);
            Bathroom2.ItemsAvailable.Add(Bathroom2Pail);
            Bathroom1.ItemsAvailable.Add(Bathroom2Tap);
            
            LivingRoom.ItemsAvailable.Add(LRSofa1);
            LivingRoom.ItemsAvailable.Add(LRSofa2);
            LivingRoom.ItemsAvailable.Add(LRCoffeeTable);
            LivingRoom.ItemsAvailable.Add(LRTVCabinet);

            Kitchen.ItemsAvailable.Add(KitchenLaundryBasket);
            Kitchen.ItemsAvailable.Add(KitchenFridge);
            Kitchen.ItemsAvailable.Add(KitchenOven);
            Kitchen.ItemsAvailable.Add(KitchenSink);
            Kitchen.ItemsAvailable.Add(KitchenBarTable);

            Garage.ItemsAvailable.Add(GarageHusbandCar);
            Garage.ItemsAvailable.Add(GarageWifeCar);
            Garage.ItemsAvailable.Add(GarageCatCage);
            Garage.ItemsAvailable.Add(GarageCatFoodSack);
            Garage.ItemsAvailable.Add(GarageToolBox);
            Garage.ItemsAvailable.Add(GarageShoeRack);

            string titleArt = @"
              _____ _           ___    _ _              __      ___ _                     
             |_   _| |_  ___   | __|__| (_)_ _  ___     \ \    / (_) |_ _ _  ___ ______   
               | | | ' \/ -_)  | _/ -_) | | ' \/ -_)     \ \/\/ /| |  _| ' \/ -_|_-<_-<   
               |_| |_||_\___|  |_|\___|_|_|_||_\___|      \_/\_/ |_|\__|_||_\___/__/__/   
            ";

            string catASCII = @"
                   ,_     _,
                   |\\___//|
                   |=Q   Q=|
                   \=._Y_.=/
                    )  `  (    ,
                   /       \  ((
                   |       |   ))
                  /| |   | |\_//
                  \| |._.| |/-`
                   '""'   '""'
             ";

            string Tangerine = "\x1b[38;2;255;153;51m"; //ASNI
            program.delayedText(titleArt, 10, Tangerine, program.resetColorField);
            program.delayedText(catASCII, 10, Tangerine, program.resetColorField);
            string welcomeMessage = "Welcome to the The Feline Witness (trial version)! In this project, you will discover one of the mission in the actual 'The Feline Witness' game.";
            program.delayedText(welcomeMessage, 50, program.resetColorField, program.resetColorField);
            program.delayedText("The game is about a cat, that witnesses an event that changes it and its owner life, who is a woman, and a wife.", 50, program.resetColorField, program.resetColorField); 
            program.delayedText("There are several characters involved in this game. But for this trial version, let us just know three of them. They are the cat (the main character, controlled by you), the wife (the owner of the cat) and the husband).", 50, program.resetColorField, program.resetColorField);
            Console.ReadLine();
            program.delayedText("First let's give the cat a name..", 50, program.resetColorField, program.resetColorField);
            Console.Write("Please enter the name of the cat: ");
            string catName = Console.ReadLine();
            MainCharacter mainCharacterCat = new MainCharacter(catName, LivingRoom);
            program.delayedText($"Great! The cat's name is {mainCharacterCat.Name}!", 50, program.resetColorField, program.resetColorField);
            program.delayedText("Now, let's give the wife a name.", 50, program.resetColorField, program.resetColorField);
            Console.Write("Please enter the name of the wife: ");
            string wifeName = Console.ReadLine();
            Character Wife = new Character(wifeName, LivingRoom);
            program.delayedText($"Nice! The wife's name is {Wife.Name}!", 50, program.resetColorField, program.resetColorField);
            program.delayedText("Now, let's give the husband a name.", 50, program.resetColorField, program.resetColorField);
            Console.Write("Please enter the name of the husband: ");
            string husbandName = Console.ReadLine();
            Character Husband = new Character(husbandName, LivingRoom);
            program.delayedText($"Great! The husband's name is {Husband.Name}!", 50, program.resetColorField, program.resetColorField);
            Console.Clear();
            program.delayedText($"One day {Wife.Name} went outstation. According to {Husband.Name}, he also had to go outstation on that day, but {Wife.Name} went out first.", 50, program.resetColorField, program.resetColorField);
            Console.ReadKey();
            Wife.displayDialogue("Bye honey, see you later!", 50, program.resetColorField, program.resetColorField);
            Husband.displayDialogue("Bye babe!", 50, program.resetColorField, program.resetColorField);
            Console.ReadKey();
            program.delayedText($"But according to {mainCharacterCat.Name}'s observation, {Husband.Name} didn't appear to get ready for an outstation. Instead he seemed quite relax. ", 50, program.resetColorField, program.resetColorField);
            Console.ReadKey();
            program.delayedText($"Until the clock struck at 9.30 pm, {mainCharacterCat.Name} saw him texting with someone while sitting on a sofa in the living room.", 50, program.resetColorField, program.resetColorField);
            Console.ReadKey();
            program.delayedText($"{mainCharacterCat.Name} also saw that {Husband.Name} sometimes laughed while texting that person.", 50, program.resetColorField, program.resetColorField);
            Console.ReadKey();
            program.delayedText($"Feeling curious, {mainCharacterCat.Name} wanted to approach {Husband.Name} on a sofa, so it can identify who was {Husband.Name} texting to.", 50, program.resetColorField, program.resetColorField);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            program.delayedText($"MISSION: find the sofa where the husband was sitting.", 50, program.resetColorField, program.resetColorField);

            List<HouseSpace> allRooms = new List<HouseSpace>() { Bathroom1, Bedroom, MasterBedroom, Bathroom2, LivingRoom, Kitchen, Garage };
            bool exampleMissionCompleted = false;
            while (!exampleMissionCompleted)
            {
                Item wentToItem = mainCharacterCat.exploreHouse(allRooms);
                if (wentToItem != null)
                {
                    if (mainCharacterCat.CurrentLocation.Name == "Living Room" && wentToItem.Name == "Sofa 2")
                    {
                        exampleMissionCompleted = true;
                        program.delayedText($"Congratulations! You have found the sofa where {Husband.Name} was sitting!", 50, program.resetColorField, program.resetColorField);
                    }
                    else
                    {
                        program.delayedText($"This is not the place where {Husband.Name} was sitting, try again!!", 50, program.resetColorField, program.resetColorField);
                    }
                }
            }
        }

        public void delayedText(string text, int speed, string textColor, string resetColor)
        {
            // When we call Console.Write(textColor), it will change the color of the text that follows it in the console output to the color specified by the ANSI escape code in textColor.
            Console.Write(textColor);

            // 1. CLEAR BUFFER: Remove every key input 
            //Console.KeyAvailable Property is used to get a value which shows whether a key press is available in the input stream.
            //Or in another word , it checks whether there are any key presses that have been made by the user but have not yet been read by the program. If there are key presses available in the input stream, it returns true; otherwise, it returns false.
            //Input stream is the buffer that holds the key presses until they are read by the program. When a key is pressed, it is stored in the input stream until the program reads it using Console.ReadKey() or similar methods. If there are any key presses in the input stream, Console.KeyAvailable will return true, indicating that there is a key press available to be read. If there are no key presses in the input stream, it will return false.
            //Console.ReadKey(true) method is used to READ A KEY PRESS IN THE INPUT STREAM. The true parameter indicates that the key press should not be displayed in the console. When this method is called, it will read the next key press from the input stream and return it as a ConsoleKeyInfo object. If there are no key presses available in the input stream, it will block until a key press is available.
            //This block of code is like this "read and discard the key input in the Input Stream while there is a key input in the InputStram"
            //This effectively clears the input buffer of any key presses that may have been made by the user before calling this method, ensuring that any subsequent key presses will be processed correctly without interference from previous inputs.
            while (Console.KeyAvailable)
            {
                Console.ReadKey(true);
            }

            bool skipDelay = false;

            foreach (char c in text)
            {
                Console.Write(c);

                if (!skipDelay) //if skipDelay is false
                {
                    // 2. RADAR: If player press any key
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
            Console.WriteLine("\n");
        }
    }
}
