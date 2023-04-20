using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library.Menu
{
    class Treasure
    {
        public static bool DisplayTreasure()
        {
            bool showAgain = false;
            World.inputFile = File.OpenText("Treasures.txt");
            while (!World.inputFile.EndOfStream)
            {
                World.treasureID = World.inputFile.ReadLine();
                World.treasure1 = World.inputFile.ReadLine();
                World.treasureDesc = World.inputFile.ReadLine();
                World.treasureID2 = World.inputFile.ReadLine();
                World.treasure2 = World.inputFile.ReadLine();
                World.treasureDesc2 = World.inputFile.ReadLine();
                World.treasureID3 = World.inputFile.ReadLine();
                World.treasure3 = World.inputFile.ReadLine();
                World.treasureDesc3 = World.inputFile.ReadLine();

                Console.WriteLine(World.treasureID);
                Console.WriteLine(World.treasure1);
                Console.WriteLine(World.treasureDesc);
                Console.WriteLine(World.treasureID2);
                Console.WriteLine(World.treasure2);
                Console.WriteLine(World.treasureDesc2);
                Console.WriteLine(World.treasureID3);
                Console.WriteLine(World.treasure3);
                Console.WriteLine(World.treasureDesc3);
                showAgain = true;
            }
            World.inputFile.Close();
            return showAgain;
        }
    }
}
