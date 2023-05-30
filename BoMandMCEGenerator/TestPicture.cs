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
    public partial class TestPicture : PictureBox
    {
        public TestPicture(Image image) 
        { 
            InitializeComponent();
            this.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Image = image;
            this.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Margin = new System.Windows.Forms.Padding(20);


            this.SetStyle(
            System.Windows.Forms.ControlStyles.UserPaint |
            System.Windows.Forms.ControlStyles.AllPaintingInWmPaint |
            System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer,
            true);
        }
    }
}
