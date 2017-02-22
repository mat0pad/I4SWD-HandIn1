using System.Collections.Generic;

namespace I4SWD_HandIn1
{
    public abstract class Stock
    {
        private List<IPortfolio> portfolios;

        public Stock(double stateOfStock, string name, double amount)
        {
            StateOfstock = stateOfStock;
            Name = name;
            Amount = amount;

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

        public void Notify()
        {
            foreach (var item in portfolios)
            {
                item.Update(this);
            }
        }
    
        public double StateOfstock { get; private set; }
        public string Name { get; private set; }
        public double Amount { get; private set; }

        public void SetStateOfstock(double stateOfStock)
        {
            StateOfstock = stateOfStock;
            Notify();
        }
        public void SetName(string name)
        {
            Name = name;
            Notify();
        }
        public void SetAmount(double amount)
        {
            Amount = amount;
            Notify();
        }
    }
}