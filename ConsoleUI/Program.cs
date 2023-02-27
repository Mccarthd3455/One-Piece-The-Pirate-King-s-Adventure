using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
* Date 2/26/2023
*CSC 153
*David McCarthy
*This Version of the game contains the menu to display rooms, weapons, potions, treasure, items, and mobs.
*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("To open menu type Menu or type Quit to quit the program.");
            string userMenuInput;
            string userInitalInput = Console.ReadLine();
            if (userInitalInput == "Menu")
            {
                Console.WriteLine("Menu Opened.");
                Console.WriteLine("Type the numbers shown to display your choice.");
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
                    string entranceSeaKingBar = "Entrance to the Sea King's Bar";
                    string barRoomSeaKingBar = "Sea King's Bar Barroom";
                    string entranceGarpGroceryStore = "Entrance to Garp's Grocery Store";
                    string storageGarpGroceryStore = "Garp's Grocery Store Storage Room";
                    string storeRoomGarpGroceryStore = "Garp's Grocery Store Storeroom";
                    Console.WriteLine(entranceSeaKingBar);
                    Console.WriteLine(barRoomSeaKingBar);
                    Console.WriteLine(entranceGarpGroceryStore);
                    Console.WriteLine(storageGarpGroceryStore);
                    Console.WriteLine(storeRoomGarpGroceryStore);
                    Console.ReadLine();
                }
                else if (userMenuInput == "2" || userMenuInput == "Weapons")
                {
                    string rustyDagger = "Rusty Dagger";
                    string rustyCutLass = "Rusty Cutlass";
                    string rustyFlintLock = "Rusty FlintLock";
                    string slingShot = "Slingshot";
                    Console.WriteLine(rustyDagger);
                    Console.WriteLine(rustyCutLass);
                    Console.WriteLine(rustyFlintLock);
                    Console.WriteLine(slingShot);
                    Console.ReadLine();
                }
                else if (userMenuInput == "3" || userMenuInput == "Potions")
                {
                    string smallHealthPotion = "Small Health Potion (+25 hp)";
                    string largeHealthPotion = "Large Health Potion (+100 hp)";
                    Console.WriteLine(smallHealthPotion);
                    Console.WriteLine(largeHealthPotion);
                    Console.ReadLine();
                }
                else if (userMenuInput == "4" || userMenuInput == "Treasure")
                {
                    string rustedChest = "Rusted Chest";
                    string silverChest = "Silver Chest";
                    string goldenChest = "Golden Chest";
                    Console.WriteLine(rustedChest);
                    Console.WriteLine(silverChest);
                    Console.WriteLine(goldenChest);
                    Console.ReadLine();
                }
                else if (userMenuInput == "5" || userMenuInput == "Items")
                {
                    string seaKingsShot = "Sea King's Shot (Drink)";
                    string seaKingsSteak = "Sea King's Steak (Food)";
                    string seaKingsFish = "Sea King's Fish (Food)";
                    string garpsEnergyDrink = "Garp's Energy Drink";
                    string luffysChips = "Luffy's Chips";
                    Console.WriteLine(seaKingsShot);
                    Console.WriteLine(seaKingsSteak);
                    Console.WriteLine(seaKingsFish);
                    Console.WriteLine(garpsEnergyDrink);
                    Console.WriteLine(luffysChips);
                    Console.ReadLine();

                }
                else if (userMenuInput == "6" || userMenuInput == "Mobs")
                {
                    string pettyTheif = "A Petty Theif";
                    string seaKing = "A Sea King";
                    string smallVemonSnake = "A small vemonous Snake";
                    string salmon = "A salmon";
                    string dog = "A dog";
                    Console.WriteLine(pettyTheif);
                    Console.WriteLine(seaKing);
                    Console.WriteLine(smallVemonSnake);
                    Console.WriteLine(salmon);
                    Console.WriteLine(dog);
                    Console.ReadLine();
                }
                else if (userMenuInput == "7" || userMenuInput == "Exit")
                {
                    Console.WriteLine("Menu Closed");
                    Console.ReadLine();
                }
            }
            else if (userInitalInput == "Quit")
            {
                Console.WriteLine("Goodbye :)");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Invalid Input Please Try Again");
                Console.ReadLine();
            }
            

        }
    }
}
