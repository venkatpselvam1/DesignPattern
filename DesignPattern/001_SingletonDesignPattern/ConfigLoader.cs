using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_SingletonDesignPattern
{
    internal class ConfigLoader
    {
        private static ConfigLoader instance;
        public static ConfigLoader getConfigLoaderIns()
        {
            if (instance == null) instance = new ConfigLoader();
            return instance;
        }
        private ConfigLoader() {
            Console.WriteLine("This should be called only once.");
        }
    }
}
