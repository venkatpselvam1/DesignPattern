using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _001_FlyWeightDesignPattern
{
    internal class DatabaseProviderWithFlyWeight
    {
        Dictionary<int, int> dataBase = new Dictionary<int, int>();
        Dictionary<string, int> stringDb = new Dictionary<string, int>();
        int charCount = 0;
        int runningCount = 1;
        public void AddEntry(int id, string  name)
        {
            if (!stringDb.ContainsKey(name))
            {
                stringDb.Add(name, runningCount);
                runningCount++;
                charCount += name.Length;
            }
            var strId = stringDb[name];
            dataBase.Add(id, strId);
        }
        public int getTotalSize()
        {
            return charCount * 2;
        }
    }
}
