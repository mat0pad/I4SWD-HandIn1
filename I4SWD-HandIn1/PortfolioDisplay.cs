using System;
using System.Collections.Generic;
using System.Globalization;
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

        public void PrintPortfolio(Portfolio pf, bool changed = false, int indexChanged = -1)
        {
            Console.WriteLine("\n- - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine("Portfollio: {0}\n",pf.Name);
            foreach (var item in pf.Stocks)
            {
                if (!changed)
                    PrintStock(item);
                else
                    PrintStock(item, pf.Stocks.IndexOf(item) == indexChanged);
            }

            Console.WriteLine("\nTotal value:  " + pf.TotalValue.ToString("C", CultureInfo.CreateSpecificCulture("da-DK")));
        }

        public void PrintStock(Stock printme, bool changed = false)
        {
            Console.WriteLine("Name: {0} \t|\t Amount: {1} \t|\t Value: {2}" + (changed != true ? "" : "\t#"), 
                printme.Name, printme.Amount, printme.StateOfstock);
        }
    }
}
