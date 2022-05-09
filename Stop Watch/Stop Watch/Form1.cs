using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stop_Watch
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                private void label2_Click(object sender, EventArgs e)
        {
                    }
        //int value = 0;
        //int sec = 0;
        //int min = 0;
        //int hour = 0;

        int value, sec, min, hour = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {

            value += 5;
            mSeconds.Text = value.ToString();
            if(value == 100)
            {
                sec += 1;
                seconds.Text = sec.ToString();
                value = 0;
                // if(sec < 10)
                //{
                //   seconds.Text = 0 + sec.ToString();
                // }
                // else
                //{
                //  seconds.Text = sec.ToString();
                // }


            }
            else if (sec == 60)
            {
                min += 1;
                if (min < 10)
                {
                    minutes.Text = 0 + min.ToString();
                }
                else
                {
                    minutes.Text = min.ToString();
                }
                
                
                seconds.Text = "";
                sec = 0;
            }else if(min == 60)
            {
                hours.Text += 1;
                minutes.Text = "";
                min = 0;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            playPic.SendToBack();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            pausePic.SendToBack();
        }

        
        private void resetPic_Click(object sender, EventArgs e)
        {
            
            sec = 0;
            min = 0;
            seconds.Text = 0 + 0.ToString();
            minutes.Text = 0 + 0.ToString();
            mSeconds.Text = 0 + 0.ToString();
            hours.Text = "00";
            value = 00;
        }
    }
}
