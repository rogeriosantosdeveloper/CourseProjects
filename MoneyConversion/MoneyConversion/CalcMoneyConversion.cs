using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyConversion
{
    class CalcMoneyConversion
    {
        public static double IOF = 6.0;
        public static double CalcIOF(double currency, double quantity)
        {
            double total = currency * quantity;
            return total + total * IOF / 100;
        }
    }
}
