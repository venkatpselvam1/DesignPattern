using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _001_PrototypeDesignPattern
{
    internal class ComplexModel2
    {
        public int a, b, c, d;
        public string w, x, y, z;
        public ComplexModel2(int a, int b, int c, int d, string w, string x, string y, string z) { 
            this.a = a;
            this.b = b;
            this.c = d;
            this.d = d;
            //strings
            this.w = w;
            this.x = x;
            this.y = y;
            this.z = z;
        }
        public static string Serialize(ComplexModel2 obj)
        {
            return JsonConvert.SerializeObject(obj);
        }
        public static ComplexModel2 DeSerialize(string objStr)
        {

            return JsonConvert.DeserializeObject<ComplexModel2>(objStr);
        }
        public override string ToString()
        {
            return "a "+a+" b "+b + " c " + c + " d " + d+"\nw "+w+" x "+x + " y " + y + " z " + z;
        }
    }
}
