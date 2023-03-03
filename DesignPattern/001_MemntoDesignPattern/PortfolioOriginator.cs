using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_MemntoDesignPattern
{
    internal class PortfolioOriginator
    {
        public int MutualFund, Stock, Bond, Deposit;
        public PortfolioMemento GetMemento()
        {
            var memento = new PortfolioMemento();
            memento.Values[0] = MutualFund;
            memento.Values[1] = Stock;
            memento.Values[2] = Bond;
            memento.Values[3] = Deposit;
            return memento;
        }
        public void SetMemento(PortfolioMemento memento)
        {
            if (memento == null) return;
            MutualFund = memento.Values[0];
            Stock = memento.Values[1];
            Bond = memento.Values[2];
            Deposit = memento.Values[3];
        }
        public void Operation(int type, int val)
        {
            switch(type) { 
            case 0:
                    MutualFund += val;
                    break;
            case 1:
                    Stock += val;
                    break;
            case 2:
                    Bond += val;
                    break;
            case 3:
                    Deposit += val;
                    break;
            }
        }
        public override string ToString()
        {
            return "MutualFunds : "+MutualFund
                + "Stock : " + Stock
                + "Bond : " + Bond
                + "Deposit : " + Deposit; 
        }
    }
}
