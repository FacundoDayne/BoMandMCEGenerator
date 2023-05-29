using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public LandingForm()
        {
            InitializeComponent();
            landingForm = this; Controls.Add(this.login1);
            if (!isLoggedIn) { showLogin(); }
        }

        public void changeText()
        {
            sidePanel1.lblUsername.Text = username;
        }

        public void showLogin()
        {
            login1.Show();
            login1.BringToFront();
        }

        public void maskChange (UserControl nextMask)
        {
            //curre
        }
    }
}
