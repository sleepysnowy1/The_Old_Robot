using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Old_Robot.Classes;

namespace The_Old_Robot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot MyRobot = new Robot();
            
            EastCommand eastCommand = new EastCommand();
            WestCommand westCommand = new WestCommand();
            NorthCommand northCommand = new NorthCommand();
            SouthCommand southCommand = new SouthCommand();
            OnCommand onCommand = new OnCommand();

            MyRobot.Commands[0] = onCommand;
            MyRobot.Commands[1] = westCommand;
            MyRobot.Commands[2] = northCommand;


            MyRobot.Run();

            Console.ReadLine(); 
        }
    }
}
