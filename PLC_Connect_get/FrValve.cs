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
    public partial class FrValve : Form
    {

        private bool pic1_button = true;
        private bool pic2_button = true;
        private bool pic3_button = true;
        public FrValve()
        {
            InitializeComponent();
        }


        List<string> listItem;
        private void FrMotor_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            listItem = new List<string>()
            {
                "Free","Manual","Auto","Service"
            };
            comboBox1.DataSource = listItem;
            comboBox1.SelectedIndex = valve_status.mode;
            if (global_mode.modeM_Flag == true)
            {
                comboBox1.Enabled = false;
            }
            pictureBox1.Image = Properties.Resources.On_Green;
            pictureBox2.Image = Properties.Resources.On_Red;
            pictureBox3.Image = Properties.Resources.valve_off;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            write_valve.start = true;
            write_valve.stop = false;
            writeFlag.writeV_Flag = true;
        }

        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            write_valve.start = false;
            write_valve.stop = true;
            writeFlag.writeV_Flag = true;
        }

        private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void FrMotor_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(valve_status.start == true)
            {
                pictureBox1.Image = Properties.Resources.Off_Green;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.On_Green;
            }
            if (valve_status.stop == true)
            {
                pictureBox2.Image = Properties.Resources.Off_Red;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.On_Red;
            }
            if (valve_status.runfeedback == true)
            {
                pictureBox3.Image = Properties.Resources.valve_on;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.valve_off;
            }

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedValue)
            {
                case "Free":
                    {
                    }
                    break;
                case "Manual":
                    {
                        write_valve.mode = 1;
                        writeFlag.writeV_Flag = true;
                    }
                    break;
                case "Auto":
                    {
                        write_valve.mode = 2;
                        writeFlag.writeV_Flag = true;
                    }
                    break;
                case "Service":
                    {
                        write_valve.mode = 3;
                        writeFlag.writeV_Flag = true;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
