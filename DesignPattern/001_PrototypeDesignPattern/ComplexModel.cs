using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_PrototypeDesignPattern
{
    internal class ComplexModel
    {
        public int a, b, c, d;
        public string w, x, y, z;
        public ComplexModel(int a, int b, int c, int d, string w, string x, string y, string z) { 
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
        public ComplexModel(ComplexModel protoType) {
            this.a = protoType.a;
            this.b = protoType.b;
            this.c = protoType.d;
            this.d = protoType.d;
            //strings
            this.w = protoType.w;
            this.x = protoType.x;
            this.y = protoType.y;
            this.z = protoType.z;
        }
        public override string ToString()
        {
            return "a "+a+" b "+b + " c " + c + " d " + d+"\nw "+w+" x "+x + " y " + y + " z " + z;
        }
    }
}
