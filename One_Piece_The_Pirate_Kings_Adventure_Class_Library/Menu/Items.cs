using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library.Menu
{
    class Items
    {
        public static bool DisplayItems()
        {
            bool showAgain = false;
            World.inputFile = File.OpenText("Items.txt");
            while (!World.inputFile.EndOfStream)
            {
                World.itemID = World.inputFile.ReadLine();
                World.item1 = World.inputFile.ReadLine();
                World.itemDesc = World.inputFile.ReadLine();

                World.itemID2 = World.inputFile.ReadLine();
                World.item2 = World.inputFile.ReadLine();
                World.itemDesc2 = World.inputFile.ReadLine();

                World.itemID3 = World.inputFile.ReadLine();
                World.item3 = World.inputFile.ReadLine();
                World.itemDesc3 = World.inputFile.ReadLine();

                World.itemID4 = World.inputFile.ReadLine();
                World.item4 = World.inputFile.ReadLine();
                World.itemDesc4 = World.inputFile.ReadLine();

                World.itemID5 = World.inputFile.ReadLine();
                World.item5 = World.inputFile.ReadLine();
                World.itemDesc5 = World.inputFile.ReadLine();

                Console.WriteLine(World.itemID);
                Console.WriteLine(World.item1);
                Console.WriteLine(World.itemDesc);

                Console.WriteLine(World.itemID2);
                Console.WriteLine(World.item2);
                Console.WriteLine(World.itemDesc2);

                Console.WriteLine(World.itemID3);
                Console.WriteLine(World.item3);
                Console.WriteLine(World.itemDesc3);
                
                Console.WriteLine(World.itemID3);
                Console.WriteLine(World.item3);
                Console.WriteLine(World.itemDesc3);

                Console.WriteLine(World.itemID4);
                Console.WriteLine(World.item4);
                Console.WriteLine(World.itemDesc4);

                Console.WriteLine(World.itemID5);
                Console.WriteLine(World.item5);
                Console.WriteLine(World.itemDesc5);
                Console.ReadLine();
            }
            World.inputFile.Close();
            return showAgain;
        }
    }
}
