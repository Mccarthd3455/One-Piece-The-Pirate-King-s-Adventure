using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/**
* Date 3/15/2023
*CSC 153
*David McCarthy
*This Version of the game contains the menu to display rooms, weapons, potions, treasure, items, and mobs. Updated Verison: Now continues to display menu and 
*it now has files to contain the variables
*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showAgain = true;
            do
            {
                Console.WriteLine("To open menu type Menu or type Quit to quit the program.");
                string userMenuInput;
                string userInitalInput = Console.ReadLine();
                if (userInitalInput == "Menu")
                {
                    Console.WriteLine("Menu Opened.");
                    Console.WriteLine("Type the numbers or word (that is displayed) to display your choice.");
                    Console.WriteLine("1. Display Rooms");
                    Console.WriteLine("2. Display Weapons");
                    Console.WriteLine("3. Display Potions");
                    Console.WriteLine("4. Display Treasure");
                    Console.WriteLine("5. Display Items");
                    Console.WriteLine("6. Display Mobs");
                    Console.WriteLine("7. Exit");
                    userMenuInput = Console.ReadLine();
                    if (userMenuInput == "1" || userMenuInput == "Rooms")
                    {
                        StreamReader inputFile;
                        inputFile = File.OpenText("Rooms.csv");
                        while (!inputFile.EndOfStream)
                        {
                            String id;
                            String name;
                            String description;
                            String[] line;
                            line = inputFile.ReadLine().Split(',');
                            id = (line[0]);
                            name = (line[1]);
                            description = (line[2]);
                            Console.WriteLine(id);
                            Console.WriteLine(name);
                            Console.WriteLine(description);
                            showAgain = true;
                        }
                        inputFile.Close();
                    }
                    else if (userMenuInput == "2" || userMenuInput == "Weapons")
                    {
                        StreamReader inputFile;
                        inputFile = File.OpenText("Weapons.csv");
                        while (!inputFile.EndOfStream)
                        {
                            String id;
                            String name;
                            String description;
                            String[] line;
                            line = inputFile.ReadLine().Split(',');
                            id = (line[0]);
                            name = (line[1]);
                            description = (line[2]);
                            Console.WriteLine(id);
                            Console.WriteLine(name);
                            Console.WriteLine(description);
                            showAgain = true;
                        }
                        inputFile.Close();
                    }
                    else if (userMenuInput == "3" || userMenuInput == "Potions")
                    {
                        StreamReader inputFile;
                        inputFile = File.OpenText("Potions.csv");
                        while (!inputFile.EndOfStream)
                        {
                            String id;
                            String name;
                            String description;
                            String [] line;
                            line = inputFile.ReadLine().Split(',');
                            id = (line[0]);
                            name = (line[1]);
                            description = (line[2]);
                            Console.WriteLine(id);
                            Console.WriteLine(name);
                            Console.WriteLine(description);
                            showAgain = true;
                        }
                    }
                    else if (userMenuInput == "4" || userMenuInput == "Treasure")
                    {
                        StreamReader inputFile;
                        inputFile = File.OpenText("Treasure.csv");
                        while (!inputFile.EndOfStream)
                        {
                            String id;
                            String name;
                            String description;
                            String[] line;
                            line = inputFile.ReadLine().Split(',');
                            id = (line[0]);
                            name = (line[1]);
                            description = (line[2]);
                            Console.WriteLine(id);
                            Console.WriteLine(name);
                            Console.WriteLine(description);
                            showAgain = true;
                        }
                    }
                    else if (userMenuInput == "5" || userMenuInput == "Items")
                    {
                        StreamReader inputFile;
                        inputFile = File.OpenText("Items.csv");
                        while (!inputFile.EndOfStream)
                        {
                            String id;
                            String name;
                            String description;
                            String[] line;
                            line = inputFile.ReadLine().Split(',');
                            id = (line[0]);
                            name = (line[1]);
                            description = (line[2]);
                            Console.WriteLine(id);
                            Console.WriteLine(name);
                            Console.WriteLine(description);
                            showAgain = true;
                        }

                    }
                    else if (userMenuInput == "6" || userMenuInput == "Mobs")
                    {
                        StreamReader inputFile;
                        inputFile = File.OpenText("Mobs.csv");
                        while (!inputFile.EndOfStream)
                        {
                            String id;
                            String name;
                            String description;
                            String[] line;
                            line = inputFile.ReadLine().Split(',');
                            id = (line[0]);
                            name = (line[1]);
                            description = (line[2]);
                            Console.WriteLine(id);
                            Console.WriteLine(name);
                            Console.WriteLine(description);
                            showAgain = true;
                        }
                    }
                    else if (userMenuInput == "7" || userMenuInput == "Exit")
                    {
                        Environment.Exit(0);
                    }
                }
                else if (userInitalInput == "Quit")
                {
                    Environment.Exit(0);
                    showAgain = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input Please Try Again");
                }
            } while (showAgain == true);
            
            

        }
    }
}
