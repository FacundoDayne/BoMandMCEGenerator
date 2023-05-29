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
    public partial class Login : UserControl
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {
            Control control = (Control)sender;
            Color color1 = Color.FromArgb(152, 136, 146);
            Color color2 = Color.FromArgb(134, 106, 124);
            using (var brush1 = new SolidBrush(color1))
            using (var brush2 = new SolidBrush(color2))
            {
                Rectangle rect1 = new Rectangle(control.ClientRectangle.X, control.ClientRectangle.Y,
                                                control.ClientRectangle.Width / 2, control.ClientRectangle.Height);
                Rectangle rect2 = new Rectangle(control.ClientRectangle.Width / 2, control.ClientRectangle.Y,
                                                control.ClientRectangle.Width / 2, control.ClientRectangle.Height);

                // Fill the first half of the control with the first color
                e.Graphics.FillRectangle(brush1, rect1);

                // Fill the second half of the control with the second color
                e.Graphics.FillRectangle(brush2, rect2);
            }
        }
        private void CenterPanel()
        {
            pnlLogin.Size = new Size(this.Width / 3, this.Height / 2);
            pnlLogin.Location = new Point((this.Width - pnlLogin.Width) / 2, (this.Height - pnlLogin.Height) / 2);
        }

        private void RaisePaintEvent(Control control)
        {
            control.Invalidate();
        }

        private void Login_Paint(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            RaisePaintEvent(control);
            CenterPanel();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            CenterPanel();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LandingForm.landingForm.username = txtUsername.Text.ToString();
            LandingForm.landingForm.changeText();
            this.Hide();
        }
    }
}
