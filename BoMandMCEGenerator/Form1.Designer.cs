namespace BoMandMCEGenerator
{
    partial class Form1
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
            this.roundButton1 = new RoundButton();
            this.roundedTextBox1 = new RoundedTextBox();
            this.SuspendLayout();
            // 
            // roundButton1
            // 
            this.roundButton1.Location = new System.Drawing.Point(185, 144);
            this.roundButton1.Name = "roundButton1";
            this.roundButton1.Size = new System.Drawing.Size(141, 98);
            this.roundButton1.TabIndex = 0;
            this.roundButton1.Text = "roundButton1";
            this.roundButton1.UseVisualStyleBackColor = true;
            // 
            // roundedTextBox1
            // 
            this.roundedTextBox1.Location = new System.Drawing.Point(520, 222);
            this.roundedTextBox1.MinimumSize = new System.Drawing.Size(0, 50);
            this.roundedTextBox1.Name = "roundedTextBox1";
            this.roundedTextBox1.Size = new System.Drawing.Size(50, 20);
            this.roundedTextBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.roundedTextBox1);
            this.Controls.Add(this.roundButton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RoundButton roundButton1;
        private RoundedTextBox roundedTextBox1;
    }
}