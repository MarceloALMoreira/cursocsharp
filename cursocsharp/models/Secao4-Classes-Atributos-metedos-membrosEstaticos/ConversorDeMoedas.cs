using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocsharp.models.Secao4
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.0;

        public static double dolarParaReal(double quantia, double contacao)
        {
            double total = quantia * contacao;
            return total + total * Iof / 100.0;
        }
    }
}
