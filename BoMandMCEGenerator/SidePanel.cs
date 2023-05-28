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
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "AAAAAAAAAAAAAAAAAAAAAAAA";
        }

        private void btnDropdown_Click(object sender, EventArgs e)
        {
            DropDownMenuPanel.Visible = !DropDownMenuPanel.Visible;
        }


    }
}
