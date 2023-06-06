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
        public UserControl newPanel;
        public MainPanel_Panel(int[] size, Point location, UserControl userControl)
        {            
            InitializeComponent();
            newPanel = userControl;
            newPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            newPanel.BackColor = System.Drawing.Color.White;
            newPanel.Location = location;
            newPanel.Name = "_current";
            newPanel.Size = new System.Drawing.Size(size[0], size[1]);
        }
        public MainPanel_Panel()
        {
            InitializeComponent();
        }

        public UserControl Conform_MainPanel(int[] size, Point location, UserControl userControl)
        {
            userControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            userControl.BackColor = System.Drawing.Color.White;
            userControl.Location = location;
            userControl.Name = "_current";
            userControl.Size = new System.Drawing.Size(size[0], size[1]);
            return userControl;
        }



    }
}
