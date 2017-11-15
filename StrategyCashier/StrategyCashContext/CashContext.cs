using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyCashier.StrategyCashContext
{
    public class CashContext
    {
        private CashSuper cs;

        public CashContext(CashSuper csuper)
        {
            this.cs = csuper;
        }

        public double GetResult(double money)
        {
            return cs.AcceptCash(money);
        }
    }
}
