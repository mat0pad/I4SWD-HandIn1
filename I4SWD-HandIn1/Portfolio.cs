using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I4SWD_HandIn1
{
    public class Portfolio : IPortfolio
    {
        private IPortfolioDisplay Display;
        private List<Stock> Stocks = new List<Stock>();

        public Portfolio(IPortfolioDisplay display)
        {
            Display = display;
        }

        public void AddStock(Stock stock)
        {
            stock.Attach(this);
            Stocks.Add(stock);
        }

        public void Update(Stock stock)
        {
            Display.PrintPortfolio();
        }
    }
}
