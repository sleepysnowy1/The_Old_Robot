using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Old_Robot.Classes
{
    internal abstract class RobotCommand
    {
        public abstract void Run(Robot robot);
    }

    internal class OnCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {

            if (robot.IsPowered == false)
            {
                robot.IsPowered = true; 
            }
        }
    }

    internal class OffCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if(robot.IsPowered == true)
            {
                robot.IsPowered = false;
            }
        }
    }

    internal class NorthCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered == true)
            {
                robot.Y += 1; 
            }    
        }
    }

    internal class SouthCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered == true)
            {
                robot.Y += -1; 
            } 
        }
    }

    internal class WestCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered == true)    
            {
                robot.X += -1;
            }
        }
    }

    internal class EastCommand : RobotCommand
    {
        public override void Run(Robot robot)
        {
            if (robot.IsPowered == true)
            {
                robot.X += 1; 
            }
        }
    }
}
