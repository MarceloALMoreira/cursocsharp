using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocsharp.models.Secao3_RecapitulacaoLogicaDeProgramcao
{
    internal class ConvessaImplicitaECasting
    {
        public void convesaoImplicitaEcasting() 
        {
            Console.WriteLine("Conversão implicita e casting em C#\n");

            /*Aqui o numerro numero inteiro passa receber o valor do numero double, onde nao da certo porque 
             o numero inteiro so tem bits e o tipo double tem 8 bits. para isso devemos fazer o "casting" 
            */

            int numeroInteiro = 50;
            double numeroDouble = 5.50;

            numeroInteiro = (int)numeroDouble;

            Console.WriteLine(numeroInteiro);
            Console.WriteLine();

            /*
                Aqui vamos ver um numero inteiro divido por outro inteiro onde o resultado tem que ser um double

            int nota1 = 5;
            int nota2 = 2;

            double resultado =  nota1 / nota2;
            Nesse caso temos que fazer um casting tambem para o tipo que eu quero converter. 
            eu faço um casting da nota1 para double onde o resultado vai ser um double, assim nao tenho numero quebrado.
             */

            int nota1 = 5;
            int nota2 = 2;

            double resultado = (double)nota1 / nota2;
            Console.WriteLine(resultado);

            Console.WriteLine("----------------Marcelo Almeida----------------\n");
        }

    }
}
