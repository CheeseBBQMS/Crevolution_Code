
using WPILib;

namespace Robot1
{
    class IO
    {

        private Joystick driverController = new Joystick(controllers.DRIVER_CONTROLLER),
                        operatorController = new Joystick(controllers.OPERATOR_CONTROLLER);
         
        public bool Joystick_Button(Joystick joystick, int button)
        {
            return (joystick.GetRawButton(button));
        }

        public Joystick getDriveStick()
        {
            return driverController;
        }

        public double driverControllerAxes(int Axes)
        {
            return driverController.GetRawAxis(Axes);
        }

        public double operatorControllerAxes(int Axes)
        {
            return operatorController.GetRawAxis(Axes);
        }

        public bool driverControllerButton(int Button)
        {
            return driverController.GetRawButton(Button);
        }

        public bool operatorControllerButton(int Button)
        {
            return operatorController.GetRawButton(Button);
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
    } 

  
}
