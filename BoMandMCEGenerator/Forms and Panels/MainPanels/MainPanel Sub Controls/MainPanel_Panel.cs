using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BoMandMCEGenerator.Custom_Usercontrols
{
    public partial class MainPanel_Panel : UserControl
    {
        public MainPanel_Panel(int[] size)
        {
            InitializeComponent();
            this.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.BackColor = System.Drawing.Color.White;
            this.Location = new System.Drawing.Point(2, 0);
            this.Name = "_current";
            this.Size = new System.Drawing.Size(size[0], size[1]);
        }

        public MainPanel_Panel()
        {
            InitializeComponent();
        }

        public UserControl Conform_MainPanel(int[] size, UserControl userControl)
        {
            userControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            userControl.BackColor = System.Drawing.Color.White;
            userControl.Location = new System.Drawing.Point(2, 0);
            userControl.Name = "_current";
            userControl.Size = new System.Drawing.Size(size[0], size[1]);
            return userControl;
        }



    }
}
