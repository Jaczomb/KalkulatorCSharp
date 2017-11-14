using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    interface ICalc
    {
        decimal Dodawanie(decimal a, decimal b);
        decimal Odejmowanie(decimal a, decimal b);
        decimal Mnozenie(decimal a, decimal b);
        decimal Dzielenie(decimal a, decimal b);

    }
}
