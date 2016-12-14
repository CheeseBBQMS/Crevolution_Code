using System;
using WPILib;

namespace Robot1
{
    class IO
    {
        private Joystick selectController;

        public bool controllerButton(Joystick joystick, int button)
        {
            selectController = joystick;
            return (selectController.GetRawButton(button));
        }

        public double controllerJoystick(Joystick joystick, int axes )
        {
            selectController = joystick;
            return (selectController.GetRawAxis(axes));
        }

        public double shape(double inValue)
        {
            inputActive = (Math.Abs(inValue) > 0.1);
            inputSlow = (Math.Abs(inValue) < 0.8);

            double sign = Math.Sign(inValue);
            if (inputActive)
            {
                if (inputSlow)
                {
                    double output = sign * (Math.Abs(inValue));
                    return output;
                }
                else
                {
                    double output = sign * (Math.Abs(inValue));
                    return output;
                }
            }
            else
            {
                return 0;
            }

        }
   
        public const int
           X_Button = 1,
           A_Button = 2,
           Y_Button = 3,
           B_Button = 0,
           L_Bummber = 0,
           R_Bummber = 0,
           L_Trigger = 7,
           R_Trigger = 8,
           L_Stick_Button = 0,
           R_Stick_Button = 0,
           Back = 0,
           Start = 0,
           DPAD_UP = 0,
           DPAD_DOWN = 0,
           DPAD_RIGHT = 0,
           DPAD_LEFT = 0,
           RIGHT_X   = 0,
           RIGHT_Y   = 1,
           LEFT_X    = 2,
           LEFT_Y    = 3;

        private bool inputActive;
        private bool inputSlow;
    } 

  
}
