using System;
using System.Windows.Forms;

namespace BoMandMCEGenerator
{
    partial class SidePanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGenerateBOM = new System.Windows.Forms.Button();
            this.btnGenerateMCE = new System.Windows.Forms.Button();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDropdown = new System.Windows.Forms.Button();
            this.DropDownMenuPanel = new System.Windows.Forms.TableLayoutPanel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnViewBOM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.DropDownMenuPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateBOM
            // 
            this.btnGenerateBOM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateBOM.BackColor = System.Drawing.Color.Black;
            this.btnGenerateBOM.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateBOM.ForeColor = System.Drawing.Color.White;
            this.btnGenerateBOM.Location = new System.Drawing.Point(-1, 79);
            this.btnGenerateBOM.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenerateBOM.Name = "btnGenerateBOM";
            this.btnGenerateBOM.Size = new System.Drawing.Size(296, 48);
            this.btnGenerateBOM.TabIndex = 2;
            this.btnGenerateBOM.Text = "Generate BOM";
            this.btnGenerateBOM.UseVisualStyleBackColor = false;
            // 
            // btnGenerateMCE
            // 
            this.btnGenerateMCE.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateMCE.BackColor = System.Drawing.Color.Black;
            this.btnGenerateMCE.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnGenerateMCE.ForeColor = System.Drawing.Color.White;
            this.btnGenerateMCE.Location = new System.Drawing.Point(-1, 217);
            this.btnGenerateMCE.Margin = new System.Windows.Forms.Padding(0);
            this.btnGenerateMCE.Name = "btnGenerateMCE";
            this.btnGenerateMCE.Size = new System.Drawing.Size(296, 48);
            this.btnGenerateMCE.TabIndex = 3;
            this.btnGenerateMCE.Text = "Generate MCE";
            this.btnGenerateMCE.UseVisualStyleBackColor = false;
            // 
            // lblUsername
            // 
            this.lblUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblUsername.Location = new System.Drawing.Point(90, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsername.Size = new System.Drawing.Size(93, 32);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "USERNAME";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::BoMandMCEGenerator.Properties.Resources.PersonIcon;
            this.pictureBox1.Location = new System.Drawing.Point(69, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnDropdown
            // 
            this.btnDropdown.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDropdown.FlatAppearance.BorderSize = 0;
            this.btnDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDropdown.Image = global::BoMandMCEGenerator.Properties.Resources.DropDownIcon;
            this.btnDropdown.Location = new System.Drawing.Point(189, 3);
            this.btnDropdown.Name = "btnDropdown";
            this.btnDropdown.Size = new System.Drawing.Size(15, 26);
            this.btnDropdown.TabIndex = 6;
            this.btnDropdown.Text = "\r\n";
            this.btnDropdown.UseVisualStyleBackColor = true;
            this.btnDropdown.Click += new System.EventHandler(this.btnDropdown_Click);
            // 
            // DropDownMenuPanel
            // 
            this.DropDownMenuPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DropDownMenuPanel.AutoSize = true;
            this.DropDownMenuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(106)))), ((int)(((byte)(124)))));
            this.DropDownMenuPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.DropDownMenuPanel.ColumnCount = 1;
            this.DropDownMenuPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.DropDownMenuPanel.Controls.Add(this.btnLogout, 0, 1);
            this.DropDownMenuPanel.Controls.Add(this.btnAccount, 0, 0);
            this.DropDownMenuPanel.Location = new System.Drawing.Point(187, 35);
            this.DropDownMenuPanel.Name = "DropDownMenuPanel";
            this.DropDownMenuPanel.RowCount = 2;
            this.DropDownMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DropDownMenuPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.DropDownMenuPanel.Size = new System.Drawing.Size(101, 75);
            this.DropDownMenuPanel.TabIndex = 7;
            this.DropDownMenuPanel.Visible = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.LightGray;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(4, 41);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(93, 30);
            this.btnLogout.TabIndex = 0;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.LightGray;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.Location = new System.Drawing.Point(4, 4);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(93, 30);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "Account";
            this.btnAccount.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel1.Controls.Add(this.btnDropdown, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblUsername, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(81, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(207, 32);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // btnViewBOM
            // 
            this.btnViewBOM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewBOM.BackColor = System.Drawing.Color.Black;
            this.btnViewBOM.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btnViewBOM.ForeColor = System.Drawing.Color.White;
            this.btnViewBOM.Location = new System.Drawing.Point(-1, 148);
            this.btnViewBOM.Name = "btnViewBOM";
            this.btnViewBOM.Size = new System.Drawing.Size(296, 48);
            this.btnViewBOM.TabIndex = 10;
            this.btnViewBOM.Text = "View BOMS";
            this.btnViewBOM.UseVisualStyleBackColor = false;
            // 
            // SidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(136)))), ((int)(((byte)(146)))));
            this.Controls.Add(this.btnViewBOM);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DropDownMenuPanel);
            this.Controls.Add(this.btnGenerateMCE);
            this.Controls.Add(this.btnGenerateBOM);
            this.Name = "SidePanel";
            this.Size = new System.Drawing.Size(294, 592);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.DropDownMenuPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


        #endregion
        private System.Windows.Forms.Button btnGenerateBOM;
        private System.Windows.Forms.Button btnGenerateMCE;
        public System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDropdown;
        private System.Windows.Forms.TableLayoutPanel DropDownMenuPanel;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private SidePanel sidePanel;
        private Button btnViewBOM;
    }
}
