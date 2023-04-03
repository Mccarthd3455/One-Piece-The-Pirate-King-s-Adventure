using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library
{
    public  class One_Piece_The_Pirate_Kings_Adventure_Class
    {
        
        public static void gameMenu()
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
                    Console.WriteLine("7. Combat");
                    Console.WriteLine("8. Exit");
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
                    else if (userMenuInput == "7" || userMenuInput == "Combat")
                    {
                        combatSystem();
                        showAgain = true;
                    }
                    else if (userMenuInput == "8" || userMenuInput == "Exit")
                    {
                        Console.WriteLine("Menu Closed.");
                        showAgain = false;
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
        public static void combatSystem()
        {
            int userHP = 100;
            int enemyHP = 100;
            int roundCounter = 0;
            bool IsDead = false;
            Random rand = new Random();
            do
            {
                   for(roundCounter = 1; userHP > 0 && enemyHP > 0; roundCounter++)
                {
                    int userDamageDealt = randomNum1D12(rand);
                    int enemyDamageDealt = enemyRandomNum1D12(rand);
                    userHP = userHP - enemyDamageDealt;
                    enemyHP = enemyHP - userDamageDealt;
                    Console.WriteLine("Round " + roundCounter);
                    Console.WriteLine("User Health: " + userHP);
                    Console.WriteLine("Enemy Health: " + enemyHP);
                    if (userHP <= 0)
                    {
                        Console.WriteLine("You Died in " + roundCounter + " rounds.");
                        IsDead = true;
                        Console.ReadLine();
                    }
                    if (enemyHP <= 0)
                    {
                        Console.WriteLine("The fight lasted " + roundCounter + " rounds.");
                        IsDead = true;
                        Console.ReadLine();
                    }
                }
                    
            }
            while (IsDead == false);
        }
        public static int randomNum1D12(Random rand)
        {
            string diceType = "1D12";
            string[] dice = diceType.Split('D');
            int amountOfDice = int.Parse(dice[0]);
            int maxNumberDice = int.Parse(dice[1]);
            int damage = 0;
            for (int i = 0; i < amountOfDice; i++)
            {
                damage = damage + rand.Next(maxNumberDice + 1);
            }
            return damage;
        }
        public static int enemyRandomNum1D12(Random rand)
        {
            string diceType = "1D12";
            string[] dice = diceType.Split('D');
            int amountOfDice = int.Parse(dice[0]);
            int maxNumberDice = int.Parse(dice[1]);
            int damage = 0;
            for (int i = 0; i < amountOfDice; i++)
            {
                damage = damage + rand.Next(maxNumberDice + 1);
            }
            return damage;
        }
    }
}
