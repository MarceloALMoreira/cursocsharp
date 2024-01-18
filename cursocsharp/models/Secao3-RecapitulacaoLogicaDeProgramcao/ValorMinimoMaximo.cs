using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocsharp.models.Secao3_RecapitulacaoLogicaDeProgramcao
{
    public class ValorMinimoMaximo
    {
       public void valoresMinimoEMaximo()
        {

            Console.WriteLine("Valor Mínimos e Máximos em C#\n");

            int valorMinimoInt = int.MinValue;
            int valorMaximoInt = int.MaxValue;

            Console.WriteLine($"Valor Mínimo Int: {valorMinimoInt}");
            Console.WriteLine($"Valor Máximo Int: {valorMaximoInt}");

            Console.WriteLine("*******************************************\n");

        }
    }
}
