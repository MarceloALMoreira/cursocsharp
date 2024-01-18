using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocsharp.models.Secao3_RecapitulacaoLogicaDeProgramcao
{
    internal class OperadoresComprativos
    {
        public void operadorComparativo()
        {
            //Aqui estamos usando o Operador Menor que < 
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine();
            Console.WriteLine("---------------------------");

            //Aqui estamos usando o Operador Maior que > 
            bool c3 = a > 10;
            bool c4 = a > 5;

            Console.WriteLine(c3);
            Console.WriteLine(c4);
            Console.WriteLine();
            Console.WriteLine("---------------------------");

            //Aqui estamos usando o Operador Menor Igual, Maior Igual, Igual e Diferente para comparar Valores.
            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;

            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
            Console.WriteLine();
            Console.WriteLine("---------------------------");


        }
    }
}
