using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using One_Piece_The_Pirate_Kings_Adventure_Class_Library;

/**
* Date 4/24/2023
*CSC 153
*David McCarthy
*This version creates arrays and list for the rooms, weapons, items, mobs, potions, and treasures
*/
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            One_Piece_The_Pirate_Kings_Adventure_Class_Library.WorldLoad.LoadWorld();
            One_Piece_The_Pirate_Kings_Adventure_Class_Library.One_Piece_The_Pirate_Kings_Adventure_Class.StartGame();
        }
    }
}
