
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

        private const double CPI = 0;
        private const double DRV_TUNER = 1.15;
        private const double TRN_TUNER = 1.0;
        private const double TURN_TOLERANCE = 1.0;

       // private const double VEH_WIDTH = ShelbyBot.BOT_WIDTH * TRN_TUNER;
        private const double WHL_DIAMETER = 6.6 * DRV_TUNER; //Diameter of the wheel (inches)
       // private const int ENCODER_CPR = ShelbyBot.ENCODER_CPR;
        private const double GEAR_RATIO = 1;                   //Gear ratio

        //private const double CIRCUMFERENCE = Math.PI * WHL_DIAMETER;
        //private const double CPI = ENCODER_CPR * GEAR_RATIO / CIRCUMFERENCE;
    
        private const double PADJ = 4.0;
        private const double PADJ_TURN = 0.0333;
        //private const double THRESH = Math.toRadians(0.004);
    }
   
}