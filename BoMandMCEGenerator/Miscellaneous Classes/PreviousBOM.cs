using BoMandMCEGenerator.Forms_and_Panels.MainPanels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoMandMCEGenerator
{
    public class PreviousBOM
    {

        private DateTime Date;
        private int ID;
        private float Total;
        private string Project;
        private BillOfMaterials BillOfMaterials;

        public PreviousBOM(DateTime Date, int ID, float Total, string Project, BillOfMaterials billOfMaterials)
        {
            this.Date = Date;
            this.ID = ID;
            this.Total = Total;
            this.Project = Project;
            this.BillOfMaterials = billOfMaterials;
        }
        public DateTime getDate() { return Date; }
        public int getID() { return ID; }
        public float getTotal() { return Total; }
        public string getProject() { return Project; }
        public BillOfMaterials getBillOfMaterials() {  return BillOfMaterials; }
    }
}
