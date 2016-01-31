#include "IterativeRobot.h"
#include "Joystick.h"
#include "CANTalon.h"
#include "RobotDrive.h"

class Robot: public IterativeRobot
{
private:
	LiveWindow *lw = LiveWindow::GetInstance();
	CANTalon  *rightfront, *rightrear, *leftfront, *leftrear, *armminipluator, *shro;
	Joystick *drivercontroller, *operatorcontroller;
	RobotDrive *fps;

	void RobotInit()
	{

	    drivercontroller = new Joystick(0);
	    operatorcontroller = new Joystick(1);
		rightfront = new CANTalon(4);
		rightrear = new CANTalon(3);
		leftfront = new CANTalon(2);
		leftrear = new CANTalon(1);
	    armminipluator = new CANTalon(0);
	    shro = new CANTalon(5);
	    fps = new  RobotDrive(rightfront, rightrear, leftfront, leftrear);

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
		while(1)
		{
			fps->SetLeftRightMotorOutputs(0.5*-drivercontroller->GetRawAxis(1) + drivercontroller->GetRawAxis(2), 0.5*-drivercontroller->GetRawAxis(1) - drivercontroller->GetRawAxis(2));
			if(operatorcontroller->GetRawAxis(1) > 0)
			{
				armminipluator->Set(0.6*operatorcontroller->GetRawAxis(1));
			}
			else if(operatorcontroller->GetRawAxis(1) < 0)
			{
				armminipluator->Set(0.3*operatorcontroller->GetRawAxis(1));
			}

			if(operatorcontroller->GetRawButton(5))
			{
				shro->Set(1);
			}
			else if(operatorcontroller->GetRawAxis(6))
			{
				shro->Set(-1);
			}
			else
			{
				shro->Set(0);
			}
		}
	}


	void TestPeriodic()
	{
		lw->Run();
	}
};

START_ROBOT_CLASS(Robot)
