using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ProxyDesignPattern
{
    internal class ProxyServer : IServer
    {
        IServer RealServer;
        Dictionary<int, int> Count = new Dictionary<int, int>();
        int Limit = 3;
        public ProxyServer(IServer realServer) 
        {
            this.RealServer = realServer;
        }
        public bool BookRoom(int id, int count)
        {
            //check if the user is authenticated and authorized to BookRoom
            if (id > 10)
            {
                Console.WriteLine("User not authorized");
                return false;
            }
            if(Count.ContainsKey(id))
            {
                if (Count[id] == Limit)
                {
                    Console.WriteLine("Limit Reached");
                    return false;
                }

                Count[id]++;
            }
            else
            {
                Count.Add(id, 1);
            }

            //if the user exceeds the limit
            //publish metric
            return this.RealServer.BookRoom(id, count);
        }
    }
}
