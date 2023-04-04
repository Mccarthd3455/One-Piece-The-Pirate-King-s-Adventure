using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library
{
    class InitalMenu
    {
        public static void DisplayInitalMenu()
        {
            Console.WriteLine("To open menu type Menu or type Quit to quit the program.");
        }
        public static string userInitalMenuInput()
        {
        
            string userInitalInput = Console.ReadLine();
            return userInitalInput;
        }

    }
}
