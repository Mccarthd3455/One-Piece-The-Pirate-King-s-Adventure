using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library.Menu
{
    class Mobs
    {
        public static void DisplayMobs()
        { 
            World.inputFile = File.OpenText("Mobs.txt");
            while (!World.inputFile.EndOfStream)
            {
                World.mobID = World.inputFile.ReadLine();
                World.mob1 = World.inputFile.ReadLine();
                World.mobDesc = World.inputFile.ReadLine();

                World.mobID2 = World.inputFile.ReadLine();
                World.mob2 = World.inputFile.ReadLine();
                World.mobDesc2 = World.inputFile.ReadLine();

                World.mobID3 = World.inputFile.ReadLine();
                World.mob3 = World.inputFile.ReadLine();
                World.mobDesc3 = World.inputFile.ReadLine();

                World.mobID4 = World.inputFile.ReadLine();
                World.mob4 = World.inputFile.ReadLine();
                World.mobDesc4 = World.inputFile.ReadLine();

                World.mobID5 = World.inputFile.ReadLine();
                World.mob5 = World.inputFile.ReadLine();
                World.mobDesc5 = World.inputFile.ReadLine();

                World.mobID6 = World.inputFile.ReadLine();
                World.mob6 = World.inputFile.ReadLine();
                World.mobDesc6 = World.inputFile.ReadLine();

                World.mobID7 = World.inputFile.ReadLine();
                World.mob7 = World.inputFile.ReadLine();
                World.mobDesc7 = World.inputFile.ReadLine();

                World.mobID8 = World.inputFile.ReadLine();
                World.mob8 = World.inputFile.ReadLine();
                World.mobDesc8 = World.inputFile.ReadLine();

                World.mobID9 = World.inputFile.ReadLine();
                World.mob9 = World.inputFile.ReadLine();
                World.mobDesc9 = World.inputFile.ReadLine();

                World.mobID10 = World.inputFile.ReadLine();
                World.mob10 = World.inputFile.ReadLine();
                World.mobDesc10 = World.inputFile.ReadLine();

                World.mobs.Add(World.mob1);
                World.mobs.Add(World.mob2);
                World.mobs.Add(World.mob3);
                World.mobs.Add(World.mob4);
                World.mobs.Add(World.mob5);
                World.mobs.Add(World.mob6);
                World.mobs.Add(World.mob7);
                World.mobs.Add(World.mob8);
                World.mobs.Add(World.mob9);
                World.mobs.Add(World.mob10);
                
                //World.mobDescs.Add(World.mobDesc);
                //World.mobDescs.Add(World.mobDesc2);
                //World.mobDescs.Add(World.mobDesc3);
                //World.mobDescs.Add(World.mobDesc4);
                //World.mobDescs.Add(World.mobDesc5);
                //World.mobDescs.Add(World.mobDesc6);
                //World.mobDescs.Add(World.mobDesc7);
                //World.mobDescs.Add(World.mobDesc8);
                //World.mobDescs.Add(World.mobDesc9);
                //World.mobDescs.Add(World.mobDesc10);
            }
            World.inputFile.Close();

        }
    }
}
