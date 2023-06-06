using BoMandMCEGenerator.Forms_and_Panels.MainPanels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoMandMCEGenerator
{
    public class SampleData
    {

        public Stack<PreviousBOM> previousBOMs;
        List<int> materialID = new List<int>();
        List<string> materialName = new List<string>();
        List<int> materialQuantity = new List<int>();
        List<float> materialPrice = new List<float>();
        public SampleData(int i)
        {
            previousBOMs = new Stack<PreviousBOM>();
            for(int j = 1; j < i+1; j++)
            {
                materialID.Add(j);
                materialName.Add("Material: " +  j);
                materialQuantity.Add(j);
                materialPrice.Add(10000 + j);
                previousBOMs.Push(new PreviousBOM(DateTime.Now, j, (10000 + j), "Project #" + j, new BillOfMaterials(materialID, materialName, materialQuantity, materialPrice)));
            }
        }

    }
}
