using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocsharp.models.Secao4
{
    public class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;


        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentaSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + SalarioBruto * porcentagem / 100.0;
        }

        // Usando o toString para concatenar

        public override string ToString()
        {
            return Nome
                + ", R$ "
                + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }


        //Verifica a Media salario dos funcionario --> Function <--
        public void verificaMediaSalarioFuncionario()
        {
            Funcionario funcionario1 = new Funcionario();
            Funcionario funcionario2 = new Funcionario();


            Console.WriteLine("Dados do primeiro funcionario");
            Console.Write("Nome");
            funcionario1.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do segundo funcionario");
            Console.Write("Nome");
            funcionario2.Nome = Console.ReadLine();
            Console.Write("Salário: ");
            funcionario2.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = (funcionario1.SalarioBruto + funcionario2.SalarioBruto) / 2.0;

            Console.WriteLine("Salario Medio = " + media.ToString("F2", CultureInfo.InvariantCulture));



        }
    }
}
