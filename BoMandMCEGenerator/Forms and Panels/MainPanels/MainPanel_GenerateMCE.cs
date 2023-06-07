using BoMandMCEGenerator.Forms_and_Panels.MainPanels;
using BoMandMCEGenerator.MainPanels;
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
    public partial class MainPanel_GenerateMCE : UserControl
    {
        PreviousBOM slotted;
        BillOfMaterials billOfMaterials;
        public MainPanel_GenerateMCE(PreviousBOM slotted)
        {
            InitializeComponent();
            this.slotted = slotted;
            lblCost.Text = "Php " + slotted.getTotal().ToString("F2");
            lblDate.Text = slotted.getDate().ToString();
            lblID.Text = slotted.getID().ToString();
            lblName.Text = slotted.getProject().ToString();
            this.billOfMaterials = slotted.getBillOfMaterials();
            this.Load += populateDataSet;
            this.SetStyle(
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint |
            ControlStyles.OptimizedDoubleBuffer,
            true);
        }



        private void populateDataSet(object sender, EventArgs e)
        {
            for (int i = 0; i < slotted.getBillOfMaterials().getName().Count; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 33));
            }
            for (int i = 0; i < slotted.getBillOfMaterials().getName().Count; i++)
            {
                tableLayoutPanel1.Controls.Add(new generateLabel(billOfMaterials.getName()[i].ToString()));
                tableLayoutPanel1.Controls.Add(new generateLabel(billOfMaterials.getQuantity()[i].ToString()));
                tableLayoutPanel1.Controls.Add(new generateLabel(billOfMaterials.getPrice()[i].ToString()));
                tableLayoutPanel1.Controls.Add(new generateTextBox("txtMarkup#" + i));
                tableLayoutPanel1.Controls.Add(new generateLabel(billOfMaterials.getQuantity()[i] * billOfMaterials.getPrice()[i]));
            }            
        }
    }
}
