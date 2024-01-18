using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocsharp.models.Secao3_RecapitulacaoLogicaDeProgramcao
{
    internal class OperadoresLogicos
    {
        public void operadoreLogico()
        {
            // aqui estamos usando o operador "E --> &&"
            bool c1 = 2 > 3 && 4 != 5;  // false
            bool c2 = 5 > 4 && 6 != 7; // true

            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine();
            Console.WriteLine("---------------------------");

            // aqui estamos usando o operador "OU --> ||"
            string nome = "Marcelo";

            if (nome == "Marcelo" || nome == "Almeida") // ou nome é Marcelo OU Almeida
            {
                Console.WriteLine("O nome é Marcelo Almeida");
            }
            else
            {
                Console.WriteLine("O Nome não é Marcelo Almeida");
            }

            bool c3 = 2 > 3 || 4 != 5; // ou um é verdade OU a outra

            Console.WriteLine(c3);
            Console.WriteLine("---------------------------");

            // aqui estamos usando o operador "NÃO --> !"
            bool numero = !(2 > 3) && 4 != 5;
            Console.WriteLine(numero);

        }
    }
}
