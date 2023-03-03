using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_SingletonDesignPattern
{
    internal class ConfigLoaderWithLazy
    {
        private static Lazy<ConfigLoaderWithLazy> instance = new Lazy<ConfigLoaderWithLazy>(() =>
            {
                return new ConfigLoaderWithLazy();
            });
        public static ConfigLoaderWithLazy getConfigLoaderIns()
        {
            return instance.Value;
        }
        private ConfigLoaderWithLazy() {
            Console.WriteLine("This should be called only once.");
        }
    }
}
