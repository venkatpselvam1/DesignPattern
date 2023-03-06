using _011_NullObjectDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_NullObjectDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * The intent of a Null Object is 
             * to encapsulate the absence of an object
             * by providing a substitutable alternative
             * that offers suitable default do nothing behavior. 
             * In short, a design where "nothing will come of nothing"
             */
            ExampleCodeWithoutNullObject();
            ExampleCodeWithNullObject();
        }

        private static void ExampleCodeWithNullObject()
        {
            ILogger logger = new ConsoleLogger();
            logger.log("ExampleCodeWithNullObject");
            ILogger invalidLogger = new NullLogger();//due to some conf load issue, logger is set null
            //client code has to check if the logger is null
            invalidLogger.log("this is error message from the client");
        }

        private static void ExampleCodeWithoutNullObject()
        {
            ILogger logger = new ConsoleLogger();
            logger.log("ExampleCodeWithoutNullObject");
            ILogger invalidLogger = null;//due to some conf load issue, logger is set null
            //client code has to check if the logger is null
            if (invalidLogger != null) invalidLogger.log("this is error message from the client");
        }
    }
}
