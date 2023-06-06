using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoMandMCEGenerator.Forms_and_Panels
{
    public partial class DescriptionForm : Form
    {
        public DescriptionForm(string name)
        {
            InitializeComponent();
            this.Text = name + " Description";
        }
    }
}
