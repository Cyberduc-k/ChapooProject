using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Error
    {
        public string Type { get; }
        public DateTime Time { get; }
        public string Message { get; }
        public string Trace { get; }

        public Error(string type, DateTime time, string message, string trace)
        {
            Type = type;
            Time = time;
            Message = message;
            Trace = trace;
        }
    }
}
