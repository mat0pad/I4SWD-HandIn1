using System.Collections.Generic;

namespace I4SWD_HandIn1
{
    public abstract class Stock
    {
        private List<IPortfolio> portfolios;

        public Stock()
        {
            portfolios = new List<IPortfolio>();
        }

        public void Attach(IPortfolio p)
        {
            portfolios.Add(p);
        }

        public void Detach(IPortfolio p)
        {
            portfolios.Remove(p);
        }

        public void Notify(ConcreteStock stock)
        {
            foreach (var item in portfolios)
            {
                item.Update(stock);
            }
        }

        
    }
}