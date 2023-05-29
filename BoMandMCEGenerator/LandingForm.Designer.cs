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
            this.sidePanel1 = new BoMandMCEGenerator.SidePanel();
            this.mainPanel_GenerateBOM1 = new BoMandMCEGenerator.MainPanel_GenerateBOM();
            this.SuspendLayout();
            // 
            // sidePanel1
            // 
            this.sidePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.sidePanel1.Location = new System.Drawing.Point(700, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(294, 603);
            this.sidePanel1.TabIndex = 3;
            // 
            // mainPanel_GenerateBOM1
            // 
            this.mainPanel_GenerateBOM1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel_GenerateBOM1.AutoSize = true;
            this.mainPanel_GenerateBOM1.BackColor = System.Drawing.Color.White;
            this.mainPanel_GenerateBOM1.Location = new System.Drawing.Point(2, 0);
            this.mainPanel_GenerateBOM1.Name = "mainPanel_GenerateBOM1";
            this.mainPanel_GenerateBOM1.Size = new System.Drawing.Size(698, 603);
            this.mainPanel_GenerateBOM1.TabIndex = 2;
            // 
            // LandingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(994, 603);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.mainPanel_GenerateBOM1);
            this.MinimumSize = new System.Drawing.Size(1010, 642);
            this.Name = "LandingForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MainPanel_GenerateBOM mainPanel_GenerateBOM1;
        private SidePanel sidePanel1;
    }
}

