using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library.Menu
{
    public static class Rooms
    {
        public static bool DisplayRooms()
        {
            bool showAgain = false;

            World.inputFile = File.OpenText("Rooms.txt");
            while (!World.inputFile.EndOfStream)
            {
                World.roomID = World.inputFile.ReadLine();
                World.room1 = World.inputFile.ReadLine();
                World.roomDesc = World.inputFile.ReadLine();

                World.roomID2 = World.inputFile.ReadLine();
                World.room2 = World.inputFile.ReadLine();
                World.roomDesc2 = World.inputFile.ReadLine();

                World.roomID3 = World.inputFile.ReadLine();
                World.room3 = World.inputFile.ReadLine();
                World.roomDesc3 = World.inputFile.ReadLine();

                World.roomID4 = World.inputFile.ReadLine();
                World.room4 = World.inputFile.ReadLine();
                World.roomDesc4 = World.inputFile.ReadLine();

                World.roomID5 = World.inputFile.ReadLine();
                World.room5 = World.inputFile.ReadLine();
                World.roomDesc5 = World.inputFile.ReadLine();

                World.roomID6 = World.inputFile.ReadLine();
                World.room6 = World.inputFile.ReadLine();
                World.roomDesc6 = World.inputFile.ReadLine();

                World.roomID7 = World.inputFile.ReadLine();
                World.room7 = World.inputFile.ReadLine();
                World.roomDesc7 = World.inputFile.ReadLine();

                World.roomID8 = World.inputFile.ReadLine();
                World.room8 = World.inputFile.ReadLine();
                World.roomDesc8 = World.inputFile.ReadLine();

                World.roomID9 = World.inputFile.ReadLine();
                World.room9 = World.inputFile.ReadLine();
                World.roomDesc9 = World.inputFile.ReadLine();

                World.roomID10 = World.inputFile.ReadLine();
                World.room10 = World.inputFile.ReadLine();
                World.roomDesc10 = World.inputFile.ReadLine();

                World.roomID11 = World.inputFile.ReadLine();
                World.room11 = World.inputFile.ReadLine();
                World.roomDesc11 = World.inputFile.ReadLine();

                World.roomID12 = World.inputFile.ReadLine();
                World.room12 = World.inputFile.ReadLine();
                World.roomDesc12 = World.inputFile.ReadLine();

                World.roomID13 = World.inputFile.ReadLine();
                World.room13 = World.inputFile.ReadLine();
                World.roomDesc13 = World.inputFile.ReadLine();

                World.roomID14 = World.inputFile.ReadLine();
                World.room14 = World.inputFile.ReadLine();
                World.roomDesc14 = World.inputFile.ReadLine();

                World.roomID15 = World.inputFile.ReadLine();
                World.room15 = World.inputFile.ReadLine();
                World.roomDesc15 = World.inputFile.ReadLine();

                Console.WriteLine(World.roomID);
                Console.WriteLine(World.room1);
                Console.WriteLine(World.roomDesc);

                Console.WriteLine(World.roomID2);
                Console.WriteLine(World.room2);
                Console.WriteLine(World.roomDesc2);

                Console.WriteLine(World.roomID3);
                Console.WriteLine(World.room3);
                Console.WriteLine(World.roomDesc3);

                Console.WriteLine(World.roomID4);
                Console.WriteLine(World.room4);
                Console.WriteLine(World.roomDesc4);

                Console.WriteLine(World.roomID5);
                Console.WriteLine(World.room5);
                Console.WriteLine(World.roomDesc5);

                Console.WriteLine(World.roomID6);
                Console.WriteLine(World.room6);
                Console.WriteLine(World.roomDesc6);

                Console.WriteLine(World.roomID7);
                Console.WriteLine(World.room7);
                Console.WriteLine(World.roomDesc7);

                Console.WriteLine(World.roomID8);
                Console.WriteLine(World.room8);
                Console.WriteLine(World.roomDesc8);

                Console.WriteLine(World.roomID9);
                Console.WriteLine(World.room9);
                Console.WriteLine(World.roomDesc9);

                Console.WriteLine(World.roomID10);
                Console.WriteLine(World.room10);
                Console.WriteLine(World.roomDesc10);

                Console.WriteLine(World.roomID11);
                Console.WriteLine(World.room11);
                Console.WriteLine(World.roomDesc11);

                Console.WriteLine(World.roomID12);
                Console.WriteLine(World.room12);
                Console.WriteLine(World.roomDesc12);

                Console.WriteLine(World.roomID13);
                Console.WriteLine(World.room13);
                Console.WriteLine(World.roomDesc13);

                Console.WriteLine(World.roomID14);
                Console.WriteLine(World.room14);
                Console.WriteLine(World.roomDesc14);

                Console.WriteLine(World.roomID15);
                Console.WriteLine(World.room15);
                Console.WriteLine(World.roomDesc15);



                showAgain = true;
            }
            World.inputFile.Close();
            return showAgain;
        }
    }
}
