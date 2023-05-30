using BoMandMCEGenerator.MainPanels;
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
    public partial class MainPanel_GenerateBOM : UserControl
    {
        Label width, height;
        UserControl userControl;

        private void MainPanel_GenerateBOM_SizeChanged(object sender, EventArgs e)
        {
            width.Text = "Width: " + this.Width;
            height.Text = "Height: " + this.Height;
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            LandingForm.landingForm.maskChange(new MainPane_ViewBOM());
        }

        public MainPanel_GenerateBOM()
        {
            InitializeComponent();
            userControl = this;
            width = label1;
            height = label2;
            width.Text = "Width: " + this.Width;
            height.Text = "Height: " + this.Height;
            this.SizeChanged += MainPanel_GenerateBOM_SizeChanged;
            this.btnGenerate.Click += btnGenerate_Click;
        }

    }
}
