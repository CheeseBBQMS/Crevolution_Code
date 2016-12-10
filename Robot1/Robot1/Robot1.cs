using System;
using System.Collections.Generic;
using System.Linq;
using WPILib;
using WPILib.SmartDashboard;
using Robot1;


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

        IO    IO = new IO();
        Robot RB = new Robot();

        

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
            RB.Robot_init();

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
                        RB.First_Peroson_Drive.SetLeftRightMotorOutputs(0, 0);
                        break;
                }
            }
        }

        /// <summary>
        /// This function is called periodically during operator control
        /// </summary>
        public override void TeleopPeriodic()
        {
            while (IsOperatorControl && IsEnabled)
            {
                RB.First_Peroson_Drive.SetLeftRightMotorOutputs(IO.Driver_Controller_Axes(IO.RIGHT_Y), IO.Driver_Controller_Axes(IO.LEFT_Y));

                RB.Arm_Motor.Set(IO.Operator_Controller_Axes(IO.RIGHT_Y));


                if (IO.Driver_Controller_Button(IO.R_Trigger))
                {
                    RB.Arm_Motor.Set(ON_FORWARD);
                }
                else if (IO.Operator_Controller_Button(IO.L_Trigger))
                {
                    RB.Arm_Motor.Set(ON_REVERSE);
                }
                else
                {
                    RB.Intake_Roller.Set(OFF);
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
