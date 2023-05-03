using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library.Menu
{
    public static class Weapons
    {
        public static void DisplayWeapons()
        {
            World.inputFile = File.OpenText("Weapons.txt");
            while (!World.inputFile.EndOfStream)
            {
                World.weaponID = World.inputFile.ReadLine();
                World.weapon1 = World.inputFile.ReadLine();
                World.weaponDesc = World.inputFile.ReadLine();

                World.weaponID2 = World.inputFile.ReadLine();
                World.weapon2 = World.inputFile.ReadLine();
                World.weaponDesc2 = World.inputFile.ReadLine();

                World.weaponID3 = World.inputFile.ReadLine();
                World.weapon3 = World.inputFile.ReadLine();
                World.weaponDesc3 = World.inputFile.ReadLine();

                World.weaponID4 = World.inputFile.ReadLine();
                World.weapon4 = World.inputFile.ReadLine();
                World.weaponDesc4 = World.inputFile.ReadLine();

                World.weaponID5 = World.inputFile.ReadLine();
                World.weapon5 = World.inputFile.ReadLine();
                World.weaponDesc5 = World.inputFile.ReadLine();

                World.weaponID6 = World.inputFile.ReadLine();
                World.weapon6 = World.inputFile.ReadLine();
                World.weaponDesc6 = World.inputFile.ReadLine();

                World.weaponID7 = World.inputFile.ReadLine();
                World.weapon7 = World.inputFile.ReadLine();
                World.weaponDesc7 = World.inputFile.ReadLine();

                World.weaponID8 = World.inputFile.ReadLine();
                World.weapon8 = World.inputFile.ReadLine();
                World.weaponDesc8 = World.inputFile.ReadLine();

                World.weaponID9 = World.inputFile.ReadLine();
                World.weapon9 = World.inputFile.ReadLine();
                World.weaponDesc9 = World.inputFile.ReadLine();

                World.weaponID10 = World.inputFile.ReadLine();
                World.weapon10 = World.inputFile.ReadLine();
                World.weaponDesc10 = World.inputFile.ReadLine();

                World.weapons[0] = World.weapon1;
                World.weapons[1] = World.weapon2;
                World.weapons[2] = World.weapon3;
                World.weapons[3] = World.weapon4;
                World.weapons[4] = World.weapon5;
                World.weapons[5] = World.weapon6;
                World.weapons[6] = World.weapon7;
                World.weapons[7] = World.weapon8;
                World.weapons[8] = World.weapon9;
                World.weapons[9] = World.weapon10;

                //World.weaponDescs[0] = World.weaponDesc;
                //World.weaponDescs[1] = World.weaponDesc2;
                //World.weaponDescs[2] = World.weaponDesc3;
                //World.weaponDescs[3] = World.weaponDesc4;
                //World.weaponDescs[4] = World.weaponDesc5;
                //World.weaponDescs[5] = World.weaponDesc6;
                //World.weaponDescs[6] = World.weaponDesc7;
                //World.weaponDescs[7] = World.weaponDesc8;
                //World.weaponDescs[8] = World.weaponDesc9;
                //World.weaponDescs[9] = World.weaponDesc10;
            }
            World.inputFile.Close();
        }
    }
}
