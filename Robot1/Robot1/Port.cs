using System;
using WPILib;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot1{


 
    public class Controllers
   {
       public const byte DRIVER_CONTROLLER         = 0;
       public const byte OPERATOR_CONTROLLER       = 1;
   }


   public class Motor_CAN_Port 
   {
        //Values for Motor ports for Drive Train
           
           public const byte RIGHT_FRONT_PORT      = 0;
           public const byte RIGHT_REAR_PORT       = 1;
           public const byte LEFT_FRONT_PORT       = 2;
           public const byte LEFT_REAR_PORT        = 3;
           public const byte ARM_MOTOR             = 4;
           public const byte INTAKE_ROLLER         = 5;
    }

    public class Analog_Port
    {
           public const byte GYRO_1                = 0;
           public const byte GYRO_2                = 1;
           public const byte POTEIOMETER           = 2;
        
    }

    public class Digital_Port
    {
           public const byte LIMIT_SWTICH_1        = 0;
           public const byte LIMIT_SWITCH_2        = 1;
    }

    public class Robot
    {
        public CANTalon Right_Front_Motor,
                        Right_Rear_Motor,
                        Left_Front_Motor,
                        Left_Rear_Motor,
                        Intake_Roller,
                        Arm_Motor;

        public RobotDrive First_Peroson_Drive;

        public AnalogGyro Gyro;

        //Init for Robot
        public void Robot_init()
        {
            Right_Front_Motor = new CANTalon(Motor_CAN_Port.RIGHT_FRONT_PORT);
            Right_Rear_Motor = new CANTalon(Motor_CAN_Port.RIGHT_REAR_PORT);
            Left_Front_Motor = new CANTalon(Motor_CAN_Port.LEFT_FRONT_PORT);
            Left_Rear_Motor = new CANTalon(Motor_CAN_Port.LEFT_REAR_PORT);

            Intake_Roller = new CANTalon(Motor_CAN_Port.INTAKE_ROLLER);
            Arm_Motor = new CANTalon(Motor_CAN_Port.ARM_MOTOR);



            First_Peroson_Drive = new RobotDrive(Left_Front_Motor, Left_Rear_Motor,
                                                Right_Front_Motor, Right_Rear_Motor);

            First_Peroson_Drive.SetInvertedMotor(MotorType.FrontLeft, true);
            First_Peroson_Drive.SetInvertedMotor(MotorType.RearLeft, true);

            Gyro = new AnalogGyro(Analog_Port.GYRO_1);
        }

    }

}