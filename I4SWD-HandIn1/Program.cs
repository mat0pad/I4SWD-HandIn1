using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I4SWD_HandIn1
{
    class Program
    {
        static void Main(string[] args)
        {
            var stock1 = new ConcreteStock(934.0, "APPL", 200);
            var stock2 = new ConcreteStock(764, "GOOL", 24);
            var stock3 = new ConcreteStock(35.2, "YAOO", 10);
            var stock4 = new ConcreteStock(8.0, "JP", 543);

            var display = new PortfolioDisplay();

            var AntonPf = new Portfolio("Anton\'s pf", display);

            AntonPf.AddStock(stock1);
            AntonPf.AddStock(stock2);
            AntonPf.AddStock(stock3);
            AntonPf.AddStock(stock4);

            display.PrintPortfolio(AntonPf);

            stock3.SetStateOfstock(23);


            stock3.SetStateOfstock(21);

            stock2.SetStateOfstock(765);
        }
    }
}
