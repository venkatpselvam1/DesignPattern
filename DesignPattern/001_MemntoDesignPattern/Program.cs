using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_MemntoDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Memento pattern is a behavioral design pattern.
             * Memento pattern is used to restore state of an object to a previous state.
             * 
             * e.g: undo/redo options are implemented using memnto design pattern
             * 
             * 
             * originator :
             * the object for which the state is to be saved. 
             * It creates the memento and uses it in future to undo.
             * 
             * 
             * memento : 
             * the object that is going to maintain the state of originator.
             * Its just a POJO.
             * 
             * 
             * caretaker :
             * the object that keeps track of multiple memento.
             * Like maintaining savepoints.
             * 
             */
            MementoDesignPatternPortforlio();
        }
        static int previouseOps = 0;//0 - added, 1 - undo, 2 - redo
        private static void MementoDesignPatternPortforlio()
        {
            var careTaker = new PortfolioCaretaker();
            var portforlio = new PortfolioOriginator();
            Console.WriteLine("portforlio: "+portforlio);
            while (true)
            {
                var cont = DoOperation(portforlio, careTaker);
                Console.WriteLine("portforlio: " + portforlio);
                if (!cont) break;
            }
        }

        private static bool DoOperation(PortfolioOriginator portforlio, PortfolioCaretaker careTaker)
        {
            Console.WriteLine("What operation you want to perform?\n0-Break\n1-AddMutuaFund\n2-AddStock\n3-AddBond\n4-Add\n5-Undo\n6-Redo");
            var str = Console.ReadLine();
            switch (str)
            {
                case "1":
                    portforlio.Operation(0, 100);
                    careTaker.Add(portforlio.GetMemento());
                    previouseOps = 0;
                    break;
                case "2":
                    portforlio.Operation(1, 100);
                    careTaker.Add(portforlio.GetMemento());
                    previouseOps = 0;
                    break;
                case "3":
                    portforlio.Operation(2, 100);
                    careTaker.Add(portforlio.GetMemento());
                    previouseOps = 0;
                    break;
                case "4":
                    portforlio.Operation(3, 100);
                    careTaker.Add(portforlio.GetMemento());
                    previouseOps = 0;
                    break;
                case "5":
                    if (previouseOps != 1) careTaker.Undo();
                    portforlio.SetMemento(careTaker.Undo());
                    previouseOps = 1;
                    break;
                case "6":
                    if (previouseOps != 2) careTaker.Redo();
                    portforlio.SetMemento(careTaker.Redo());
                    previouseOps = 2;
                    break;
                default:
                    return false;
            }
            return true;
        }
    }
}
