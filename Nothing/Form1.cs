using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nothing
{
    public partial class Form1 : Form
    {
        int clicks = 0;

        //start date
        string sh;
        string sm;
        string ss;

        int ish;
        int ism;
        int iss;

        //1st click
        string ph;
        string pm;
        string ps;

        int iph;
        int ipm;
        int ips;

        //10th click
        string p1h;
        string p1m;
        string p1s;

        int ip1h;
        int ip1m;
        int ip1s;

        int if1h;
        int if1m;
        int if1s;

        int ip1;

        //100th click
        string p2h;
        string p2m;
        string p2s;

        int ip2h;
        int ip2m;
        int ip2s;

        int if2h;
        int if2m;
        int if2s;

        //200th click
        string p3h;
        string p3m;
        string p3s;

        int ip3h;
        int ip3m;
        int ip3s;

        int if3h;
        int if3m;
        int if3s;

        //300th click
        string p4h;
        string p4m;
        string p4s;

        int ip4h;
        int ip4m;
        int ip4s;

        int if4h;
        int if4m;
        int if4s;

        public Form1()
        {
            InitializeComponent();
            label2.Text = clicks.ToString()+ "x";
            sh = DateTime.Now.ToString("hh");
            sm = DateTime.Now.ToString("mm");
            ss = DateTime.Now.ToString("ss");

            ish = Convert.ToInt32(sh);
            ism = Convert.ToInt32(sm);
            iss = Convert.ToInt32(ss);

            label4.Text = ish.ToString() + ":" + ism.ToString() + "." + iss.ToString();
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
            if(clicks == 1)
            {
                ph = DateTime.Now.ToString("hh");
                pm = DateTime.Now.ToString("mm");
                ps = DateTime.Now.ToString("ss");

                iph = Convert.ToInt32(ph);
                ipm = Convert.ToInt32(pm);
                ips = Convert.ToInt32(ps);


                label11.Text = iph.ToString() + ":" + ipm.ToString() + "." + ips.ToString();
            }
            else if(clicks == 10)
            {
                p1h = DateTime.Now.ToString("hh");
                p1m = DateTime.Now.ToString("mm");
                p1s = DateTime.Now.ToString("ss");

                ip1h = Convert.ToInt32(p1h);
                ip1m = Convert.ToInt32(p1m);
                ip1s = Convert.ToInt32(p1s);

                if(if1m == ip1m)
                {
                    if1s = ip1s - ips;
                }
                else
                {
                    ip1 = ip1m - ipm;
                    if1s = ((ip1 * 60) - ip1m ) + ip1s;
                }
                

                label12.Text = ip1h.ToString() + ":" + ip1m.ToString() + "." + ip1s.ToString() + "(" + if1h.ToString() + ":" + if1m.ToString() + "." + if1s.ToString() + "s)";
            }
            else if (clicks == 100)
            {
                p2h = DateTime.Now.ToString("hh");
                p2m = DateTime.Now.ToString("mm");
                p2s = DateTime.Now.ToString("ss");

                ip2h = Convert.ToInt32(p2h);
                ip2m = Convert.ToInt32(p2m);
                ip2s = Convert.ToInt32(p2s);

                if2m = ip2m - ipm;
                if2s = ip2s - ips;

                label13.Text = ip2h.ToString() + ":" + ip2m.ToString() + "." + ip2s.ToString() + "(" + if2h.ToString() + ":" + if2m.ToString() + "." + if2s.ToString() + "s)";
            }
            else if (clicks == 200)
            {
                p3h = DateTime.Now.ToString("hh");
                p3m = DateTime.Now.ToString("mm");
                p3s = DateTime.Now.ToString("ss");

                ip3h = Convert.ToInt32(p3h);
                ip3m = Convert.ToInt32(p3m);
                ip3s = Convert.ToInt32(p3s);

                if3m = ip3m - ipm;
                if3s = ip3s - ips;

                label14.Text = ip3h.ToString() + ":" + ip3m.ToString() + "." + ip3s.ToString() + "(" + if3h.ToString() + ":" + if3m.ToString() + "." + if3s.ToString() + "s)";
            }
            else if (clicks == 300)
            {
                p4h = DateTime.Now.ToString("hh");
                p4m = DateTime.Now.ToString("mm");
                p4s = DateTime.Now.ToString("ss");

                ip4h = Convert.ToInt32(p4h);
                ip4m = Convert.ToInt32(p4m);
                ip4s = Convert.ToInt32(p4s);

                if4m = ip4m - ipm;
                if4s = ip4s - ips;

                label15.Text = ip4h.ToString() + ":" + ip4m.ToString() + "." + ip4s.ToString() + "(" + if4h.ToString() + ":" + if4m.ToString() + "." + if4s.ToString() + "s)";
            }
            else
            {
                Console.WriteLine("fuck this");
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
