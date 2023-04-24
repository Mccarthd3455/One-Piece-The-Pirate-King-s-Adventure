using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library.Command
{
    class HelpCommand
    {
        public static void Help()
        {
            Console.WriteLine("Movement:");
            Console.WriteLine("North or N");
            Console.WriteLine("South or S");
            Console.WriteLine("Display Arrays/List:");
            Console.WriteLine("Weapons");
            Console.WriteLine("Potions");
            Console.WriteLine("Treasures");
            Console.WriteLine("Items");
            Console.WriteLine("Mobs");

        }
    }
}
