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

        private void MainPanel_GenerateBOM_SizeChanged(object sender, EventArgs e)
        {
            width.Text = "Width: " + this.Width;
            height.Text = "Height: " + this.Height;
        }

        public MainPanel_GenerateBOM()
        {
            InitializeComponent();
            width = label1;
            height = label2;
            width.Text = "Width: " + this.Width;
            height.Text = "Height: " + this.Height;
        }

    }
}
