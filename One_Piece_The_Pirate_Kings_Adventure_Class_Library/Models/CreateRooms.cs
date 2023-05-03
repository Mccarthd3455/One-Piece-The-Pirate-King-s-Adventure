using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library
{
    public class CreateRooms
    {
        public class Room
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public string Description { get; set; }
            public int Exit { get; set; }
            public Room()
            {

            }
           public Room(int ID, string Name, string Description, int Exit)
            {

            }
        }
    }
}
