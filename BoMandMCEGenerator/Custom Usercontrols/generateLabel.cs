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
    public partial class generateLabel : Label
    {
        public generateLabel(string text)
        {
            InitializeComponent();
            this.Text = text; 
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer,
            true);
        }

        public generateLabel(float text)
        {
            InitializeComponent();
            this.Text = text.ToString();
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer,
            true);
        }

        public generateLabel(int text)
        {
            InitializeComponent();
            this.Text = text.ToString();
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer,
            true);
        }
        public generateLabel(double text)
        {
            InitializeComponent();
            this.Text = text.ToString();
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer,
            true);
        }
    }
}
