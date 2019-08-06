using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_AutomationSimulator
{
    public class Controller
    {
        public static double currentSpeed = 0;
        public static bool Passmiddle = false;
        public static Outputs Update(Inputs inputs)
        {

            Outputs a = new Outputs();
            if (inputs.PositioningEnabled)
            {
                currentSpeed = Configuration.MotorSpeedFast;
                a.MoveSpeed = currentSpeed;
                if (inputs.ProximitySensorMiddle)
                {
                    Passmiddle = true;
                }
                if (Passmiddle)
                {
                    currentSpeed = Configuration.MotorSpeedSlow;
                    a.MoveSpeed = currentSpeed;
                }
                if (inputs.ProximitySensorRight)
                {
                    currentSpeed = 0;
                    a.MoveSpeed = currentSpeed;
                }
                a.MoveRight = true;
            }
            else
            {
                
            }

            return a;

        }
    }
}
