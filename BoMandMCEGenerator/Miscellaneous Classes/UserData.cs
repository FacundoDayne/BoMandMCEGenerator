using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoMandMCEGenerator
{
    public class UserData
    {
        private Stack<PreviousBOM> previousBOMs = new Stack<PreviousBOM>();

        public void addBOM(DateTime dateTime, int ID, float Total, string Project) { previousBOMs.Push(new PreviousBOM(dateTime, ID, Total, Project)); Console.WriteLine("New BOM added\nDate: {0}\nID: {1}\nTotal: {2}\nProject: {3}", dateTime.ToString(), ID.ToString(), Total.ToString("0.##"), Project.ToString()); }
        public PreviousBOM getPreviousBOMAt(int index) { PreviousBOM[] tempoStack = previousBOMs.ToArray();  return tempoStack[index]; }
        public Stack<PreviousBOM> getPreviousBOM() { return previousBOMs; }        

    }
}
