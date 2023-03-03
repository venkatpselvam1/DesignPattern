using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_MemntoDesignPattern
{
    internal class PortfolioCaretaker
    {
        public Stack<PortfolioMemento> Mementos = new Stack<PortfolioMemento>();
        public Stack<PortfolioMemento> RemovedMementos = new Stack<PortfolioMemento>();

        public void Add(PortfolioMemento memento)
        {
            Mementos.Push(memento);
            RemovedMementos = new Stack<PortfolioMemento>();
        }

        public PortfolioMemento Undo()
        {
            if(Mementos.Any())
            {
                var memnto = Mementos.Pop();
                RemovedMementos.Push(memnto);
                return memnto;
            }
            Console.WriteLine("Undo is not possible");
            return null;
        }
        public PortfolioMemento Redo()
        {
            if (RemovedMementos.Any())
            {
                var memnto = RemovedMementos.Pop();
                Mementos.Push(memnto);
                return memnto;
            }
            Console.WriteLine("Redo is not possible");
            return null;
        }
    }
}
