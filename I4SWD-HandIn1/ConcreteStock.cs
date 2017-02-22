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
            : base(stateOfStock, name, amount)
        { 
        }

    }
}
