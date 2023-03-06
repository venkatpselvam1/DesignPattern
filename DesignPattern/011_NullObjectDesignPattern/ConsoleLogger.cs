using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_NullObjectDesignPattern
{
    internal class ConsoleLogger : ILogger
    {
        public void log(string message)
        {
            Console.WriteLine(message);
        }
    }
}
