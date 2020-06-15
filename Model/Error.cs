using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Error
    {
        public string Type { get; } //The type of error
        public DateTime Time { get; } //The time the error occured
        public string Message { get; } //What the message of the error was
        public string Trace { get; } //The trace of the error

        public Error(string type, DateTime time, string message, string trace)
        {
            Type = type;
            Time = time;
            Message = message;
            Trace = trace;
        }
    }
}
