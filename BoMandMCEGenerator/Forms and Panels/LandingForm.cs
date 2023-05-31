using BoMandMCEGenerator.Custom_Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public UserData UserData;
        private MainPanel_Panel MainPanel_Panel = new MainPanel_Panel();
        public LandingForm()
        {
            InitializeComponent();
            landingForm = this; Controls.Add(this.login1);
            if (!isLoggedIn) { showLogin(); }
//LITERAL MAGIC CODE, REMOVES FLICKERING
            typeof(Login).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, login1, new object[] { true });
            UserData = new UserData();
            UserData.addBOM(DateTime.Now, 123, 500);
        }

        public void changeText()
        {
            sidePanel1.lblUsername.Text = username;
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
            if (mainPanelName == nextMask.Name.ToString())
            {
                Console.WriteLine("Same thing");
            }
            else
            {
                Console.WriteLine("difference\n" + mainPanelName + "\n"+ nextMask.Name.ToString());
            }
            if (mainPanelName != nextMask.Name.ToString())
            {
                Console.WriteLine("Main panel changed to: " + nextMask.Name.ToString());
                mainPanelName = nextMask.Name.ToString();
                this.Controls.Remove(_current);
//if this code breaks, there might have been an auto generated code that turned _current into a MainPanel_GenerateBOM class
//change it in the Designer class to fix
                //_current = nextMask;
                _current = MainPanel_Panel.Conform_MainPanel(size, nextMask);
                this.Controls.Add(_current);
            }
        }
    }
}
