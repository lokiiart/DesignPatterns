using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCashier.CashFactory
{
    public abstract class CashSuper
    {
        public abstract double AcceptCash(double money);
    }
}
