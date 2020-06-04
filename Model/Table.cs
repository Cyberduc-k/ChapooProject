using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Table
    {
        public int Number { get; }
        public int Seats { get; }
        public bool Occupied { get; }

        public Table(int number, int seats, bool occupied)
        {
            Number = number;
            Seats = seats;
            Occupied = occupied;
        }

        public Table()
        {

        }
    }
}
