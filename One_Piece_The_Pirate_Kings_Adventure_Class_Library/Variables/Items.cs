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

                World.items.Add(World.item1);
                World.items.Add(World.item2);
                World.items.Add(World.item3);
                World.items.Add(World.item4);
                World.items.Add(World.item5);

                World.itemDescs.Add(World.itemDesc);
                World.itemDescs.Add(World.itemDesc2);
                World.itemDescs.Add(World.itemDesc3);
                World.itemDescs.Add(World.itemDesc4);
                World.itemDescs.Add(World.itemDesc5);
            }
            World.inputFile.Close();
            return showAgain;
        }
    }
}
