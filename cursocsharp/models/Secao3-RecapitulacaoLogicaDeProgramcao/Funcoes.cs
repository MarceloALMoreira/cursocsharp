using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocsharp.models.Secao3_RecapitulacaoLogicaDeProgramcao
{
    internal class Funcoes
    {
        public void PrimeiraFuncao()
        {
            Console.WriteLine("Digite três Número para saber qual o maior: ");

            Console.Write("Numero 1: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Numero 2: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Numero 3: ");
            int n3 = int.Parse(Console.ReadLine());

            int resultado = verificaMaior(n1, n2, n3);

            Console.WriteLine("Maior = " + resultado);

        }

        public int verificaMaior(int a, int b, int c)
        {

            int m;
            if (a > b && a > c)
            {
                m = a;
            }
            else if (b > c)
            {
                m = b;
            }
            else
            {
                m = c;
            }
            return m;

            //return Math.Max(Math.Max(a, b), c


            //Podemos simplificar assim tambem. 

            //Math no namespace System possui um método Max que retorna o maior valor entre dois números.
        }
    }
}
