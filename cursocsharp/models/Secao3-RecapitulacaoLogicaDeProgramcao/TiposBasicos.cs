using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocsharp.models.Secao3_RecapitulacaoLogicaDeProgramcao
{
    public static class TiposBasicos
    {
        public static  void TiposBasicosDados()
        {
            bool completo = false;
            char caracterUnicode = 'M';
            byte valorByte = 150;
            int valorInteiro = 42;
            long numeroLongo = 21421582L;
            float numeroFlotuante = 150.90F;
            double valorDouble = 123.45;
            string texto = "olá, mundo!";


            //O Tipo object aceita qualquer tipo, pois ele é um tipo genérico.
            //Toda classe em C# é uma subclasse de object

            object meuObjetoNome = "Jhon Brown";
            object meuObjetoNumero = 42;

            Console.WriteLine("*******************************************");

            Console.WriteLine("Tipos básicos em C#\n");


            Console.WriteLine("Valor bool: " + completo);
            Console.WriteLine("Valor char Unicode: " + caracterUnicode);
            Console.WriteLine("Valor byte: " + valorByte);
            Console.WriteLine("Valor Inteiro: " + valorInteiro);
            Console.WriteLine("Valor long: " + numeroLongo);
            Console.WriteLine("Valor Floate: " + numeroFlotuante);
            Console.WriteLine("Valor Double: " + valorDouble);
            Console.WriteLine("Texto: " + texto);
            Console.WriteLine("Valor do Objecto String: " + meuObjetoNome);
            Console.WriteLine("Valor do Objecto Número: " + meuObjetoNumero);

            Console.WriteLine("*******************************************\n");

        }

    }
}
