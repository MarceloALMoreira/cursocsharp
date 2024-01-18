using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocsharp.models.Secao3_RecapitulacaoLogicaDeProgramcao
{
    internal class PlaceholdeInterpolacaoConcatenacao
    {
        public void placeholdInterpolacaoConcatencao()
        {
            int idade = 50;
            double saldo = 10.35521;
            string name = "João";

            Console.WriteLine("Placehold, Interpolação e concatenação em C#\n");


            //Placehold
            Console.WriteLine("Placehold");
            Console.WriteLine("{0} tem {1} anos, e tem saldo igual a {2:F2} reais.", name, idade, saldo);
            Console.WriteLine();
            //Interpolação
            Console.WriteLine("Interpolação");
            Console.WriteLine($"{name} tem {idade} anos, e tem saldo igual a {saldo.ToString("F2", CultureInfo.InvariantCulture)} reais.");
            Console.WriteLine();
            //Concatenação
            Console.WriteLine("Concatenação");
            Console.WriteLine(name + " tem " + idade + " anos, e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais.");
            Console.WriteLine();
            Console.WriteLine("----------------Marcelo Almeida----------------\n");

        }
    }
}