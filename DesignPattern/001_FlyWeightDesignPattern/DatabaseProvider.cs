using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_FlyWeightDesignPattern
{
    internal class DatabaseProvider
    {
        Dictionary<int, string> dataBase = new Dictionary<int, string>();
        public void AddEntry(int id, String  name)
        {
            dataBase.Add(id, name);
        }
    }
}
