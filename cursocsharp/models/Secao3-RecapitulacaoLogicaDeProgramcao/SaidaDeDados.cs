using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocsharp.models.Secao3_RecapitulacaoLogicaDeProgramcao
{
    internal class SaidaDeDados
    {
        public void saidaDeDados()
        {
            // Converter numero com virgula para numero com ponto.

            double ValorAReceber = 2430.75;

            Console.WriteLine("Seu valor a receber é: " + ValorAReceber.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("----------------Marcelo Almeida----------------\n");
        }
    }
}
