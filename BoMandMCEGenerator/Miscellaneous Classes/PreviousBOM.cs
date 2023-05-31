using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoMandMCEGenerator
{
    public class PreviousBOM
    {

        DateTime Date;
        int ID;
        float Total;

        public PreviousBOM(DateTime Date, int ID, float Total)
        {
            this.Date = Date;
            this.ID = ID;
            this.Total = Total;
        }
        /*
        public DateTime Date { get { return Date; } set { Date = value; } }
        public int ID { get { return ID; } set { ID = value; } }
        public float Total { get { return Total; } set { Total = value; } }
        */

        public DateTime getDate() { return Date; }
        public int getID() { return ID; }
        public float getTotal() { return Total; }

    }
}
