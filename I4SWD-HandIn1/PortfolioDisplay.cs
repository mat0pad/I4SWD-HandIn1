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
        public void PrintPortfolio(Portfolio pf,  int indexChanged = -1)
        {
            StringBuilder sb = new StringBuilder();
            
            foreach (var item in pf.Stocks)
            {
               sb.Append(PrintStock(item, pf.Stocks.IndexOf(item) == indexChanged));
            }


            Console.WriteLine("\n\n- - - - - - - - - - - - - - - - - - - - -\nPortfollio:" + $"{pf.Name}\n" + $"{sb.ToString()}\n\nTotal value:  " + pf.TotalValue.ToString("C", CultureInfo.CreateSpecificCulture("da-DK")));
        }

        public string PrintStock(ConcreteStock printme, bool changed = false)
        {
            string s = $"Name: {printme.Name} \t|\t Amount: {printme.Amount} \t|\t Value: {printme.StateOfstock}" + (changed != true ? "" : "\t#") + "\n";

            return s;
        }
    }
}
