using System;
using System.Windows.Forms;

namespace Nothing
{
    public partial class Form1 : Form
    {
        private int clicks = 0;

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

        public Form1() // initialize
        {
            InitializeComponent();
            label2.Text = clicks.ToString()+ "x";

            starttime = DateTime.Now;
            s_starttime = starttime.ToString("HH:mm:ss");

            label4.Text = s_starttime;
        }

        private void timeclicks() // called on every click of the Big Nothing button
        {
            if(clicks == 1){
                firstclick = DateTime.Now;
                s_firstclick = firstclick.ToString("HH:mm:ss");


                label11.Text = $"{s_firstclick}";
            }
            else if(clicks == 10)
            {
                tenthclick = DateTime.Now; // gets curent time
                s_tenthclick = tenthclick.ToString("HH:mm:ss"); // makes sring out of it

                tenthdiff = tenthclick - firstclick; // gets diference between 10th and 1st click time
                s_tenthdiff = tenthdiff.ToString(@"hh\:mm\:ss\.ff"); // makes string out of it

                label12.Text = $"{s_tenthclick} ({s_tenthdiff})"; // puts all the information the label
            }
            else if (clicks == 100) // repoetition
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

                finaldiff = trhundthclick - firstclick;
                s_finaldiff = finaldiff.ToString(@"hh\:mm\:ss\.ff");

                label16.Text = $"({s_finaldiff})";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            clicks++; // counts clicks
            label2.Text = clicks.ToString() + "x"; // updates couter label
            timeclicks(); // calls the side time logic
        }

        private void clear() // restart
        {
            label4.Text = DateTime.Now.ToString("HH:mm:ss");

            clicks = 0;
            label2.Text = clicks.ToString() + "x";
            label11.Text = "None";
            label12.Text = "None";
            label13.Text = "None";
            label14.Text = "None";
            label15.Text = "None";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
