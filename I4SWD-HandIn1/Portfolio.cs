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
        public List<ConcreteStock> Stocks = new List<ConcreteStock>();

        public double TotalValue { get; set; } = 0;
        public string Name { get; set; }

        public Portfolio(string name , IPortfolioDisplay display)
        {
            Name = name;
            Display = display;
        }

        public void AddStock(ConcreteStock stock)
        {
            stock.Attach(this);
            Stocks.Add(stock);

            TotalValue += stock.StateOfstock * stock.Amount;
        }

        public void Update(ConcreteStock s)
        {
            TotalValue = 0;
            foreach (var item in Stocks)
                TotalValue += item.StateOfstock * item.Amount;

            foreach (var item in Stocks)
            {
                if (item.Name == s.Name)
                     Display.PrintPortfolio(this, Stocks.IndexOf(item));
            }  
            
        }
    }
}
