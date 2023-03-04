using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ProxyDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Proxy means ‘in place of’, representing’ or ‘in place of’ or ‘on behalf of’ are
             * literal meanings of proxy and that directly explains Proxy Design Pattern.
             */
            ProxyServerExample();
        }

        private static void ProxyServerExample()
        {
            var server = new RealServer();
            var proxy = new ProxyServer(server);
            var client = new Client(proxy);
            var stopLoop = false;
            while (!stopLoop)
            {
                Console.WriteLine("Enter your choice?\n1. Book\n2.Break");
                var input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        process(client);
                        break;
                    default:
                        stopLoop  = true;
                        break;
                }
            }
        }
        private static void process(Client client)
        {
            Console.WriteLine("Enter user id");
            var id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter count");
            var cnt = int.Parse(Console.ReadLine());
            client.Book(id, cnt);
        }
    }
}
