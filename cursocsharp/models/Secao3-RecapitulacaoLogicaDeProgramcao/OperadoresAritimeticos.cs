using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocsharp.models.Secao3_RecapitulacaoLogicaDeProgramcao
{
    internal class OperadoresAritimeticos
    {
        public void operadoresAritmetico()
        {
            Console.WriteLine("Operadores aritméticos em C#\n");


            int valor1 = 50 + 30 * 2;
            int valor2 = (50 + 30) * 2;

            Console.WriteLine("50 + 30 * 2 = 110 " + " Aqui estamos utilizando os operador + e *");
            Console.WriteLine(valor1);
            Console.WriteLine();
            Console.WriteLine("(50 + 30) * 2 = 160 " + " Aqui estamos usando os (Parentes para definir um precedencia na soma e depos a multiplicação.)" );
            Console.WriteLine(valor2);


            Console.WriteLine("----------------Marcelo Almeida----------------\n");
        }
    }
}
