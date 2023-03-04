using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_FlyWeightDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Flyweight pattern is one of the structural design patterns
             * as this pattern provides ways to decrease object count
             * thus improving application required objects structure. 
             */
            ExampleFlyWeightDesignPattern();
        }

        private static void ExampleFlyWeightDesignPattern()
        {
            var db = new DatabaseProvider();
            db.AddEntry(1, "abcd");
            db.AddEntry(2, "abcd");
            db.AddEntry(3, "abcd");
            db.AddEntry(4, "abcd");
            //in actual SQL DB, for each row for this string entry will cost 4 char = 4 
        }
    }
}
