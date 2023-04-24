using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library.Command
{
    class InitalUserInput
    {
        public static void userInputCommand()
        {
            Console.WriteLine("Type Help to get a list of commands");
            do
            {
                World.userInput = Movement.newInput();
                if (World.userInput.ToLower() == "help")
                {
                    Command.HelpCommand.Help();
                    World.showAgain = true;
                }
                else if (World.userInput.ToLower() == "north" || World.userInput.ToLower() == "n" || World.userInput.ToLower() == "south" || World.userInput.ToLower() == "s")
                {
                    Movement.MovementCommands();
                    World.showAgain = true;
                }
                else if (World.userInput.ToLower() == "weapons" || World.userInput == "Weapons")
                {
                    DisplayCommands.WeaponsCommand();
                    World.showAgain = true;
                }
                else if (World.userInput.ToLower() == "potions" || World.userInput == "Potions")
                {
                    DisplayCommands.PotionsCommand();
                    World.showAgain = true;
                }
                else if (World.userInput.ToLower() == "treasures" || World.userInput == "Treasures")
                {
                    DisplayCommands.TreasureCommand();
                    World.showAgain = true;
                }
                else if (World.userInput.ToLower() == "items" || World.userInput == "Items")
                {
                    DisplayCommands.ItemCommand();
                    World.showAgain = true;
                }
                else if (World.userInput.ToLower() == "mobs" || World.userInput == "Mobs")
                {
                    DisplayCommands.MobsCommand();
                    World.showAgain = true;
                }
                else if (World.userInput.ToLower() == "combat" || World.userInput == "Combat")
                {
                    Combat.CombatSystem.combatSystem();
                    World.showAgain = true;
                }
            }
            while (World.showAgain == true);
        }
    }
}
