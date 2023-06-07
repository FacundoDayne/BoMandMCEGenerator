using BoMandMCEGenerator.MainPanels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            this.btnGenerate.Click += generateMCE;
            expandViewInstance = this;
        }

        private void generateMCE(object sender, EventArgs e)
        {
            BillOfMaterials DataToBeProcessed = new BillOfMaterials();
            float total = 0;
            for (int rowIndex = 0; rowIndex < dataSet.RowCount - 1; rowIndex++)
            {
                int ID = int.Parse(dataSet[0, rowIndex].Value.ToString());
                string name = dataSet[1, rowIndex].Value.ToString();
                int quantity = int.Parse(dataSet[2, rowIndex].Value.ToString());
                float price = float.Parse(dataSet[3, rowIndex].Value.ToString());
                total = total + float.Parse(dataSet[4, rowIndex].Value.ToString());

                DataToBeProcessed.addMaterialID(ID);
                DataToBeProcessed.addMaterialName(name);
                DataToBeProcessed.addMaterialQuantity(quantity);                
                DataToBeProcessed.addMaterialPrice(price);
                
            }
            
            LandingForm.landingForm.maskChange(new MainPanel_GenerateMCE(new PreviousBOM(slotted.getDate(), slotted.getID(), total, slotted.getProject(), DataToBeProcessed)));
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
            string[] sentData = { dataSet[0, rowIndex].Value.ToString(), dataSet[1, rowIndex].Value.ToString(), dataSet[2, rowIndex].Value.ToString(), dataSet[3, rowIndex].Value.ToString() };
            EditCellForm editCellForm = new EditCellForm(sentData);
            if(editCellForm.ShowDialog() == DialogResult.OK)
            {
                dataSet[0, rowIndex].Value = newData[0];
                dataSet[1, rowIndex].Value = newData[1];
                dataSet[2, rowIndex].Value = newData[2];
                dataSet[3, rowIndex].Value = newData[3];
                float total = Convert.ToInt64(dataSet[2, rowIndex].Value.ToString()) * float.Parse(dataSet[3, rowIndex].Value.ToString());
                dataSet[4, rowIndex].Value = total.ToString("F2");
            }
            editCellForm.Dispose();
        }

        private void populateDataSet(object sender, EventArgs e)
        {
            for (int i = 0; i < slotted.getBillOfMaterials().getName().Count; i++)
            {
                dataSet.Rows.Add();
                dataSet[0, i].Value = slotted.getBillOfMaterials().getID()[i].ToString();
                dataSet[1, i].Value = slotted.getBillOfMaterials().getName()[i];
                dataSet[2, i].Value = slotted.getBillOfMaterials().getQuantity()[i];
                dataSet[3, i].Value = slotted.getBillOfMaterials().getPrice()[i].ToString("F2");
                int quantity = (int)dataSet[2, i].Value;
                float price = float.Parse(dataSet[3,i].Value.ToString());
                float total = quantity * price;
                dataSet[4, i].Value = total.ToString("F2");
            }
        }

    }
}
