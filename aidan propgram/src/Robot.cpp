#include "WPILib.h"


class Robot: public IterativeRobot
{

	CANTalon *FrontL, *FrontR, *RearL, *RearR, *Manipulator;
	Joystick *Driver;
	Joystick *Operator;


private:


	void RobotInit()
	{
		Operator = new Joystick(1);
		Driver = new Joystick(0);
		FrontL = new CANTalon(2);
		FrontR = new CANTalon(1);
		RearL = new CANTalon(3);
		RearR = new CANTalon(0);
		/**Manipulator = new CANTalon(0);*/
		/** Talon setup for Prototype 1 */




	}
	/**
	 * This autonomous (along with the chooser code above) shows how to select between different autonomous modes
	 * using the dashboard. The sendable chooser code works with the Java SmartDashboard. If you prefer the LabVIEW
	 * Dashboard, remove all of the chooser code and uncomment the GetString line to get the auto name from the text box
	 * below the Gyro
	 *
	 * You can add additional auto modes by adding additional comparisons to the if-else structure below with additional strings.
	 * If using the SendableChooser make sure to add them to the chooser code above as well.
	 */
	void AutonomousInit()
	{

	}

	void AutonomousPeriodic()
	{

	}

	void TeleopInit()
	{

	}

	void TeleopPeriodic()
	{
	while(IsOperatorControl() && IsEnabled())
		{
	//	FrontL->Set(.5*Driver->GetRawAxis(0)+.5*Driver->GetRawAxis(2));
		//FrontR->Set(.5*Driver->GetRawAxis(0)-.5*Driver->GetRawAxis(2));
		RearL->Set(.5*Driver->GetRawAxis(0)+.5*Driver->GetRawAxis(2));
		RearR->Set(.5*Driver->GetRawAxis(0)-.5*Driver->GetRawAxis(2));
		/**Manipulator->Set(.5*Operator->GetRawAxis(1));*/
		/** Takes axes value of driver's and operator's joysticks to recieve values that the motors will be set to.
		 *  Pushing left stick forward and backwards on driver controller causes all motors to move forward and backwards, respectively.
		 *  Pushing  right stick left on driver controller causes right motors to speed up making the robot turn left
		 *  Pushing right stick right on driver controller causes left motors to speed up making the robot turn right
		 *  Pushing left stick forward and backwards causes the arm to mover up and down, respectively.
		 */
		}
	}

	void TestPeriodic()
	{

	}
};

START_ROBOT_CLASS(Robot)
