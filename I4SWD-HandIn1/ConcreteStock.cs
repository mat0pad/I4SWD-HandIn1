using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I4SWD_HandIn1
{
    class ConcreteStock :  Stock
    {
        public ConcreteStock(double StackOfStock, string Name, double Amount)
        {
            stackOfstock = StackOfStock;
            name = Name;
            amount = Amount;
        }
        public double stackOfstock { get; set; }
        public string name { get; set; }
        public double amount { get; set; }

        public void SetStackOfstock(double StackOfStock)
        {
            this.stackOfstock = StackOfStock;
            Notify();
        }
        public void SetName(string Name)
        {
            name = Name;
            Notify();
        }
        public void SetAmount(double Amount)
        {
            amount = Amount;
            Notify();
        }
        Stock GetState()
        {
            return this;
        }


    }
}
