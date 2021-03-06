﻿using System;
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
    public partial class FrMotor1 : Form
    {

        private bool pic1_button = true;
        private bool pic2_button = true;
        private bool pic3_button = true;
        public FrMotor1()
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
            comboBox1.SelectedIndex = motor1_status.mode;
            if(global_mode.modeM_Flag == true)
            {
                comboBox1.Enabled = false;
            }

            pictureBox1.Image = Properties.Resources.On_Green;
            pictureBox2.Image = Properties.Resources.On_Red;
            pictureBox3.Image = Properties.Resources.motor_off;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            write_motor1.start = true;
            write_motor1.stop = false;
            writeFlag.writeM1_Flag = true;
        }

        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            write_motor1.start = false;
            write_motor1.stop = true;
            writeFlag.writeM1_Flag = true;
        }

        private void PictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            pic3_button = !pic3_button;
            if (pic3_button == true)
            {
                 
            }
            else
            {

            }
        }

        private void FrMotor_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if(motor1_status.start == true)
            {
                pictureBox1.Image = Properties.Resources.Off_Green;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.On_Green;
            }
            if (motor1_status.stop == true)
            {
                pictureBox2.Image = Properties.Resources.Off_Red;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.On_Red;
            }
            if (motor1_status.runfeedback == true)
            {
                pictureBox3.Image = Properties.Resources.motor_on;
            }
            else
            {
                pictureBox3.Image = Properties.Resources.motor_off;
            }
            
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
           
        }
        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox1.SelectedValue)
            {
                case "Free":
                    {
                        write_motor1.mode = 0;
                        writeFlag.writeM1_Flag = true;
                    }
                break;
                case "Manual":
                    {
                        write_motor1.mode = 1;
                        writeFlag.writeM1_Flag = true;
                    }
                    break;
                case "Auto":
                    {
                        write_motor1.mode = 2;
                        writeFlag.writeM1_Flag = true;
                    }
                    break;
                case "Service":
                    {
                        write_motor1.mode = 3;
                        writeFlag.writeM1_Flag = true;
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
