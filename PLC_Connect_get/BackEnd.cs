using S7.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
namespace PLC_Connect_get
{
    public struct read_datablock
    {
        public short mode; //0.0
        public bool start;      //2.0
        public bool stop;
        public bool runcondition;
        public bool stopcondition;
        public bool interlock;
        public bool runfeedback;
        public bool reset;
 
        public bool temp1;
        public byte temp2; //3.0

        public bool CMD;            //4.0
        public bool FAULT;

        public bool t2;
        public bool t3;
        public bool t4;
        public bool t5;
        public bool t6;
        public bool t7;


        public byte temp3; // 5.0

        public UInt32 rr; // 6.0
        public Int32 PT; 
        public Int32 ET;
        public bool t21; // 18.0
        public bool IN;
        public bool Q;
        public bool t32;
        public bool t43;
        public bool t53;
        public bool t63;
        public bool t73;
    }
    //public double[] balance = new double[10];
    public struct write_datablock
    {
        public short mode; //0.0
        public bool start;      //2.0
        public bool stop;
        public bool runcondition;
        public bool stopcondition;
        public bool interlock;
        public bool runfeedback;
        public bool reset;

        public bool temp1;
        public byte temp2; //3.0

        public bool CMD;            //4.0
        public bool FAULT;

        public bool t2;
        public bool t3;
        public bool t4;
        public bool t5;
        public bool t6;
        public bool t7;


        public byte temp3; // 5.0

