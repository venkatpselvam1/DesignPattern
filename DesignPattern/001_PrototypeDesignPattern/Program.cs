using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_PrototypeDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Instead of creating the complex object again and again from the scratch, we can use the prototype design pattern.
             * We will clone the existing object and build on top of it.
             */
            // PrototypeDesignPatternWithCopyCat();
            SerialzlizationDeserializationCopy();
        }
        static void SerialzlizationDeserializationCopy()
        {
            var prototype = new ComplexModel2(1, 2, 3, 4, "venkat", "nandhni", "mom", "dad");
            Console.WriteLine("Prototype " + prototype);
            var str = ComplexModel2.Serialize(prototype);
            Console.WriteLine("JSON "+ str);
            var newObj = ComplexModel2.DeSerialize(str);
            newObj.y = "sagunthala";
            newObj.z = "panner";
            Console.WriteLine("Copycat " + newObj);
        }
        static void PrototypeDesignPatternWithCopyCat()
        {
            /*
             * We will have a constructor which will take the prototype instance and create new instance from it.
             */
            var prototype = new ComplexModel(1,2,3,4,"venkat","nandhni","mom", "dad");
            Console.WriteLine("Prototype "+prototype);
            var newObj = new ComplexModel(prototype);
            newObj.y = "sagunthala";
            newObj.z = "panner";
            Console.WriteLine("Copycat " + newObj);
        }
    }
}
