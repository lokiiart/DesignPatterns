using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryCashier.CashFactory
{
    public class CashFactory
    {
        public static CashSuper CreateCashAccept(string type)
        {
            CashSuper cs = null;
            switch (type)
            {
                case "CashNormal":
                    cs = new CashNormal();
                    break;

            }
            return cs;
        }
    }
}
