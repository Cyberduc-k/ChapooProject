using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Reservation
    {
        public int Id { get; }
        public string Name { get; }
        public DateTime Date { get; }
        public DateTime From { get; }
        public DateTime To { get; }
        public int NumberOfPersons { get; }
        public Table Table { get; }

        public Reservation(int id, string name, DateTime date, DateTime from, DateTime to, int numberOfPersons)
        {
            Id = id;
            Name = name;
            Date = date;
            From = from;
            To = to;
            NumberOfPersons = numberOfPersons;
        }
        public Reservation(int id, string name, DateTime date, DateTime from, DateTime to, int numberOfPersons, Table table)
        {
            Id = id;
            Name = name;
            Date = date;
            From = from;
            To = to;
            NumberOfPersons = numberOfPersons;
            Table = table;
        }
    }
}
