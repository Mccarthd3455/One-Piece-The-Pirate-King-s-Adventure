﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace One_Piece_The_Pirate_Kings_Adventure_Class_Library
{
    public static class Movement
    {
        public static void MovementCommands()
        {
            Console.WriteLine(World.rooms[0]);
            Console.WriteLine(World.roomDescs[0]);
            do
            {
                Menu.Rooms.DisplayRooms();
                World.userInput = newInput();
                if (World.userInput.ToLower() == "north" || World.userInput.ToLower() == "n")
                {
                    World.northCounter = World.i++;
                    if (World.i < World.rooms.Length)
                    {
                        Movement.MoveNorth();
                        Command.InitalUserInput.userInputCommand();
                        World.showAgain = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
                else if (World.userInput.ToLower() == "south" || World.userInput.ToLower() == "s")
                {
                    World.southCounter = World.northCounter--;
                    if (World.southCounter >= 0)
                    {
                        Movement.MoveSouth();
                        Command.InitalUserInput.userInputCommand();
                        World.showAgain = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
            }
            while (World.showAgain == true);
        }
        public static void MoveNorth()
        {
            Console.WriteLine(World.rooms[World.i]);
            Console.WriteLine(World.roomDescs[World.i]);
        }
        public static void MoveSouth()
        {
            Console.WriteLine(World.rooms[World.southCounter]);
            Console.WriteLine(World.roomDescs[World.southCounter]);
        }
        public static string newInput()
        {
            World.userInput = Console.ReadLine();
            return World.userInput;
        }

    }
}
