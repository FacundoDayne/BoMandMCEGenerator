using BoMandMCEGenerator.Forms_and_Panels.MainPanels;
using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace BoMandMCEGenerator.MainPanels
{
    public partial class ViewBOM_Plate : UserControl
    {
        PreviousBOM slotted;
        public ViewBOM_Plate(PreviousBOM previousBOM)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Margin = new Padding(20);
            this.SetStyle( ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint |ControlStyles.OptimizedDoubleBuffer, true);
            lblDate.Text = previousBOM.getDate().ToString();
            lblID.Text = previousBOM.getID().ToString();
            lblTotal.Text = "Php " + previousBOM.getTotal().ToString("F2");
            lblProject.Text = previousBOM.getProject().ToString();
            tableLayoutPanel1.MouseClick += expandView;
            tableLayoutPanel1.MouseEnter += mouseEnter;
            tableLayoutPanel1.MouseLeave += mouseExit;
            tableLayoutPanel1.MouseUp += mouseExit;
            tableLayoutPanel1.MouseDown += mouseDown;
            lblDate.MouseEnter += mouseEnter; lblDate.MouseLeave += mouseExit;
            lblID.MouseEnter += mouseEnter; lblID.MouseLeave += mouseExit;
            lblProject.MouseEnter += mouseEnter; lblProject.MouseLeave += mouseExit;
            lblTotal.MouseEnter += mouseEnter; lblTotal.MouseLeave += mouseExit;
            label1.MouseEnter += mouseEnter; label1.MouseLeave += mouseExit;
            label2.MouseEnter += mouseEnter; label2.MouseLeave += mouseExit;
            label3.MouseEnter += mouseEnter; label3.MouseLeave += mouseExit;
            label4.MouseEnter += mouseEnter; label4.MouseLeave += mouseExit;
            slotted = previousBOM;

        }
        private void mouseDown(object sender, MouseEventArgs e) {   if (e.Button == MouseButtons.Left) {   this.BackColor = Color.FromArgb(183, 176, 180); }   }
        private void mouseEnter(object sender, EventArgs e) {   this.BackColor = Color.FromArgb(136, 122, 131); tableLayoutPanel1.MouseEnter -= mouseEnter; }
        private void mouseExit(object sender, EventArgs e)  {   this.BackColor = Color.FromArgb(152, 136, 146); tableLayoutPanel1.MouseEnter += mouseEnter; }
        private void expandView(object sender, MouseEventArgs e)    {   if (e.Button == MouseButtons.Left)  {   LandingForm.landingForm.maskChange(new MainPanel_ExpandView(slotted));  }   }
    }
}
