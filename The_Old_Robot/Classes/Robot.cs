﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Old_Robot.Classes
{
    internal class Robot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsPowered { get; set; }
        public IRobotCommand[] Commands { get; } = new IRobotCommand[3];

        public void Run ()
        {
            foreach (IRobotCommand command in Commands)
            {
                command.Run (this);
                Console.WriteLine($"[{X} {Y} {IsPowered}");

            }
        }
    }
}
