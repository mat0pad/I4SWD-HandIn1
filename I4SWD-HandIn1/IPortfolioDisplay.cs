﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace I4SWD_HandIn1
{
    public interface IPortfolioDisplay
    {
        void PrintPortfolio(Portfolio pf, int indexChanged = -1);
    }
}
