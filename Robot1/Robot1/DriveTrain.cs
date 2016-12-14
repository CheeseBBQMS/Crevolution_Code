
using WPILib;

namespace Robot1
{
public class DriveTrain
    {
    private CANTalon rightFrontMotor,
                     rightRearMotor,
                     leftFrontMotor,
                     leftRearMotor;

    private RobotDrive firstPerosonDrive;

    private AnalogGyro gyro;

    private Encoder leftEnc,
                    rightEnc;

    private enum Direction {Forward, Reverse};

    private const double CPI = 0;

    
    //use for testing 
    public void initMotors(CANTalon rightFront, CANTalon rightRear, CANTalon leftFront, CANTalon leftRear)
        {
            rightFrontMotor = rightFront;
            rightRearMotor = rightRear;
            leftFrontMotor = leftFront;
            leftRearMotor = leftRear;
        }

    public void init(RobotDrive robotDrvInit, AnalogGyro gyroInit, Encoder leftEncInit, Encoder rightEncInit)
        {
            firstPerosonDrive = robotDrvInit;
            gyro = gyroInit;
            leftEnc = leftEncInit;
            rightEnc = rightEncInit;
        }

    void turnToHeading(int heading) 
        {
        int currentH;
        int targetH;
        }

    void moveRobot(double lPwr, double rPwr)
        {
            firstPerosonDrive.SetLeftRightMotorOutputs(lPwr, rPwr);
        } 

    void stopRobot()
        {
            firstPerosonDrive.SetLeftRightMotorOutputs(0, 0);
        }

    void driveDistanceEncoder(double dst, double pwr, Direction dir)
        {
            int counts = distanceToCounts(dst);

            if (dir == Direction.Reverse)
            {
                counts *= 1;
            }
            int lft_target = leftEnc.GetRaw() + counts;
            int rgt_target = rightEnc.GetRaw() + counts;

            //while()
        }

    private int distanceToCounts(double distance)
        {
            return (int)(distance * CPI);
        }
    }
}