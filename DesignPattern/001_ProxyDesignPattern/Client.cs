
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ProxyDesignPattern
{
    internal class Client
    {
        IServer proxyServer;
        public Client(IServer proxyServer) 
        {
            this.proxyServer = proxyServer;
        }
        public void Book(int id, int val)
        {
            this.proxyServer.BookRoom(id, val);
        }
    }
}
