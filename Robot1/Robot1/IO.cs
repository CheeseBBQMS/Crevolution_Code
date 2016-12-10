using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPILib;

namespace Robot1
{
    class IO
    {

        public Joystick driver_controller = new Joystick(Controllers.DRIVER_CONTROLLER),
                 operator_controller = new Joystick(Controllers.OPERATOR_CONTROLLER);
         
        public bool Joystick_Button(Joystick joystick, int button)
        {
            return (joystick.GetRawButton(button));
        }

        public Joystick getDriveStick()
        {
            return driver_controller;
        }

        public double Driver_Controller_Axes(int Axes)
        {
            return driver_controller.GetRawAxis(Axes);
        }
        public double Operator_Controller_Axes(int Axes)
        {
            return driver_controller.GetRawAxis(Axes);
        }
        public bool Driver_Controller_Button(int Button)
        {
            return driver_controller.GetRawButton(Button);
        }
        public bool Operator_Controller_Button(int Button)
        {
            return driver_controller.GetRawButton(Button);
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
            CHEA = 0,
           RIGHT_Y   = 1,
           LEFT_X    = 2,
           LEFT_Y    = 3;
    } 

  
}
