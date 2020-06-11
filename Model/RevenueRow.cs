using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    //Class to hold data for the rows in the Revenue ListView.
    public class RevenueRow
    {
        public int OrderCount { get; set; }
        public double TotalDrinks { get; set; }
        public double TotalLunch { get; set; }
        public double TotalDinner { get; set; }
        public double Total { get { return TotalDrinks + TotalLunch + TotalDinner; } }

        //Add a constructor to allow for the ++ operator
        public RevenueRow()
        {
            OrderCount = 0;
            TotalDrinks = 0;
            TotalLunch = 0;
            TotalDinner = 0;
        }
    }
}
