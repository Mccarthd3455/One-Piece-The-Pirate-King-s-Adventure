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
        public static void DisplayRooms()
        {
            

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

                World.rooms[0] = World.room1;
                World.rooms[1] = World.room2;
                World.rooms[2] = World.room3;
                World.rooms[3] = World.room4;
                World.rooms[4] = World.room5;
                World.rooms[5] = World.room6;
                World.rooms[6] = World.room7;
                World.rooms[7] = World.room8;
                World.rooms[8] = World.room9;
                World.rooms[9] = World.room10;
                World.rooms[10] = World.room11;
                World.rooms[11] = World.room12;
                World.rooms[12] = World.room13;
                World.rooms[13] = World.room14;
                World.rooms[14] = World.room15;

                World.roomDescs[0] = World.roomDesc;
                World.roomDescs[1] = World.roomDesc2;
                World.roomDescs[2] = World.roomDesc3;
                World.roomDescs[3] = World.roomDesc4;
                World.roomDescs[4] = World.roomDesc5;
                World.roomDescs[5] = World.roomDesc6;
                World.roomDescs[6] = World.roomDesc7;
                World.roomDescs[7] = World.roomDesc8;
                World.roomDescs[8] = World.roomDesc9;
                World.roomDescs[9] = World.roomDesc10;
                World.roomDescs[10] = World.roomDesc11;
                World.roomDescs[11] = World.roomDesc12;
                World.roomDescs[12] = World.roomDesc13;
                World.roomDescs[13] = World.roomDesc14;
                World.roomDescs[14] = World.roomDesc15;
            }
            World.inputFile.Close();
        }
    }
}
