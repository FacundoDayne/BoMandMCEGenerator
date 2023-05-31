using BoMandMCEGenerator.MainPanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace BoMandMCEGenerator
{
    public partial class SidePanel : UserControl
    {
        
        public SidePanel()
        {
            InitializeComponent(); sidePanel = this;
            btnGenerateBOM.Click += hideDropDown;
            btnGenerateMCE.Click += hideDropDown;
            btnAccount.Click += hideDropDown;
            sidePanel.Click += hideDropDown;
            btnLogout.Click += logOut;
            btnLogout.Click += hideDropDown;
            btnGenerateBOM.Click += requestChange;
            btnGenerateMCE.Click += requestChange;
            btnViewBOM.Click += requestChange;
        }

        private void btnDropdown_Click(object sender, EventArgs e)
        {
            DropDownMenuPanel.Visible = !DropDownMenuPanel.Visible;
        }

        private void hideDropDown(object sender, EventArgs e)
        {
            DropDownMenuPanel.Hide();
        }

        private void logOut(object sender, EventArgs e)
        {
            LandingForm.landingForm.isLoggedIn = false;
            LandingForm.landingForm.showLogin();
        }

        private void requestChange (object sender, EventArgs e)
        {
            Button check = (Button)sender;
            switch (check.Name.ToString())
            {
                case "btnGenerateBOM":
                    LandingForm.landingForm.maskChange(new MainPanel_GenerateBOM());
                    break;
                case "btnGenerateMCE":
                    LandingForm.landingForm.maskChange(new MainPanel_GenerateMCE());
                    break;
                case "btnViewBOM":
                    LandingForm.landingForm.maskChange(new MainPane_ViewBOM());
                    break;
            }
        }

    }
}
