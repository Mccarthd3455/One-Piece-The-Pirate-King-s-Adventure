using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library
{
    public class WorldLoad
    {
        public static void LoadWorld()
        {
            CreateRooms();
            CreateWeapons();
            CreateMobs();
            CreatePotions();
            CreateTreasures();
            CreateItems();
            ReadFiles();
        }

        public static void CreateItems()
        {
            World.outputFile = File.CreateText("Items.txt");
            World.outputFile.WriteLine("Item001");
            World.outputFile.WriteLine("Sea King's Shot");
            World.outputFile.WriteLine("Sea King's Shot is a drink that will give you (+25 Stamina)");
            World.outputFile.WriteLine("Item002");
            World.outputFile.WriteLine("Sea King's Steak");
            World.outputFile.WriteLine("Sea King's Steak is a food that gives you (+25 Stamina and +25 Health)");
            World.outputFile.WriteLine("Item003");
            World.outputFile.WriteLine("Sea King's Fish");
            World.outputFile.WriteLine("Sea King's Fish is a food that gives you (+15 Stamina and + 20 Health)");
            World.outputFile.WriteLine("Item004");
            World.outputFile.WriteLine("Garp's Energy Drink");
            World.outputFile.WriteLine("Garp's Energy Drink is a drink high in sugar and will give you a burst of energy (+50 Stamina)");
            World.outputFile.WriteLine("Item005");
            World.outputFile.WriteLine("Luffy's Chips");
            World.outputFile.WriteLine("Luffy's Chips is a bag of chips owned by the Future Pirate King Luffy but is only a snack (+10 health)");
            World.outputFile.Close();
        }

        public static void CreateRooms()
        {
            World.outputFile = File.CreateText("Rooms.txt");
            World.outputFile.WriteLine("Room001");
            World.outputFile.WriteLine("Enterance to the Sea King's Bar");
            World.outputFile.WriteLine("The enterance to the Sea King's Bar");
            World.outputFile.WriteLine("Room002");
            World.outputFile.WriteLine("Sea King's Bar Barroom");
            World.outputFile.WriteLine("The Barroom to the Sea King's Bar");
            World.outputFile.WriteLine("Room003");
            World.outputFile.WriteLine("Enterance to Garp's Grocery Store");
            World.outputFile.WriteLine("The enterance to Garp's Grocery Store");
            World.outputFile.WriteLine("Room004");
            World.outputFile.WriteLine("Garp's Grocery Store Storeroom");
            World.outputFile.WriteLine("The Storeroom of Garp's Grocery Store");
            World.outputFile.WriteLine("Room005");
            World.outputFile.WriteLine("Garp's Grocery Store StorageRoom");
            World.outputFile.WriteLine("The Storage Room of Garp's Grocery Store");
            World.outputFile.WriteLine("Room006");
            World.outputFile.WriteLine("Enterance Pirate King's Gym");
            World.outputFile.WriteLine("Enterance of Pirate King's Gym");
            World.outputFile.WriteLine("Room007");
            World.outputFile.WriteLine("Training Floor Pirate King's  Gym");
            World.outputFile.WriteLine("The training floor of Pirate King's Gym");
            World.outputFile.WriteLine("Room008");
            World.outputFile.WriteLine("Second floor Training floor of Pirate King's Gym");
            World.outputFile.WriteLine("The Second floor Training floor of Pirate King's Gym");
            World.outputFile.WriteLine("Room009");
            World.outputFile.WriteLine("Starter Island's Town Square");
            World.outputFile.WriteLine("The Town Square of Starter Island where every important building is.");
            World.outputFile.WriteLine("Room010");
            World.outputFile.WriteLine("Starter Island's Dock");
            World.outputFile.WriteLine("The Dock of Starter Island (use after completing Tutorial to start your adventure)");
            World.outputFile.WriteLine("Room011");
            World.outputFile.WriteLine("Theif Valley");
            World.outputFile.WriteLine("The valley that is home to many Thieves");
            World.outputFile.WriteLine("Room012");
            World.outputFile.WriteLine("Enterance to Chopper's Hospital");
            World.outputFile.WriteLine("The enterance to the World's Famous Chopper's Hospital");
            World.outputFile.WriteLine("Room013");
            World.outputFile.WriteLine("Chopper's Hospital Emergency Room");
            World.outputFile.WriteLine("Chopper's Hospital Emergency Room");
            World.outputFile.WriteLine("Room014");
            World.outputFile.WriteLine("Enterance to Nami's Bank");
            World.outputFile.WriteLine("The enterance to Nami's Bank");
            World.outputFile.WriteLine("Room015");
            World.outputFile.WriteLine("Nami's Bank VaultRoom");
            World.outputFile.WriteLine("Nami's Bank VaultRoom is where all the money of Starter Island is stored");
            World.outputFile.Close();
        }
        public static void CreateWeapons()
        {
            World.outputFile = File.CreateText("Weapons.txt");
            World.outputFile.WriteLine("Weapon001");
            World.outputFile.WriteLine("Rusty Dagger");
            World.outputFile.WriteLine("This Dagger has seen better days Stats: Damage : 15, Damage Type: Piercing");
            World.outputFile.WriteLine("Weapon002");
            World.outputFile.WriteLine("Rusty Cutlass");
            World.outputFile.WriteLine("This Cutlass has seen better days. Stats: Damage: 20, Damage Type: Piercing");
            World.outputFile.WriteLine("Weapon003");
            World.outputFile.WriteLine("Rusty Flintlock");
            World.outputFile.WriteLine("This Flintlock has seen better days. Stats: Damage 25, Damage Type: Piercing");
            World.outputFile.WriteLine("Weapon004");
            World.outputFile.WriteLine("Slingshot");
            World.outputFile.WriteLine("This slingshot is made from a branch from a tree and some rubber bands Stats: Damage: 10, Damage Type: Bludgeoning");
            World.outputFile.WriteLine("Weapon005");
            World.outputFile.WriteLine("SandSand Fruit");
            World.outputFile.WriteLine("This fruit allows the user to gain the powers of Sand Stats: Base Damage:  50 - 300, Damage Type: Piercing");
            World.outputFile.WriteLine("Weapon006");
            World.outputFile.WriteLine("FlameFlame Fruit");
            World.outputFile.WriteLine("This fruit allows the user to gain the powers of Fire Stats: Base Damage: 50 - 300, Damage type: Fire");
            World.outputFile.WriteLine("Weapon007");
            World.outputFile.WriteLine("WaterWater Fruit");
            World.outputFile.WriteLine("This fruit allows  the user to gain the powers of Water Stats: Base Damage: 50 - 300, Damage Type: Piercing");
            World.outputFile.WriteLine("Weapon008");
            World.outputFile.WriteLine("EarthEarth Fruit");
            World.outputFile.WriteLine("This fruit allows the user to gain the powers of the Earth (Rocks) Stats: Base Damage: 50 - 300, Damage Type: Bludgeoning");
            World.outputFile.WriteLine("Weapon009");
            World.outputFile.WriteLine("GasGas Fruit");
            World.outputFile.WriteLine("This fruit allows the user to gain the powers of Gas Stats: Base Damage: 50 - 300, Damage Type: Piercing");
            World.outputFile.WriteLine("Weapon010");
            World.outputFile.WriteLine("BufortBufort Fruit");
            World.outputFile.WriteLine("This fruit allows the user to control / gain the powers of a Storm: Base Damage: 50 - 300, Damage Type: Thunder");
            World.outputFile.Close();
        }
        public static void CreateTreasures()
        {
            World.outputFile = File.CreateText("Treasures.txt");
            World.outputFile.WriteLine("Treasure001");
            World.outputFile.WriteLine("Rusted Chest");
            World.outputFile.WriteLine("Loot: Common");
            World.outputFile.WriteLine("Treasure002");
            World.outputFile.WriteLine("Silver Chest");
            World.outputFile.WriteLine("Loot: Uncommon");
            World.outputFile.WriteLine("Treasure003");
            World.outputFile.WriteLine("Golden Chest");
            World.outputFile.WriteLine("Loot: Rare");
            World.outputFile.Close();
        }
        public static void CreateMobs()
        {
            World.outputFile = File.CreateText("Mobs.txt");
            World.outputFile.WriteLine("Mob001");
            World.outputFile.WriteLine("Petty Theif");
            World.outputFile.WriteLine("A very weak theif (75 health and 20 bludgeoning damage)");
            World.outputFile.WriteLine("Mob002");
            World.outputFile.WriteLine("Sea King");
            World.outputFile.WriteLine("A Very Strong and Large Sea King (1000 health and 400 piercing  damage)");
            World.outputFile.WriteLine("Mob003");
            World.outputFile.WriteLine("Small Vemonous Snake");
            World.outputFile.WriteLine("A baby snake (25 health 5 poison damage)");
            World.outputFile.WriteLine("Mob004");
            World.outputFile.WriteLine("Salmon");
            World.outputFile.WriteLine("A salmon is a good source of free food(20 health deals no damage");
            World.outputFile.WriteLine("Mob005");
            World.outputFile.WriteLine("Dog");
            World.outputFile.WriteLine("A very good companion (50 health and 10 piercing damage)");
            World.outputFile.WriteLine("Mob006");
            World.outputFile.WriteLine("Buff Bandit");
            World.outputFile.WriteLine("A very strong bandit (150 health and 40 piercing damage)");
            World.outputFile.WriteLine("Mob007");
            World.outputFile.WriteLine("Small Training Dummy");
            World.outputFile.WriteLine("Very useful for training. Has a small chance to hit back (100 health and 10 bludgeoning damage)");
            World.outputFile.WriteLine("Mob008");
            World.outputFile.WriteLine("Medium Training Dummy");
            World.outputFile.WriteLine("Very useful for training. Has a small chance to hit back (120 health and 15 bludgeoning damage)");
            World.outputFile.WriteLine("Mob009");
            World.outputFile.WriteLine("Large Training Dummy");
            World.outputFile.WriteLine("Very useful for training. Has a small chance to hit back (150 health and 20 bludgeoning damage)");
            World.outputFile.WriteLine("Mob010");
            World.outputFile.WriteLine("Boss Training Dummy");
            World.outputFile.WriteLine("Very useful for training. Legend has it this training dummy has a spirit of a warrior. It will hit back. (200 health and 30 bludgeoning damage)");
            World.outputFile.Close();
        }
        public static void CreatePotions()
        {
            World.outputFile = File.CreateText("Potions.txt");
            World.outputFile.WriteLine("Potion001");
            World.outputFile.WriteLine("Small Health Potion");
            World.outputFile.WriteLine("A small health potion heals 25 hp (+25 hp)");
            World.outputFile.WriteLine("Potion002");
            World.outputFile.WriteLine("Large Health Potion");
            World.outputFile.WriteLine("A large health potion heals 100 hp (+100 hp)");
            World.outputFile.Close();
        }
        public static void ReadFiles()
        {
           Rooms.DisplayRooms();
            Menu.Weapons.DisplayWeapons();
            Menu.Mobs.DisplayMobs();
            Menu.Potions.DisplayPotions();
            Menu.Treasure.DisplayTreasure();
            Menu.Items.DisplayItems();
        }
    }
}
