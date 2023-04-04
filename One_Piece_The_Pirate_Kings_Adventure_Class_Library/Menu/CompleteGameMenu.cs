using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library.Menu
{
    public static class CompleteGameMenu
    {
        public static void gameMenu()
        {
            bool showAgain = true;
            do
            {
                One_Piece_The_Pirate_Kings_Adventure_Class_Library.InitalMenu.DisplayInitalMenu();
                string userInitalInput = One_Piece_The_Pirate_Kings_Adventure_Class_Library.InitalMenu.userInitalMenuInput();
                showAgain = One_Piece_The_Pirate_Kings_Adventure_Class_Library.MenuIfStatements.DisplayMenu(userInitalInput);
            } while (showAgain == true);
        }
    }
}
