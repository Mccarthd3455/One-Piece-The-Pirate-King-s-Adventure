using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library.Menu
{
    public static class Potions
    {
        public static bool DisplayPotions()
        {
            bool showAgain = false;
            World.inputFile = File.OpenText("Potions.txt");
            while (!World.inputFile.EndOfStream)
            {
                World.potionID = World.inputFile.ReadLine();
                World.potion1 = World.inputFile.ReadLine();
                World.potionDesc = World.inputFile.ReadLine();

                World.potionID2 = World.inputFile.ReadLine();
                World.potion2 = World.inputFile.ReadLine();
                World.potionDesc2 = World.inputFile.ReadLine();

                Console.WriteLine(World.potionID);
                Console.WriteLine(World.potion1);
                Console.WriteLine(World.potionDesc);
                Console.WriteLine(World.potionID2);
                Console.WriteLine(World.potion2);
                Console.WriteLine(World.potionDesc2);
                showAgain = true;
            }
            World.inputFile.Close();
            return showAgain;
        }
    }
}
