﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library
{
    public class World
    {
        public static StreamWriter outputFile;
        public static StreamReader inputFile;
        public static int i = 0;
        public static int weaponCounter = 0;
        public static int potionCounter = 0;
        public static int treasureCounter = 0;
        public static int northCounter = 0;
        public static int southCounter;
        public static string userInput;
        public static string roomID, roomID2, roomID3, roomID4, roomID5, roomID6, roomID7, roomID8, roomID9, roomID10, roomID11, roomID12, roomID13, roomID14, roomID15;
        public static string room1, room2, room3, room4, room5, room6, room7, room8, room9, room10, room11, room12, room13, room14, room15;
        public static string roomDesc, roomDesc2, roomDesc3, roomDesc4, roomDesc5, roomDesc6, roomDesc7, roomDesc8, roomDesc9, roomDesc10, roomDesc11, roomDesc12, roomDesc13, roomDesc14, roomDesc15;
        public static string weaponID, weaponID2, weaponID3, weaponID4, weaponID5, weaponID6, weaponID7, weaponID8, weaponID9, weaponID10;
        public static string weapon1, weapon2, weapon3, weapon4, weapon5, weapon6, weapon7, weapon8, weapon9, weapon10;
        public static string weaponDesc, weaponDesc2, weaponDesc3, weaponDesc4, weaponDesc5, weaponDesc6, weaponDesc7, weaponDesc8, weaponDesc9, weaponDesc10;
        public static string mobID, mobID2, mobID3, mobID4, mobID5, mobID6, mobID7, mobID8, mobID9, mobID10;
        public static string mob1, mob2, mob3, mob4, mob5, mob6, mob7, mob8, mob9, mob10;
        public static string mobDesc, mobDesc2, mobDesc3, mobDesc4, mobDesc5, mobDesc6, mobDesc7, mobDesc8, mobDesc9, mobDesc10;
        public static string potionID, potionID2;
        public static string potion1, potion2;
        public static string potionDesc, potionDesc2;
        public static string treasureID, treasureID2, treasureID3;
        public static string treasure1, treasure2, treasure3;
        public static string treasureDesc, treasureDesc2, treasureDesc3;
        public static string itemID, itemID2, itemID3, itemID4, itemID5;
        public static string item1, item2, item3, item4, item5;
        public static string itemDesc, itemDesc2, itemDesc3, itemDesc4, itemDesc5;
        public static List<CreateRooms.Room> rooms = new List<CreateRooms.Room>();
        public static List<string> weapons = new List<string>();
        public static List<string> potions = new List<string>();
        public static List<string> treasures = new List<string>();
        public static List<string> items = new List<string>();
        public static List<string> mobs = new List<string>();

        public static bool showAgain = false;
    }
}
