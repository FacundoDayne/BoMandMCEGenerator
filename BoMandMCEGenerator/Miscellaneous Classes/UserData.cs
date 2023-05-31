using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoMandMCEGenerator
{
    public class UserData
    {
        private List<PreviousBOM> previousBOMs = new List<PreviousBOM>();

        public void addBOM(DateTime dateTime, int ID, float Total) { previousBOMs.Add(new PreviousBOM(dateTime, ID, Total)); Console.WriteLine("New BOM added\nDate: {0}\nID: {1}\nTotal: {2}", dateTime.ToString(), ID.ToString(), Total.ToString()); }
        public PreviousBOM getPreviousBOMAt(int index) { return previousBOMs[index]; }
        public List<PreviousBOM> getPreviousBOM() { return previousBOMs; }

        

    }
}
