using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _001_FlyWeightDesignPattern
{
    internal class DatabaseProvider
    {
        Dictionary<int, string> dataBase = new Dictionary<int, string>();
        int charCount = 0;
        public void AddEntry(int id, string  name)
        {
            dataBase.Add(id, name);
            charCount += name.Length;
        }
        public int getTotalSize()
        {
            return charCount * 2;
        }
    }
}
