using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoMandMCEGenerator.Forms_and_Panels.MainPanels
{
    public class BillOfMaterials
    {
        private List<int> materialID;
        private List<string> materialName;
        private List<int> materialQuantity;
        private List<float> materialPrice;

        public BillOfMaterials(List<int> materialID, List<string> materialName, List<int> materialQuantity, List<float> materialPrice)
        {
            this.materialID = materialID;
            this.materialName = materialName;
            this.materialQuantity = materialQuantity;
            this.materialPrice = materialPrice;
        }
        public List<int> getID() { return materialID; }
        public List<string> getName() { return materialName; }
        public List<int> getQuantity() { return materialQuantity; }
        public List<float> getPrice() { return materialPrice; }
    }       
}
