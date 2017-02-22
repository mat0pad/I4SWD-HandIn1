using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I4SWD_HandIn1
{
    public class Portfolio : IPortfolio
    {
<<<<<<< HEAD

        private IPortfolioDisplay Display;
        public List<Stock> Stocks = new List<Stock>();
=======
        public IPortfolioDisplay Display;
        private List<Stock> Stocks = new List<Stock>();
>>>>>>> fccd0c022c01809bf23cd52a04c0113b8a4a29cd
        public double TotalValue { get; set; } = 0;
        public string Name { get; set; }

        public Portfolio(string name , IPortfolioDisplay display)
        {
            Name = name;
            Display = display;
        }

        public void AddStock(Stock stock)
        {
            stock.Attach(this);
            Stocks.Add(stock);

            TotalValue += stock.StateOfstock;
        }

        public void Update(Stock s)
        {
            foreach (var item in Stocks)
            {
                if (item.Name == s.Name)
                {
                    TotalValue += item.StateOfstock - s.StateOfstock;
                    item.SetAmount(s.Amount);
                    item.SetStateOfstock(s.StateOfstock);
                    break;
                }
                TotalValue += s.StateOfstock;
            }
        }
    }
}
