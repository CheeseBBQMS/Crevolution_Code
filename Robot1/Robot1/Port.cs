using System;
using WPILib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot1{
 
    public class controllers
   {
        public const byte DRIVER_CONTROLLER         = 0;
        public const byte OPERATOR_CONTROLLER       = 1;
   }


   public class motorCAN
   {
        //Values for Motor ports for Drive Train
           
        public const byte RIGHT_FRONT_PORT      = 0;
        public const byte RIGHT_REAR_PORT       = 1;
        public const byte LEFT_FRONT_PORT       = 2;
        public const byte LEFT_REAR_PORT        = 3;
        public const byte ARM_MOTOR             = 4;
        public const byte INTAKE_ROLLER         = 5;
    }
    public class motorPWM
    {

    }

    public class analogPort
    {
        public const byte GYRO_1                = 0;
        public const byte GYRO_2                = 1;
        public const byte POTEIOMETER           = 2;
    }

    public class digitalPort
    {
        public const byte LIMIT_SWTICH_1        = 0;
        public const byte LIMIT_SWITCH_2        = 1;
        public const byte R_EN_1 = 3;
        public const byte R_EN_2 = 4;
        public const byte L_EN_1 = 5;
        public const byte L_EN_2 = 6;
    }

    public class Robot
    {
        public CANTalon rightFrontMotor,
                        rightRearMotor,
                        leftFrontMotor,
                        leftRearMotor,
                        intakeRoller,
                        armMotor;

        public RobotDrive firstPerosonDrive;

        public DigitalInput limitSwitch1,
                            limitSwitch2;

        public WPILib.Encoder rightEncoder,
                              leftEncoder;

        public AnalogGyro gyro;

        //Init for Robot
        public void Robot_init()
        {
            rightEncoder = new WPILib.Encoder(digitalPort.R_EN_1, digitalPort.R_EN_2);
            leftEncoder = new WPILib.Encoder(digitalPort.L_EN_1, digitalPort.L_EN_2);

            rightFrontMotor = new CANTalon(motorCAN.RIGHT_FRONT_PORT);
            rightRearMotor = new CANTalon(motorCAN.RIGHT_REAR_PORT);
            leftFrontMotor = new CANTalon(motorCAN.LEFT_FRONT_PORT);
            leftRearMotor = new CANTalon(motorCAN.LEFT_REAR_PORT);

            intakeRoller = new CANTalon(motorCAN.INTAKE_ROLLER);
            armMotor = new CANTalon(motorCAN.ARM_MOTOR);

            gyro = new AnalogGyro(analogPort.GYRO_1);

            firstPerosonDrive = new RobotDrive(leftFrontMotor, 
                                               leftRearMotor,
                                               rightFrontMotor, 
                                               rightRearMotor);

            firstPerosonDrive.SetInvertedMotor(MotorType.FrontLeft, true);
            firstPerosonDrive.SetInvertedMotor(MotorType.RearLeft, true);

        }

    }

}