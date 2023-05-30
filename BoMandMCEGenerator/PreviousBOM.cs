using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoMandMCEGenerator
{
    public class PreviousBOM
    {
        DateTime date;
        int ID;
        float Total;

        public PreviousBOM(DateTime date, int ID, float Total)
        {
            this.date = date;
            this.ID = ID;
            this.Total = Total;
        }

        public DateTime getDate { get { return date; } }
        public int getID { get { return ID; } }
        public float getTotal { get { return Total; } }
    }
}
