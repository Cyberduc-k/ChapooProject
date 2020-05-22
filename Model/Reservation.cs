using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reservation
    {
        public int ID { get; }
        public string Name { get; }
        public DateTime Date { get; }
        public DateTime From { get; }
        public DateTime To { get; }
        public int NumberOfPersons { get; }

        public Reservation(int iD, string name, DateTime date, DateTime from, DateTime to, int numberOfPersons)
        {
            ID = iD;
            Name = name;
            Date = date;
            From = from;
            To = to;
            NumberOfPersons = numberOfPersons;
        }
    }
}
