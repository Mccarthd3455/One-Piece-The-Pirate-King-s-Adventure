using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library.Combat
{
    class DiceRoll
    {
        public static int randomNum1D12(Random rand)
        {
            string diceType = "1D12";
            string[] dice = diceType.Split('D');
            int amountOfDice = int.Parse(dice[0]);
            int maxNumberDice = int.Parse(dice[1]);
            int damage = 0;
            for (int i = 0; i < amountOfDice; i++)
            {
                damage = damage + rand.Next(maxNumberDice + 1);
            }
            return damage;
        }
    }
}
