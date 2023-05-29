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
        string mainPanelName = "MainPanel_GenerateBOM";
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
                _current = nextMask;
                this.Controls.Add(_current);
                this._current.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
                this._current.BackColor = System.Drawing.Color.White;
                this._current.Location = new System.Drawing.Point(2, 0);
                this._current.Name = "_current";
                this._current.Size = new System.Drawing.Size(size[0], size[1]);
            }
        }
    }
}
