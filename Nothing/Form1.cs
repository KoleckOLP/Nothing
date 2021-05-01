using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Nothing
{
    public partial class Form1 : Form
    {
        int clicks = 0;

        //start date
        private DateTime starttime;
        private string s_starttime;

        //1st click
        private DateTime firstclick;
        private string s_firstclick;

        //10th click
        private DateTime tenthclick;
        private string s_tenthclick;
        private TimeSpan tenthdiff;
        private string s_tenthdiff;

        //100th click
        private DateTime hundthclick;
        private string s_hundthclick;
        private TimeSpan hundthdiff;
        private string s_hundthdiff;

        //200th click
        private DateTime tuhundthclick;
        private string s_tuhundthclick;
        private TimeSpan tuhundthdiff;
        private string s_tuhundthdiff;

        //300th click
        private DateTime trhundthclick;
        private string s_trhundthclick;
        private TimeSpan trhundthdiff;
        private string s_trhundthdiff;

        //full time
        private TimeSpan finaldiff;
        private string s_finaldiff;

        public Form1()
        {
            InitializeComponent();
            label2.Text = clicks.ToString()+ "x";

            starttime = DateTime.Now;
            s_starttime = starttime.ToString("HH:mm:ss");

            label4.Text = s_starttime;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timeclicks()//11,12,13,14,15
        {
            if(clicks == 1){
                firstclick = DateTime.Now;
                s_firstclick = firstclick.ToString("HH:mm:ss");


                label11.Text = $"{s_firstclick}";
            }
            else if(clicks == 10)
            {
                tenthclick = DateTime.Now;
                s_tenthclick = tenthclick.ToString("HH:mm:ss");

                tenthdiff = tenthclick - firstclick;
                s_tenthdiff = tenthdiff.ToString(@"hh\:mm\:ss\.ff");

                label12.Text = $"{s_tenthclick} ({s_tenthdiff})";
            }
            else if (clicks == 100)
            {
                hundthclick = DateTime.Now;
                s_hundthclick = hundthclick.ToString("HH:mm:ss");

                hundthdiff = hundthclick - tenthclick;
                s_hundthdiff = hundthdiff.ToString(@"hh\:mm\:ss\.ff");

                label13.Text = $"{s_hundthclick} ({s_hundthdiff})";
            }
            else if (clicks == 200)
            {
                tuhundthclick = DateTime.Now;
                s_tuhundthclick = tuhundthclick.ToString("HH:mm:ss");

                tuhundthdiff = tuhundthclick - hundthclick;
                s_tuhundthdiff = tuhundthdiff.ToString(@"hh\:mm\:ss\.ff");

                label14.Text = $"{s_tuhundthclick} ({s_tuhundthdiff})";
            }
            else if (clicks == 300)
            {
                trhundthclick = DateTime.Now;
                s_trhundthclick = trhundthclick.ToString("HH:mm:ss");

                trhundthdiff = trhundthclick - tuhundthclick;
                s_trhundthdiff = trhundthdiff.ToString(@"hh\:mm\:ss\.ff");

                label15.Text = $"{s_trhundthclick} ({s_trhundthdiff})";

                finaldiff = trhundthclick - starttime;
                s_finaldiff = finaldiff.ToString(@"hh\:mm\:ss\.ff");

                label16.Text = $"({s_finaldiff})";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clicks++;
            label2.Text = clicks.ToString() + "x";
            timeclicks();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //was suposed to be restart
        private void clear()
        {
            label4.Text = DateTime.Now.ToString("hh:mm:ss");

            clicks = 0;
            label2.Text = clicks.ToString() + "x";
            label11.Text = "nic";
            label12.Text = "nic";
            label13.Text = "nic";
            label14.Text = "nic";
            label15.Text = "nic";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
