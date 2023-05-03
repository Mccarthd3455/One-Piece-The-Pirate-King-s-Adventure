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
        public static void DisplayTreasure()
        {
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

                World.treasures[0] = World.treasure1;
                World.treasures[1] = World.treasure2;
                World.treasures[2] = World.treasure3;

                //World.treasureDescs[0] = World.treasureDesc;
                //World.treasureDescs[1] = World.treasureDesc2;
                //World.treasureDescs[2] = World.treasureDesc3;
            }
            World.inputFile.Close();

        }
    }
}
