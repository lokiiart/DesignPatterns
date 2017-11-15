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

        //策略和工厂相结合，主要目的将判断放在Context中，这时候除了让客户端少认识一个类之外，没什么卵用
        public CashContext(string type)
        {
            switch(type)
            {
                case "CashNormal":
                    CashNormal CS0 = new CashNormal();
                    cs = CS0;
                    break;
            }
        }

        public double GetResult(double money)
        {
            return cs.AcceptCash(money);
        }
    }
}
