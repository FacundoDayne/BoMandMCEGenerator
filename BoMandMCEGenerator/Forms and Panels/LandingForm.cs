using BoMandMCEGenerator.Custom_Usercontrols;
using BoMandMCEGenerator.Miscellaneous_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace BoMandMCEGenerator
{
    public partial class LandingForm : Form
    {
        public bool isLoggedIn = false;
        public static LandingForm landingForm;
        private UserControl currentMainPanel;
        public string username = "";
        string mainPanelName = "MainPanel_GenerateBOM";
        public LandingForm()
        {
            InitializeComponent();
            landingForm = this; Controls.Add(this.login1);
            if (!isLoggedIn) { showLogin(); }
//LITERAL MAGIC CODE, REMOVES FLICKERING
            typeof(Login).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, login1, new object[] { true });
            Stack<PreviousBOM> a = new SampleData(20).previousBOMs;
        }

        public void changeText()
        {
            //sidePanel1.lblUsername.Text = username;
        }

        public void showLogin()
        {
            login1.Show();
            login1.BringToFront();
            maskChange(new MainPanel_GenerateBOM());
        }
        
        public void maskChange (UserControl nextMask)
        {
            int[] size = { _current.Width, _current.Height };
            Point location = _current.Location;
            if (mainPanelName != nextMask.Name.ToString())
            {
                Debug.WriteLine("Main panel changed to: " + nextMask.Name.ToString());
                mainPanelName = nextMask.Name.ToString();
                this.Controls.Remove(_current);
//if this code breaks, there might have been an auto generated code that turned _current into a MainPanel_GenerateBOM class
//change it in the Designer class to fix
                _current = new MainPanel_Panel(size, location, nextMask).newPanel;
                this.Controls.Add(_current);
            }
        }
    }
}
