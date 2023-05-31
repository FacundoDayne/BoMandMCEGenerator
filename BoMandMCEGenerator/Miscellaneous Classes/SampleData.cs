using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoMandMCEGenerator
{
    public class SampleData
    {

        public Stack<PreviousBOM> previousBOMs;

        public SampleData(int i)
        {
            previousBOMs = new Stack<PreviousBOM>();
            for(int j = 1; j < i+1; j++)
            {
                previousBOMs.Push(new PreviousBOM(DateTime.Now, j, (10000 + j), "Project #" + j));
            }
        }

    }
}
