using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library
{
    class MenuIfStatements
    {
        public static bool DisplayMenu(string userInitalInput)
        {
            string userMenuInput;
            bool showAgain = false;
            if (userInitalInput == "Menu")
            {
                MenuItems.Display();
                userMenuInput = Menu.MenuChoices.userChoice();
                if (userMenuInput == "1" || userMenuInput == "Rooms")
                {
                    showAgain = Menu.Rooms.DisplayRooms();
                }
                else if (userMenuInput == "2" || userMenuInput == "Weapons")
                {
                    showAgain = Menu.Weapons.DisplayWeapons();
                }
                else if (userMenuInput == "3" || userMenuInput == "Potions")
                {
                    showAgain = Menu.Potions.DisplayPotions();
                }
                else if (userMenuInput == "4" || userMenuInput == "Treasure")
                {
                    showAgain = Menu.Treasure.DisplayTreasure();
                }
                else if (userMenuInput == "5" || userMenuInput == "Items")
                {
                    showAgain = Menu.Items.DisplayItems();
                }

                else if (userMenuInput == "6" || userMenuInput == "Mobs")
                {
                    showAgain = Menu.Mobs.DisplayMobs();
                }
                else if (userMenuInput == "7" || userMenuInput == "Combat")
                {
                    Combat.CombatSystem.combatSystem();
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
            return showAgain;
        }
    }
}