        public UInt32 rr; // 6.0
        public Int32 PT;
        public Int32 ET;
        public bool t21; // 18.0
        public bool IN;
        public bool Q;
        public bool t32;
        public bool t43;
        public bool t53;
        public bool t63;
        public bool t73;
    }
    class Timer_read
    {
        public void WriteTask(Plc plc)
        {
            if (writeFlag.writeM1_Flag == true)
            {

                write_datablock DB1_write = new write_datablock();
                DB1_write.mode = write_motor1.mode;
                DB1_write.start = write_motor1.start;
                DB1_write.stop = write_motor1.stop;
                plc.WriteStruct(DB1_write, 1, 0);
                writeFlag.writeM1_Flag = false;
            }

            if (writeFlag.writeM2_Flag == true)
            {

                write_datablock DB1_write = new write_datablock();
                DB1_write.mode = write_motor2.mode;
                DB1_write.start = write_motor2.start;
                DB1_write.stop = write_motor2.stop;
                plc.WriteStruct(DB1_write, 2, 0);
                writeFlag.writeM2_Flag = false;
            }

            if (writeFlag.writeV_Flag == true)
            {

                write_datablock DB1_write = new write_datablock();
                DB1_write.mode = write_valve.mode;
                DB1_write.start = write_valve.start;
                DB1_write.stop = write_valve.stop;
                plc.WriteStruct(DB1_write, 3, 0);
                writeFlag.writeV_Flag = false;
            }
            if (writeFlag.writeMode_Flag == true)
            {
                if (global_mode.Global_mode == 2)
                {
                    plc.Write("M101.4", global_mode.START);
                    plc.Write("M101.5", global_mode.STOP);
                }
                plc.Write("MW103", global_mode.Global_mode);
                writeFlag.writeMode_Flag = false;
            }
        }
        public void ReadTask(Plc plc)
        {
            
            level_bar.level = (ushort)plc.Read("MW3"); ;
        }
        public void updateReadWrite()
        {
            write_motor1.mode = motor1_status.mode;
            write_motor1.start = motor1_status.start;
            write_motor1.stop = motor1_status.stop;
            write_motor1.CMD = motor1_status.CMD;
            write_motor1.FAULT = motor1_status.FAULT;
            write_motor1.runfeedback = motor1_status.runfeedback;
            write_motor1.PT = motor1_status.PT;
            write_motor1.ET = motor1_status.ET;
            write_motor1.IN = motor1_status.IN;
            write_motor1.Q = motor1_status.Q;
            write_motor2.mode = motor2_status.mode;
            write_motor2.start = motor2_status.start;
            write_motor2.stop = motor2_status.stop;
            write_motor2.CMD = motor2_status.CMD;
            write_motor2.FAULT = motor2_status.FAULT;
            write_motor2.runfeedback = motor2_status.runfeedback;
            write_motor2.PT = motor2_status.PT;
            write_motor2.ET = motor2_status.ET;
            write_motor2.IN = motor2_status.IN;
            write_motor2.Q = motor2_status.Q;
            write_valve.mode = valve_status.mode;
            write_valve.start = valve_status.start;
            write_valve.stop = valve_status.stop;
            write_valve.CMD = valve_status.CMD;
            write_valve.FAULT = valve_status.FAULT;
            write_valve.runfeedback = valve_status.runfeedback;
            write_valve.PT = valve_status.PT;
            write_valve.ET = valve_status.ET;
            write_valve.IN = valve_status.IN;
            write_valve.Q = valve_status.Q;
        }
        public void updatePLC2ReadBlock(read_datablock DB1_mem, read_datablock DB2_mem, read_datablock DB3_mem)
        {

            //Data _ Motor 1
            motor1_status.mode = DB1_mem.mode;
            motor1_status.start = DB1_mem.start;
            motor1_status.stop = DB1_mem.stop;
            motor1_status.CMD = DB1_mem.CMD;
            motor1_status.FAULT = DB1_mem.FAULT;
            motor1_status.runfeedback = DB1_mem.runfeedback;
            motor1_status.PT = DB1_mem.PT;
            motor1_status.ET = DB1_mem.ET;
            motor1_status.IN = DB1_mem.IN;
            motor1_status.Q = DB1_mem.Q;
            //Data _ Motor 2
            motor2_status.mode = DB2_mem.mode;
            motor2_status.start = DB2_mem.start;
            motor2_status.stop = DB2_mem.stop;
            motor2_status.CMD = DB2_mem.CMD;
            motor2_status.FAULT = DB2_mem.FAULT;
            motor2_status.runfeedback = DB2_mem.runfeedback;
            motor2_status.PT = DB2_mem.PT;
            motor2_status.ET = DB2_mem.ET;
            motor2_status.IN = DB2_mem.IN;
            motor2_status.Q = DB2_mem.Q;
            //Data_Valve
            valve_status.mode = DB3_mem.mode;
            valve_status.start = DB3_mem.start;
            valve_status.stop = DB3_mem.stop;
            valve_status.CMD = DB3_mem.CMD;
            valve_status.FAULT = DB2_mem.FAULT;
            valve_status.runfeedback = DB3_mem.runfeedback;
            valve_status.PT = DB3_mem.PT;
            valve_status.ET = DB3_mem.ET;
            valve_status.IN = DB3_mem.IN;
            valve_status.Q = DB3_mem.Q;
        }
        private int ixx = 0;
        public void TimerCallback(Object o)
        {
            // Display the date/time when this method got called.
            using (var plc = new Plc(CpuType.S71500, "192.168.1.222", 0, 1))
            {
                plc.Open();
                //Write
                WriteTask(plc);
                ReadTask(plc);
                read_datablock DB1_mem = (read_datablock)plc.ReadStruct(typeof(read_datablock), 1, 0);
                read_datablock DB2_mem = (read_datablock)plc.ReadStruct(typeof(read_datablock), 2, 0);
                read_datablock DB3_mem = (read_datablock)plc.ReadStruct(typeof(read_datablock), 3, 0);
                short second = (short)((((Int32)(DB1_mem.PT / 1000)) % 3600) % 60);
                short ms = (short)(DB1_mem.PT % 1000);
                Console.WriteLine("Frame Data From Plc with IP address   " + plc.IP + ": Frame" + ixx);
                //Update PLC to Readblock
                updatePLC2ReadBlock(DB1_mem, DB2_mem, DB3_mem);
                //Console.WriteLine
                ushort glo = (ushort)plc.Read("MW103");
                //bool st =(bool)plc.R("M101.4");
                //bool sp=(bool)plc.Read("M101.5");
                Console.WriteLine("DB1 mode :" + DB1_mem.mode);
                Console.WriteLine("DB2 mode :" + DB2_mem.mode);
                Console.WriteLine("DB3 mode: " + DB3_mem.mode);
                Console.WriteLine("level: " + level_bar.level);
                Console.WriteLine("glo: " + glo);
                Console.WriteLine("DATA HAD BEEN UPDATED " + "\n\n");
                Console.WriteLine("-------------------------------------------------------------- ");
            
                //Update Readblock to Writeblock
                updateReadWrite();
                ixx = ixx + 1;
                plc.Close();
            }
        }
        
    }
    class Timer_write
    {
        private int ixx = 0;
        public void TimerCallback(Object o)
        {
            write_motor1.mode = motor1_status.mode;
            write_motor1.start = motor1_status.start;
            write_motor1.stop = motor1_status.stop;
            write_motor1.CMD = motor1_status.CMD;
            write_motor1.FAULT = motor1_status.FAULT;
            write_motor1.runfeedback = motor1_status.runfeedback;
            write_motor1.PT = motor1_status.PT;
            write_motor1.ET = motor1_status.ET;
            write_motor1.IN = motor1_status.IN;
            write_motor1.Q = motor1_status.Q;
        }
    }
    class BackEnd
    {
        //[STAThread]
        static void Main(string[] args)
        {
            //
            Timer_read timerread = new Timer_read();
            System.Threading.Timer t = new System.Threading.Timer(timerread.TimerCallback, null, 0, 1000);

            //Timer_write timerwrite = new Timer_write();
            //System.Threading.Timer tw = new System.Threading.Timer(timerwrite.TimerCallback, null, 0, 1000);
            //});
            //Form_get.Start();


            var Form_Motor1 = new Thread(() =>
            {
                FrMain form1 = new FrMain();                            
                form1.ShowDialog();

            });
            Form_Motor1.SetApartmentState(ApartmentState.STA);
            Form_Motor1.IsBackground = true;
            Form_Motor1.Start();



                while (Console.ReadKey().Key != ConsoleKey.Q)
                {

                    if (Console.ReadKey().Key == ConsoleKey.C)
                    {
                        var Form_Ma = new Thread(() =>
                        {
                            FrMain formx = new FrMain();
                            formx.ShowDialog();
                        });
                        Form_Ma.IsBackground = true;
                        Form_Ma.Start();
                    
                    }                     
                }

                
                


        }
        

    }
    
}
