using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_SingletonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parallel.For(0, 15, i => {
                //This is an example of how to achieve singleton but it fails in case of multithread scenario
                var configLoad = ConfigLoader.getConfigLoaderIns();
                //This example will pass in multithread. We acheived it using lock statement
                var configLoad2 = ConfigLoaderWithLock.getConfigLoaderIns();
                //This example will also pass multithread. But we are using .NET built-in lazy
                var configLoad3 = ConfigLoaderWithLazy.getConfigLoaderIns();
            });
        }
    }
}
