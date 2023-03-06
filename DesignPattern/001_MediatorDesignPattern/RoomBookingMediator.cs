using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_MemntoDesignPattern
{
    internal class RoomBookingMediator
    {
        static object lockObj = new object();
        ConcurrentDictionary<int, int> roomsBooked = new ConcurrentDictionary<int, int>();
        int TotalRoomsAvailable;
        public RoomBookingMediator(int totalRoomsAvailable)
        {
            this.TotalRoomsAvailable = totalRoomsAvailable;
        }
        public void Print()
        {
            var dict = new Dictionary<int, int>();
            foreach (var k in roomsBooked.Keys)
            {
                var val = roomsBooked[k];
                if (!dict.ContainsKey(val)) dict.Add(val, 0);
                dict[val]++;
            }
            foreach (var k in dict.Keys)
            {
                Console.WriteLine(k + "-" + dict[k]);
            }
        }
        public bool BookRoom(int roomNo, int Req)
        {
            if(TotalRoomsAvailable < roomNo)
            {
                return false;
            }
            return roomsBooked.TryAdd(roomNo, Req);
        }
    }
}
