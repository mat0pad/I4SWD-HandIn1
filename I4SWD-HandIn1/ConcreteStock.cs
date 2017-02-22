using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I4SWD_HandIn1
{
    public class ConcreteStock :  Stock
    {
        public ConcreteStock(double stateOfStock, string name, double amount)
        {
            StateOfstock = stateOfStock;
            Name = name;
            Amount = amount;
        }
        public double StateOfstock { get; set; }
        public string Name { get; set; }
        public double Amount { get; set; }

        public void SetStateOfstock(double stateOfStock)
        {
            StateOfstock = stateOfStock;
            Notify();
        }
        public void SetName(string name)
        {
            Name = name;
            Notify();
        }
        public void SetAmount(double amount)
        {
            Amount = amount;
            Notify();
        }


    }
}
