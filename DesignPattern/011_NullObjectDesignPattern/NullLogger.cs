using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_NullObjectDesignPattern
{
    internal class NullLogger : ILogger
    {
        public void log(string message)
        {
            //no functionality
        }
    }
}
