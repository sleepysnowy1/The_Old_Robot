using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Old_Robot.Classes
{


    internal class OnCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {

            if (robot.IsPowered == false)
            {
                robot.IsPowered = true; 
            }
        }
    }

    internal class OffCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if(robot.IsPowered == true)
            {
                robot.IsPowered = false;
            }
        }
    }

    internal class NorthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered == true)
            {
                robot.Y += 1; 
            }    
        }
    }

    internal class SouthCommand : IRobotCommand
    {
        public void Run(Robot robot)
        {
            if (robot.IsPowered == true)
            {
                robot.Y += -1; 
            } 
        }
    }

    internal class WestCommand : IRobotCommand
    {
        public  void Run(Robot robot)
        {
            if (robot.IsPowered == true)    
            {
                robot.X += -1;
            }
        }
    }

    internal class EastCommand : IRobotCommand
    {
        public  void Run(Robot robot)
        {
            if (robot.IsPowered == true)
            {
                robot.X += 1; 
            }
        }
    }
}
