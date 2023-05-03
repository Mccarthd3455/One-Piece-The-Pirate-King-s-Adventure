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
        public static void DisplayPotions()
        {
            World.inputFile = File.OpenText("Potions.txt");
            while (!World.inputFile.EndOfStream)
            {
                World.potionID = World.inputFile.ReadLine();
                World.potion1 = World.inputFile.ReadLine();
                World.potionDesc = World.inputFile.ReadLine();

                World.potionID2 = World.inputFile.ReadLine();
                World.potion2 = World.inputFile.ReadLine();
                World.potionDesc2 = World.inputFile.ReadLine();

                World.potions[0] = World.potion1;
                World.potions[1] = World.potion2;

                //World.potionDescs[0] = World.potionDesc;
                //World.potionDescs[1] = World.potionDesc2;
            }
            World.inputFile.Close();
        }
    }
}
