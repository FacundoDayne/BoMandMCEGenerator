using BoMandMCEGenerator.MainPanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoMandMCEGenerator.Forms_and_Panels.MainPanels
{
    public partial class MainPanel_ExpandView : UserControl
    {
        PreviousBOM slotted;
        public MainPanel_ExpandView(PreviousBOM slotted)
        {
            InitializeComponent();
            this.slotted = slotted;
            lblCost.Text = "Php " + slotted.getTotal().ToString("F2");
            lblDate.Text = slotted.getDate().ToString();
            lblID.Text = slotted.getID().ToString();
            lblName.Text = slotted.getProject().ToString();
            btnBack.Click += BtnBack_Click;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            LandingForm.landingForm.maskChange(new MainPanel_ViewBOM());
        }
    }
}
