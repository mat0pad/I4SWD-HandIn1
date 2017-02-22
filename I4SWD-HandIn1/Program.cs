using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            var thread1 = new Thread( () => StockThread(stock1));
            var thread2 = new Thread(() => StockThread(stock2));
            var thread3 = new Thread(() => StockThread(stock3));
            var thread4 = new Thread(() => StockThread(stock4));

            thread1.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
        }

        public static void StockThread(Stock stock)
        {
            Random rnd = new Random();

            int initialStockValue = (int) stock.StateOfstock;

            Thread.Sleep(rnd.Next(1, 13) * 2000);

            for (int i = 0; i < 11; i++)
            {
                double newValue = (double) rnd.Next((int) (initialStockValue * 0.95), (int)(initialStockValue * 1.05));
                stock.SetStateOfstock(newValue);

                int time = rnd.Next(1, 13);
                Thread.Sleep(time * 1500);
            }
            
        }

    }
}
