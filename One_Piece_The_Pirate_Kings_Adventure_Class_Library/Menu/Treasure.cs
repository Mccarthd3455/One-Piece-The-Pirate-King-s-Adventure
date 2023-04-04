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
            StreamReader inputFile;
            inputFile = File.OpenText("Treasure.csv");
            while (!inputFile.EndOfStream)
            {
                String id;
                String name;
                String description;
                String[] line;
                line = inputFile.ReadLine().Split(',');
                id = (line[0]);
                name = (line[1]);
                description = (line[2]);
                Console.WriteLine(id);
                Console.WriteLine(name);
                Console.WriteLine(description);
                showAgain = true;
            }
            inputFile.Close();
            return showAgain;
        }
    }
}
