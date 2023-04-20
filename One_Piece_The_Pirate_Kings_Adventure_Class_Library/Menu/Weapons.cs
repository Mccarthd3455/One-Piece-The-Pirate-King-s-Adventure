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
        public static bool DisplayWeapons()
        {
            bool showAgain = false;
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

                Console.WriteLine(World.weaponID);
                Console.WriteLine(World.weapon1);
                Console.WriteLine(World.weaponDesc);

                Console.WriteLine(World.weaponID2);
                Console.WriteLine(World.weapon2);
                Console.WriteLine(World.weaponDesc2);

                Console.WriteLine(World.weaponID3);
                Console.WriteLine(World.weapon3);
                Console.WriteLine(World.weaponDesc3);

                Console.WriteLine(World.weaponID4);
                Console.WriteLine(World.weapon4);
                Console.WriteLine(World.weaponDesc4);

                Console.WriteLine(World.weaponID5);
                Console.WriteLine(World.weapon5);
                Console.WriteLine(World.weaponDesc5);

                Console.WriteLine(World.weaponID6);
                Console.WriteLine(World.weapon6);
                Console.WriteLine(World.weaponDesc6);

                Console.WriteLine(World.weaponID7);
                Console.WriteLine(World.weapon7);
                Console.WriteLine(World.weaponDesc7);

                Console.WriteLine(World.weaponID8);
                Console.WriteLine(World.weapon8);
                Console.WriteLine(World.weaponDesc8);

                Console.WriteLine(World.weaponID9);
                Console.WriteLine(World.weapon9);
                Console.WriteLine(World.weaponDesc9);

                Console.WriteLine(World.weaponID10);
                Console.WriteLine(World.weapon10);
                Console.WriteLine(World.weaponDesc10);

                showAgain = true;
            }
            World.inputFile.Close();
            return showAgain;
        }
    }
}
