# Assignment 2 TEB 1043 Object Oriented Programming (Part of our Group Project: The Feline Witness)

## Brief Description
This is the GitHub repository for my Assignment 2. It represents **a part of** how my group project (a game titled **The Feline Witness**) is going to look like. **The Feline Witness** is a menu-driven, console-based interactive fiction game built entirely in C#.

The game places the player in the unique perspective of a household pet cat. After witnessing a suspicious conversation, the cat discovers that the husband is having a secret affair while the wife is away on an outstation trip. The ultimate goals of the game is for the feline protagonist to cancel the husband and his affair meeting in the house by interacting with various items in the house such as taking the husband's car key and hiding it at a place, so he can go out (one of the missions in this game), and ultimately find a way to expose the truth and inform the wife.

## Group members
1. Ahmad Zafran Bin Faizal 24005345
2. Muhammad Wafi Bin Azman 24005379
3. Muhammad Asyraaf Bin Mustafa 24005305
4. Lee Xin Yue 24005697
5. Humaira Rayyan Binti Haslah 24005364

## 1.0 Project Description
This project is developed specifically for Assignment 2 of Assignment 2 TEB 1043 Object Oriented Programming. It serves as a focused, standalone interactive simulation **derived from our main game project, "The Feline Witness"**. The primary objective of this specific build is to demonstrate core Object-Oriented Programming (OOP) principles specifically Encapsulation and Object Interaction in strict accordance with the assignment's requirements. To achieve this, the system architecture was adapted to implement several main classes from our original UML design Assignment 1: Character, HouseSpace, and Item. In this mini-game, the player takes on the role of a highly observant house cat. The storyline revolves around the cat's suspicion towards its male owner (the husband). After noticing the husband constantly smiling at his smartphone while lounging in the living area, the feline protagonist decides to investigate the device to uncover the truth. The simulation is considered successful when the player manages to track down the exact location where the husband was sitting and using his phone, which is Sofa 2 in the Living Room. The gameplay exclusively highlights the exploration and spatial movement mechanics. Players are given the freedom to navigate the cat through various encapsulated HouseSpace objects (such as the bedroom, kitchen, and garage) and thoroughly inspect the Item objects contained within them. By carefully examining the environment and choosing the correct sequence of rooms and furniture to interact with, the player will eventually discover the target item, demonstrating a seamless flow of data and interaction between the instantiated objects within the program's main execution loop.

## 2.0 System Features
### Interactive Spatial Navigation: 
The game features a room-to-room "travel" system. Players can input the 'C' command to view available rooms and move the main character between different HouseSpace objects (such as Bedroom, Kitchen, Living Room). The system securely updates and tracks the character's location using OOP properties.

### Environment Exploration & Object Interaction: 
By using the 'E' command, the project will reveal a list of 'Item' objects present in that specific room. Selecting an item triggers an interaction sequence where the system evaluates if the selected object is the target item (Sofa 2), which shows dynamic object-to-object communication. 

### House Map Interface: 
Players can press 'M' at any point during the exploration phase to pull up an ASCII-art map of the house. This feature aids players in visualizing the layout of the HouseSpace objects and planning their next move. 

### Custom Text Rendering Engine: 
To enhance the console-based user experience, the project has a custom 'delayedText' method. This method prints text character-by-character to simulate real-time typing, complete with customizable reading speeds and ANSI color codes for different contexts. Players can also skip the typing delay by pressing any key. 

### Encapsulated State Management: 
True to the assignment's core requirement, the system strictly protects its data. Sensitive variables, such as a room's item list or a character's current location, are stored in private fields and accessed solely through public properties or controlled methods.
