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
    public partial class FrMotor3 : Form
    {

        private bool pic1_button = true;
        private bool pic2_button = true;
        private bool pic3_button = true;
        public FrMotor3()
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
            pictureBox1.Image = Properties.Resources.On_Green;
            pictureBox2.Image = Properties.Resources.On_Yel;
            pictureBox3.Image = Properties.Resources.motor_off;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pic1_button = !pic1_button;
            if (pic1_button == true)
            {
                //pictureBox1.Image ;
            }
            else
            {

            }
        }

        private void PictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            pic2_button = !pic2_button;
            if (pic2_button == true)
            {
                //pictureBox1.Image ;
            }
            else
            {

            }
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
            if(motor2_status.start == true)
            {
                pictureBox1.Image = Properties.Resources.On_Green;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.Off_Green;
            }
            if (motor2_status.stop == true)
            {
                pictureBox2.Image = Properties.Resources.On_Red;
            }
            else
            {
                pictureBox2.Image = Properties.Resources.Off_Red;
            }
            if (motor2_status.runcondition == true)
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
    }
}
