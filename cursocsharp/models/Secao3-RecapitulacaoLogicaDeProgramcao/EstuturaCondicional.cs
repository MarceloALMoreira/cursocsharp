using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocsharp.models.Secao3_RecapitulacaoLogicaDeProgramcao
{
    internal class EstuturaCondicional
    {
        public void estruturaCondicionais()

        {
            // Estrutura Simples
            Console.WriteLine("Digite o Valor do Produto:");

            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (price > 10) // Aqui dentro vem a condição.
            {
                //Aqui vem o comando a ser execultado pelo que definimos na condição.
                Console.WriteLine("O valor do produto é " + price.ToString("F2", CultureInfo.InvariantCulture));
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------");

            //Estrutura Composta
            Console.WriteLine("Digite o Seu nome:");
            string nome = Console.ReadLine();

            Console.WriteLine("Por favor Digite sua idade.");
            int idade = int.Parse(Console.ReadLine());

            if (idade == 18)
            {
                Console.WriteLine("Parabens " + nome + " Você pode entrar na festa.");

            }
            else
            {
                Console.WriteLine(nome + " você só tem " + idade + " Anos de idade, por isso não pode entrar.");
            }

            //Estrutura de Encadeamentos
            int condicao1 = 76;

            if (condicao1 < 40)
            {
                Console.WriteLine("O seu valor é " + condicao1 + " Atende para ser True. ");
            }
            else if (condicao1 != 40)
            {
                Console.WriteLine("O seu valor é " + condicao1 + " é Diferente de 40 Atende para ser 'else if' .");

            }
            else
            {
                Console.WriteLine("O seu valor é " + condicao1 + " Não Atende, por isso é 'False' para ser True.");

            }
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine("Digite a hora atual:");


            int hora = int.Parse(Console.ReadLine());

            if (hora < 12)
            {
                Console.WriteLine("Bom dia");
            }
            else if (hora < 18)
            {
                Console.WriteLine("Boa tarde");
            }
            else
            {
                Console.WriteLine("Boa noite");
            }
        }
    }

    internal  class Pessoa
    {
        string Nome;
        int Idade;


        public static void verificaIdadePessoa()
        {
            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa: ");
            Console.WriteLine("Nome: ");
            pessoa1.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            pessoa1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa: ");
            Console.WriteLine("Nome: ");
            pessoa2.Nome = Console.ReadLine();
            Console.WriteLine("Idade: ");
            pessoa2.Idade = int.Parse(Console.ReadLine());

            if (pessoa1.Idade > pessoa2.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa1.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + pessoa2.Nome);

            }
        }
    }
}
