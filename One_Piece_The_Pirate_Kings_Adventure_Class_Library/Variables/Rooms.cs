using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library
{
    public static class Rooms
    {
        public static void DisplayRooms()
        {
            using (StreamReader reader = File.OpenText(@"../../../../Docs/Rooms.csv"))
            {
                while (!reader.EndOfStream)
                {
                    string[] tokens = reader.ReadLine().Split(',');
                    World.rooms.Add(new CreateRooms.Room(int.Parse(tokens[0]), tokens[1], tokens[3], int.Parse(tokens[4])));
                }
            }
        }
    }
}
