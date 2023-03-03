using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_PrototypeDesignPatternUsingProtobuf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrototypeDesignPatternWithCopyCat();
            SerialzlizationDeserializationCopy();
        }
        static void SerialzlizationDeserializationCopy()
        {
            var prototype = new ComplexModel();
            prototype.A = 1;
            prototype.B = 2;
            prototype.C = 3;
            prototype.D = 4;
            prototype.W = "Venkat";
            prototype.X = "Nandhni";
            prototype.Y = "Mom";
            prototype.Z = "Dad";
            Console.WriteLine("Prototype " + prototype);

            //Type1: Serialize the object to bytestring and deserialize from bytestring
            var byteString = prototype.ToByteString();
  
            var newObj = ComplexModel.Parser.ParseFrom(byteString);
            newObj.Y = "sagunthala";
            newObj.Z = "panner";
            Console.WriteLine("Copycat " + newObj);

            //Type2: Serialize to and deserialize from base64
            var str = byteString.ToBase64();
            Console.WriteLine("Protopub " + str);
            var newObj1 = ComplexModel.Parser.ParseFrom(ByteString.FromBase64(str));
            newObj1.Y = "sagunthala p";
            newObj1.Z = "panneer s";
            Console.WriteLine("Copycat using base64 " + newObj1);
        }
        static void PrototypeDesignPatternWithCopyCat()
        {
            var prototype = new ComplexModel();
            prototype.A = 1;
            prototype.B = 2;
            prototype.C = 3;
            prototype.D = 4;
            prototype.W = "Venkat";
            prototype.X = "Nandhni";
            prototype.Y = "Mom";
            prototype.Z = "Dad";
            Console.WriteLine("Prototype " + prototype);
            var newObj = new ComplexModel(prototype);
            newObj.Y = "sagunthala";
            newObj.Z = "panner";
            Console.WriteLine("Copycat " + newObj);
        }
    }
}
