using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library.Combat
{
    class CombatSystem
    {
        public static void combatSystem()
        {
            int userHP = 100;
            int enemyHP = 100;
            int roundCounter = 0;
            bool IsDead = false;
            Random rand = new Random();
            do
            {
                for (roundCounter = 1; userHP > 0 && enemyHP > 0; roundCounter++)
                {
                    int userDamageDealt = One_Piece_The_Pirate_Kings_Adventure_Class_Library.Combat.DiceRoll.randomNum1D12(rand);
                    int enemyDamageDealt = One_Piece_The_Pirate_Kings_Adventure_Class_Library.Combat.DiceRoll.randomNum1D12(rand);
                    userHP = userHP - enemyDamageDealt;
                    enemyHP = enemyHP - userDamageDealt;
                    Console.WriteLine("Round " + roundCounter);
                    Console.WriteLine("User Health: " + userHP);
                    Console.WriteLine("Enemy Health: " + enemyHP);
                    if (userHP <= 0)
                    {
                        Console.WriteLine("You Died in " + roundCounter + " rounds.");
                        IsDead = true;
                        Console.ReadLine();
                    }
                    if (enemyHP <= 0)
                    {
                        Console.WriteLine("The fight lasted " + roundCounter + " rounds.");
                        IsDead = true;
                        Console.ReadLine();
                    }
                }

            }
            while (IsDead == false);
        }
    }
}
