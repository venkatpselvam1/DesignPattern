using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_ProxyDesignPattern
{
    internal interface IServer
    {
        bool BookRoom(int id, int count);
    }
}
