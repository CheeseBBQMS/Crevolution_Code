
using WPILib;
using WPILib.SmartDashboard;


namespace Robot1
{
    /// <summary>
    /// The VM is configured to automatically run this class, and to call the
    /// functions corresponding to each mode, as described in the IterativeRobot
    /// documentation. 
    /// </summary>
    /// 
    public class Robot1 : IterativeRobot
    {
        enum Autons 
        {
          Move_Up,
          Left,
          Right, 
          Done,
          defaultAuto
        };

        double
              ON_FORWARD = 1,
              ON_REVERSE = -1,
              OFF = 0;


        const string defaultAuto = "Default";
        const string customAuto = "My Auto";
        //string autoSelected;
        int autoSelected;
        SendableChooser chooser;

       // IO    io = new IO();
        Robot rbt = new Robot();
        private Joystick driverController,
                         operatorController;
                         
        /// <summary>
        /// This function is run when the robot is first started up and should be
        /// used for any initialization code.
        /// </summary>
        public override void RobotInit()
        {
            chooser = new SendableChooser();
            chooser.AddDefault("Default Auto", defaultAuto);
            chooser.AddObject("My Auto", customAuto);
            SmartDashboard.PutData("Chooser", chooser);

            //Goes to the Robot Class to accesss the Accuator's ports on the robot
            rbt.Robot_init();

            driverController = new Joystick(controllers.DRIVER_CONTROLLER);
            operatorController = new Joystick(controllers.OPERATOR_CONTROLLER);

        }

        // This autonomous (along with the sendable chooser above) shows how to select between
        // different autonomous modes using the dashboard. The senable chooser code works with
        // the Java SmartDashboard. If you prefer the LabVIEW Dashboard, remove all the chooser
        // code an uncomment the GetString code to get the uto name from the text box below
        // the gyro.
        //You can add additional auto modes by adding additional comparisons to the switch
        // structure below with additional strings. If using the SendableChooser
        // be sure to add them to the chooser code above as well.
        public override void AutonomousInit()
        {
            
            //autoSelected = (string)chooser.GetSelected();
            //autoSelected = SmartDashboard.GetString("Auto Selector", defaultAuto);
            //Console.WriteLine("Auto selected: " + autoSelected);
        }

        /// <summary>
        /// This function is called periodically during autonomous
        /// </summary>
        public override void AutonomousPeriodic()
        {
            while (IsAutonomous && IsEnabled)
            {
                switch (autoSelected)
                {
                   // case customAuto:
                        //Put custom auto code here
                    //    break;

                    case (int)Autons.Move_Up:
                        {
                            break;
                        }

                    case (int)Autons.defaultAuto:
                    default:
                        //Put default auto code here
                        rbt.firstPerosonDrive.SetLeftRightMotorOutputs(0, 0);
                        break;
                }
            }
        }

        /// <summary>
        /// This function is called periodically during operator control
        /// </summary>
        /// 
        public override void TeleopInit()
        {
            

        }

        public override void TeleopPeriodic()
        {
            while (IsOperatorControl && IsEnabled)
            {
                double drvRight_Y = controllerJoystick(driverController, IO.LEFT_Y);
                double drvLeft_Y = io.controllerJoystick(driverController, IO.RIGHT_Y);

                double oprRight_Y = io.controllerJoystick(rbt.IO.RIGHT_Y)


                rbt.firstPerosonDrive.SetLeftRightMotorOutputs(drvLeft_Y, drvRight_Y);

                rbt.armMotor.Set(oprRight_Y);


                if (io.controllerButton(rbt.driverController, IO.R_Trigger))
                {
                    rbt.armMotor.Set(ON_FORWARD);
                }
                else if (io.controllerButton(rbt.driverController, IO.L_Trigger))
                {
                    rbt.armMotor.Set(ON_REVERSE);
                }
                else
                {
                    rbt.intakeRoller.Set(OFF);
                }
                Timer.Delay(0.01);
            }
        }

        /// <summary>
        /// This function is called periodically during test mode
        /// </summary>
        public override void TestPeriodic()
        {

        }
    }
}
