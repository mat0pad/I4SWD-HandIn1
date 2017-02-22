using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I4SWD_HandIn1
{
    class PortfolioDisplay : IPortfolioDisplay
    {
        public void PrintAllPortfolios()
        {
            throw new NotImplementedException();
        }

        public void PrintPortfolio(Portfolio pf)
        {
            Console.WriteLine("Printing out Stocks for Portfollio: {0}",pf.Name);
            foreach (var item in pf.Stocks)
            {
                PrintStock(item);
            }
        }

        public void PrintStock(Stock printme)
        {
            Console.WriteLine("\nName is: {0}",printme.Name);
            Console.WriteLine("Amount is: {0}", printme.Amount);
            Console.WriteLine("State of the stock is: {0}", printme.StateOfstock);
        }
    }
}
