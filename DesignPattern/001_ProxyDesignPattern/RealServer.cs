using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _001_ProxyDesignPattern
{
    internal class RealServer : IServer
    {
        public bool BookRoom(int id, int count)
        {
            var dbSave = Save(id, count);
            if(dbSave)
            {
                Console.WriteLine("DB save passed");
            }
            else
            {
                Console.WriteLine("Error while saving in DB");
            }
            return dbSave;
        }
        private bool Save(int id, int count)
        {
            //randomly generating the DB error once in every 10 request
            return new Random().Next() * 10 != 5;
        }
    }
}
