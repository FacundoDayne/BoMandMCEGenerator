using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BoMandMCEGenerator.Miscellaneous_Classes
{
    public partial class MainPanel_LandingPanel : UserControl
    {
        int counter1 = 0;
        int counter2 = 0;
        bool goForth = true;
        public MainPanel_LandingPanel()
        {
            InitializeComponent();
            this.Load += startTimer;
            typeof(UserControl).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null,this, new object[] { true });
            timer1.Interval = 20; timer2.Interval = 40;
        }

        private void startTimer(object sender, EventArgs e)
        {
            //timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            counter1++;
            if (counter1 > 20)
            {
                counter1 = 0;
                timer1.Stop();
                timer2.Start();
            }
            if (goForth)
            {
                //pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
            }
            else
            {
                //pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter2++;
            if (counter2 > 20)
            {
                counter2 = 0;
                timer2.Stop();
                goForth = !goForth;
                timer1.Start();
            }
            if (goForth)
            {
                //pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
            }
            else
            {
                //pictureBox1.Location = new Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
            }
        }

    }
}
