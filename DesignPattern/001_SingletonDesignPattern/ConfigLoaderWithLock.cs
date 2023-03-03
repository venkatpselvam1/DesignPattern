using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_SingletonDesignPattern
{
    internal class ConfigLoaderWithLock
    {
        private static ConfigLoaderWithLock instance;
        private static Object instanceLock = new object();
        public static ConfigLoaderWithLock getConfigLoaderIns()
        {
            if (instance == null)
            {
                lock(instanceLock)
                {
                    if(instance == null)
                    instance = new ConfigLoaderWithLock();
                }
            }
            return instance;
        }
        private ConfigLoaderWithLock() {
            Console.WriteLine("This should be called only once.");
        }
    }
}
