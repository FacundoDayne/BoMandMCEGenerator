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
    public partial class EditCellForm : Form
    {
        public EditCellForm(string[] sentData)
        {
            InitializeComponent();
            this.lblMaterialID.Text = sentData[0];
            this.cbMaterialName.Text = sentData[1];
            this.txtQuantity.Text = sentData[2];
            this.lblPrice.Text = sentData[3];
            this.btnSave.Click += returnData;
            this.btnCancel.Click += returnData;
        }

        private void returnData(object sender, EventArgs e)
        {
            if (sender.Equals(btnSave))
            {
                try{
                    int quantity = (int)Convert.ToInt64(txtQuantity.Text.ToString());
                    string[] newData = { lblMaterialID.Text.ToString(), cbMaterialName.Text.ToString(), quantity.ToString(), lblPrice.Text.ToString() };
                    MainPanel_ExpandView.expandViewInstance.newData = newData;
                    this.DialogResult = DialogResult.OK; 
                    this.Close();
                }
                catch (FormatException message)
                {
                    MessageBox.Show("Please Input the correct information", "Change Cell Data");
                }      
            }
            else
            {
                this.Close();
            }
            
        }
    }
}
