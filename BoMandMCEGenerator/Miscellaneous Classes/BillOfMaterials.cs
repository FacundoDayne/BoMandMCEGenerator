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
        public BillOfMaterials()
        {
            this.materialID = new List<int>();
            this.materialName = new List<string>();
            this.materialQuantity = new List<int>();
            this.materialPrice = new List<float>();
        }
        public List<int> getID() { return materialID; }
        public List<string> getName() { return materialName; }
        public List<int> getQuantity() { return materialQuantity; }
        public List<float> getPrice() { return materialPrice; }
        public void addMaterialID(int materialID) { this.materialID.Add(materialID); }
        public void addMaterialName(string materialName) { this.materialName.Add(materialName); }
        public void addMaterialQuantity(int materialQuantity) {this.materialQuantity.Add(materialQuantity); }
        public void addMaterialPrice(float materialPrice) { this.materialPrice.Add(materialPrice); }
    }       
}
