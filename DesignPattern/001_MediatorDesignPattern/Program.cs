using _001_MemntoDesignPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _001_MediatorDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Mediator is a behavioral design pattern that lets you reduce chaotic dependencies between objects. 
             * The pattern restricts direct communications between the objects and forces them to collaborate only via a mediator object.
             * 
             * E.G:
             * If we design a board game(like chess), 
             * the pieces will try to move to different position.
             * This movent are controlled by board obj.
             * The board,
             * -> can validate if the move is valid
             * -> It will removed the other pieces
             * -> It will decided if the player wins
             * 
             * The pieces are not allowed to talk to other pieces directly.
             * All the communication will through mediator.
             */

            /*
             * Aircraft pilots don’t talk to each other directly
             * when deciding who gets to land their plane next.
             * All communication goes through the control tower.
             */

            ExampleMementDesignPattern();
        }

        private static void ExampleMementDesignPattern()
        {
            //let's say we have organization of 100 members
            //the org have 1000 rooms numberred from 1 to 1000
            //We have a mediator who is resposible for allocating the room
            //to the employee on the basis of first come first server
            //each employee want to book all the rooms starting from some random no b/w 1 to 1000
            //if the room is already booked, we should return false
            var mediator = new RoomBookingMediator(1000);
            var rand = new Random();

            Parallel.For(1, 100, x =>
            {
                int start = rand.Next(0, 1000);
                Console.WriteLine(x +" starts with "+start);
                for(int i = 0; i <1000; i++) 
                {
                    var val = (start + i)%1000;
                    mediator.BookRoom(val, x);
                    Thread.Sleep(1);
                }
            });
            mediator.Print();
        }
    }
}
