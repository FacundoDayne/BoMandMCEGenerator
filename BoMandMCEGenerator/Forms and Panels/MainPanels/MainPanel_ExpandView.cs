using BoMandMCEGenerator.MainPanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Windows.Forms;

namespace BoMandMCEGenerator.Forms_and_Panels.MainPanels
{
    public partial class MainPanel_ExpandView : UserControl
    {
        PreviousBOM slotted;
        BillOfMaterials billOfMaterials;
        public static MainPanel_ExpandView expandViewInstance;
        public string[] newData;
        public MainPanel_ExpandView(PreviousBOM slotted)
        {
            InitializeComponent();
            this.slotted = slotted;
            lblCost.Text = "Php " + slotted.getTotal().ToString("F2");
            lblDate.Text = slotted.getDate().ToString();
            lblID.Text = slotted.getID().ToString();
            lblName.Text = slotted.getProject().ToString();
            this.billOfMaterials = slotted.getBillOfMaterials();
            this.Load += populateDataSet;
            this.btnDescription.Click += describeCell;
            this.btnEditCell.Click += editCell;
            expandViewInstance = this;
        }

        private void describeCell(object sender, EventArgs e)
        {
            DescriptionForm descriptionForm = new DescriptionForm(dataSet.CurrentCell.Value.ToString());
            descriptionForm.ShowDialog();
            descriptionForm.Dispose();
        }

        private void editCell(object sender, EventArgs e)
        {
            Debug.WriteLine(dataSet.CurrentCell.Value);
            int rowIndex = dataSet.CurrentCell.RowIndex;
            string[] sentData = { dataSet[0, rowIndex].Value.ToString(), dataSet[1, rowIndex].Value.ToString(), dataSet[2, rowIndex].Value.ToString() };
            EditCellForm editCellForm = new EditCellForm(sentData);
            if(editCellForm.ShowDialog() == DialogResult.OK)
            {
                dataSet[0, rowIndex].Value = newData[0];
                dataSet[1, rowIndex].Value = newData[1];
                dataSet[2, rowIndex].Value = newData[2];
                float total = Convert.ToInt64(dataSet[1, rowIndex].Value.ToString()) * float.Parse(dataSet[2, rowIndex].Value.ToString());
                dataSet[3, rowIndex].Value = total.ToString("F2");
            }
            editCellForm.Dispose();
        }

        private void populateDataSet(object sender, EventArgs e)
        {
            for (int i = 0; i < slotted.getBillOfMaterials().getName().Count; i++)
            {
                dataSet.Rows.Add();
                dataSet[0, i].Value = slotted.getBillOfMaterials().getName()[i];
                dataSet[1, i].Value = slotted.getBillOfMaterials().getQuantity()[i];
                dataSet[2, i].Value = slotted.getBillOfMaterials().getPrice()[i].ToString("F2");
                int quantity = (int)dataSet[1, i].Value;
                float price = float.Parse(dataSet[2,i].Value.ToString());
                float total = quantity * price;
                dataSet[3, i].Value = total.ToString("F2");
            }
        }

    }
}
