using BoMandMCEGenerator.Miscellaneous_Classes;
using System.Windows.Forms;

namespace BoMandMCEGenerator
{
    partial class LandingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._current = new BoMandMCEGenerator.Miscellaneous_Classes.MainPanel_LandingPanel();
            this.login1 = new BoMandMCEGenerator.Login();
            this.sidePanel1 = new BoMandMCEGenerator.SidePanel();
            this.SuspendLayout();
            // 
            // _current
            // 
            this._current.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._current.BackColor = System.Drawing.SystemColors.Control;
            this._current.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this._current.Location = new System.Drawing.Point(-2, 0);
            this._current.Margin = new System.Windows.Forms.Padding(0);
            this._current.Name = "_current";
            this._current.Size = new System.Drawing.Size(702, 603);
            this._current.TabIndex = 4;
            this._current.Load += new System.EventHandler(this._current_Load);
            // 
            // login1
            // 
            this.login1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.login1.Location = new System.Drawing.Point(0, 0);
            this.login1.Name = "login1";
            this.login1.Size = new System.Drawing.Size(1000, 610);
            this.login1.TabIndex = 4;
            this.login1.Visible = false;
            // 
            // sidePanel1
            // 
            this.sidePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(700, 0);
            this.sidePanel1.Margin = new System.Windows.Forms.Padding(0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(294, 603);
            this.sidePanel1.TabIndex = 5;
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(994, 603);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this._current);
            this.MinimumSize = new System.Drawing.Size(1010, 642);
            this.Name = "LandingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        public Login login1;
        private SidePanel sidePanel1;
        private UserControl _current;
    }
}

