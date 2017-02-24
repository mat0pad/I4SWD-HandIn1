using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I4SWD_HandIn1
{
    public class ConcreteStock : Stock
    {
        public double StateOfstock { get; private set; }
        public string Name { get; private set; }
        public double Amount { get; private set; }

        public ConcreteStock(double stateOfStock, string name, double amount)
        {
            StateOfstock = stateOfStock;
            Name = name;
            Amount = amount;
        }

        public void SetStateOfstock(double stateOfStock)
        {
            StateOfstock = stateOfStock;
            Notify(this);
        }
        public void SetName(string name)
        {
            Name = name;
            Notify(this);
        }
        public void SetAmount(double amount)
        {
            Amount = amount;
            Notify(this);
        }
    }
}
