using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocsharp.models.Secao3_RecapitulacaoLogicaDeProgramcao
{
    internal class EntradaDeDados
    {

        public void entradaDeDados()
        {
            Console.WriteLine("Entrada de dados em C#\n");

            Console.WriteLine("Por favor Digite uma Fruta");
            Console.WriteLine();
            string fruta = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Você digitou: " + fruta);
            Console.WriteLine();
            Console.WriteLine("Agora Digita 3 Fruta diferente na mesma linha");
            string s = Console.ReadLine();
            string[] vet = s.Split(' '); // aqui eu posso usar o Console.ReadLine().Split() diretamente;
            string p1 = vet[0];
            string p2 = vet[1];
            string p3 = vet[2];
            Console.WriteLine();
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------\n");

            Console.WriteLine("Por favor Digite Seu Nome, Sexo Idade e Altura");

            //Aqui eu posso colocar um vetor e usar o spli(' ') para pegar o pedaco de cada frase e armazenar na variavel correspondente.

            //string[] vetorPessoa = Console.ReadLine().Split(' ');
            Console.WriteLine();

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Sexo: ");
            char sexo = char.Parse(Console.ReadLine());
            
            Console.Write("Idade: ");
            int idade1 = int.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Seu nome e: {nome} e voce e do sexo {sexo}, voce tem {idade1} anos de idade e tem {altura.ToString("F2", CultureInfo.InvariantCulture)} de altura.");
            Console.WriteLine();

            Console.WriteLine("(-----------------------------------------------\n");




            // Exercicio PARTE 2


            Console.WriteLine("Entre com seu nome completo:");
            string nome1 = Console.ReadLine();


            Console.WriteLine("Quantos quartos tem na sua casa?:");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha):");

            string[] vetor2 = Console.ReadLine().Split(' ');
            string lastName = vetor2[0];
            int idade2 = int.Parse(vetor2[1]);
            double altura2 = double.Parse(vetor2[2]);

            Console.WriteLine(nome1);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastName);
            Console.WriteLine(idade2);
            Console.WriteLine(altura2.ToString("F2", CultureInfo.InvariantCulture));


            Console.WriteLine("----------------Marcelo Almeida----------------\n");




        }
    }
}
