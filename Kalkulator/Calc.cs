using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Calc : ICalc
    {
        public decimal Dodawanie(decimal a, decimal b)
        {
            return a + b;
        }

        public decimal Dzielenie(decimal a, decimal b)
        {
            return a / b;
        }

        public decimal Mnozenie(decimal a, decimal b)
        {
            return a * b;
        }

        public decimal Odejmowanie(decimal a, decimal b)
        {
            return a - b;
        }
        public static bool txtKtore = true;
    }
}
