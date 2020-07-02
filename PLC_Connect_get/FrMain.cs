using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PLC_Connect_get
{
    public partial class FrMain : Form
    {
        public FrMain()
        {
            InitializeComponent();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            //pictureBox1.Image = ;
            progressBar1.Value = level_bar.level;
            if (motor1_status.runfeedback == true)
            {
                pictureBox1.Image = Properties.Resources.motor_on;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.motor_off;
            }
            if (motor2_status.runfeedback == true)
            {
                pictureBox2.Image = Properties.Resources.motor_on;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.motor_off;
            }
            if (valve_status.runfeedback == true)
            {
                pictureBox3.Image = Properties.Resources.valve_on;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.valve_off;
            }
            if (comboBox1.SelectedValue == "Auto")
            {
                button1.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button2.Enabled = false;
            }
        }
            List<string> listItem;
        private void FrMain_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            listItem = new List<string>()
        {
            "Free","Manual","Auto","Service"
        };
            comboBox1.DataSource = listItem;

            pictureBox1.Image = Properties.Resources.motor_off;
            pictureBox2.Image = Properties.Resources.motor_off;
            pictureBox3.Image = Properties.Resources.valve_off;

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (comboBox1.SelectedValue)
            {
                case "Free":
                    global_mode.Global_mode = 0;
                    global_mode.modeM_Flag = false;
                    writeFlag.writeMode_Flag = true;
                    break;
                case "Manual":
                    global_mode.Global_mode = 1;
                    global_mode.modeM_Flag = true;
                    writeFlag.writeMode_Flag = true;

                    break;
                case "Auto":
                    global_mode.Global_mode = 2;
                    global_mode.modeM_Flag = true;
                    writeFlag.writeMode_Flag = true;
                    break;
                case "Service":
                    global_mode.Global_mode = 3;
                    global_mode.modeM_Flag = true;
                    writeFlag.writeMode_Flag = true;
                    break;
                default:
                    // code block
                    break;
            }
        }

            private void PictureBox1_Click(object sender, EventArgs e)
            {
                FrMotor1 frm1 = new FrMotor1();
                frm1.ShowDialog();
            }

            private void PictureBox2_Click(object sender, EventArgs e)
            {
                FrMotor2 frm2 = new FrMotor2();
                frm2.ShowDialog();
            }

            private void PictureBox3_Click(object sender, EventArgs e)
            {
                FrValve frv = new FrValve();
                frv.ShowDialog();
            }

            private void FrMain_FormClosing(object sender, FormClosingEventArgs e)
            {
                timer1.Enabled = false;
            }

            private void Label1_Click(object sender, EventArgs e)
            {

            }

            private void Label5_Click(object sender, EventArgs e)
            {

            }

            private void ProgressBar1_Click(object sender, EventArgs e)
            {

            }

            private void PictureBox4_Click(object sender, EventArgs e)
            {
                global_mode.START = true;
                global_mode.STOP = false;
                writeFlag.writeMode_Flag = true;
            }

            private void Button1_Click(object sender, EventArgs e)
            {

                    global_mode.START = true;
                    global_mode.STOP = false;
                    writeFlag.writeMode_Flag = true;

            }

            private void Button2_Click(object sender, EventArgs e)
            {

                    global_mode.START = false;
                    global_mode.STOP = true;
                    writeFlag.writeMode_Flag = true;
            }
    }
}
