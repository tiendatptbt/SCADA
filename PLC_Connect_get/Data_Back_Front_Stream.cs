using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_Connect_get
{
    public static partial class motor1_status
    {
        public static short mode; //0.0
        public static bool start;      //2.0
        public static bool stop;
        public static bool runcondition;
        public static bool stopcondition;
        public static bool interlock;
        public static bool runfeedback;
        public static bool reset;

        public static bool temp1;
        public static byte temp2; //3.0

        public static bool CMD;            //4.0
        public static bool FAULT;

        public static bool t2;
        public static bool t3;
        public static bool t4;
        public static bool t5;
        public static bool t6;
        public static bool t7;


        public static byte temp3; // 5.0

        public static UInt32 rr; // 6.0
        public static Int32 PT;
        public static Int32 ET;
        public static bool t21; // 18.0
        public static bool IN;
        public static bool Q;
        public static bool t32;
        public static bool t43;
        public static bool t53;
        public static bool t63;
        public static bool t73;
    }

    public static partial class motor2_status
    {
        public static short mode; //0.0
        public static bool start;      //2.0
        public static bool stop;
        public static bool runcondition;
        public static bool stopcondition;
        public static bool interlock;
        public static bool runfeedback;
        public static bool reset;

        public static bool temp1;
        public static byte temp2; //3.0

        public static bool CMD;            //4.0
        public static bool FAULT;

        public static bool t2;
        public static bool t3;
        public static bool t4;
        public static bool t5;
        public static bool t6;
        public static bool t7;


        public static byte temp3; // 5.0

        public static UInt32 rr; // 6.0
        public static Int32 PT;
        public static Int32 ET;
        public static bool t21; // 18.0
        public static bool IN;
        public static bool Q;
        public static bool t32;
        public static bool t43;
        public static bool t53;
        public static bool t63;
        public static bool t73;
    }

    public static partial class valve_status
    {
        public static short mode; //0.0
        public static bool start;      //2.0
        public static bool stop;
        public static bool runcondition;
        public static bool stopcondition;
        public static bool interlock;
        public static bool runfeedback;
        public static bool reset;

        public static bool temp1;
        public static byte temp2; //3.0

        public static bool CMD;            //4.0
        public static bool FAULT;

        public static bool t2;
        public static bool t3;
        public static bool t4;
        public static bool t5;
        public static bool t6;
        public static bool t7;


        public static byte temp3; // 5.0

        public static UInt32 rr; // 6.0
        public static Int32 PT;
        public static Int32 ET;
        public static bool t21; // 18.0
        public static bool IN;
        public static bool Q;
        public static bool t32;
        public static bool t43;
        public static bool t53;
        public static bool t63;
        public static bool t73;
    }

    public static partial class write_motor1
    {
        public static short mode; //0.0
        public static bool start;      //2.0
        public static bool stop;
        public static bool runcondition;
        public static bool stopcondition;
        public static bool interlock;
        public static bool runfeedback;
        public static bool reset;

        public static bool temp1;
        public static byte temp2; //3.0

        public static bool CMD;            //4.0
        public static bool FAULT;

        public static bool t2;
        public static bool t3;
        public static bool t4;
        public static bool t5;
        public static bool t6;
        public static bool t7;


        public static byte temp3; // 5.0

        public static UInt32 rr; // 6.0
        public static Int32 PT;
        public static Int32 ET;
        public static bool t21; // 18.0
        public static bool IN;
        public static bool Q;
        public static bool t32;
        public static bool t43;
        public static bool t53;
        public static bool t63;
        public static bool t73;
    }
    public static partial class write_motor2
    {
        public static short mode; //0.0
        public static bool start;      //2.0
        public static bool stop;
        public static bool runcondition;
        public static bool stopcondition;
        public static bool interlock;
        public static bool runfeedback;
        public static bool reset;

        public static bool temp1;
        public static byte temp2; //3.0

        public static bool CMD;            //4.0
        public static bool FAULT;

        public static bool t2;
        public static bool t3;
        public static bool t4;
        public static bool t5;
        public static bool t6;
        public static bool t7;


        public static byte temp3; // 5.0

        public static UInt32 rr; // 6.0
        public static Int32 PT;
        public static Int32 ET;
        public static bool t21; // 18.0
        public static bool IN;
        public static bool Q;
        public static bool t32;
        public static bool t43;
        public static bool t53;
        public static bool t63;
        public static bool t73;
    }
    public static partial class write_valve
    {
        public static short mode; //0.0
        public static bool start;      //2.0
        public static bool stop;
        public static bool runcondition;
        public static bool stopcondition;
        public static bool interlock;
        public static bool runfeedback;
        public static bool reset;

        public static bool temp1;
        public static byte temp2; //3.0

        public static bool CMD;            //4.0
        public static bool FAULT;

        public static bool t2;
        public static bool t3;
        public static bool t4;
        public static bool t5;
        public static bool t6;
        public static bool t7;


        public static byte temp3; // 5.0

        public static UInt32 rr; // 6.0
        public static Int32 PT;
        public static Int32 ET;
        public static bool t21; // 18.0
        public static bool IN;
        public static bool Q;
        public static bool t32;
        public static bool t43;
        public static bool t53;
        public static bool t63;
        public static bool t73;
    }
    public static partial class writeFlag
    {
        public static bool writeM1_Flag = false;
        public static bool writeM2_Flag = false;
        public static bool writeV_Flag = false;
        public static bool writeMode_Flag = false;
    }
    public static partial class threadcontrol
    {   public static bool checkThr = false;
        public static bool checkThr_motor1 = false;
        public static bool checkThr_motor2 = false;
    }

    public static partial class global_mode
    {
        public static bool modeM_Flag = false;
        public static ushort Global_mode;
        public static bool START;
        public static bool STOP;
    }
    public static partial class level_bar
    {
        public static ushort level;
        

    }
}

