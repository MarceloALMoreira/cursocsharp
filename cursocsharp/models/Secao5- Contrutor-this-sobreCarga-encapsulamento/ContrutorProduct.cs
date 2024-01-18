using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocsharp.models.Secao5__Contrutor_this_sobreCarga_encapsulamento
{
    internal class ContrutorProduct
    {

        //Vamos refatorar Produto da Seção 4 Passando contructor
        public string Name;
        public double Price;
        public int Quantity;

        // Criando primeiro contrutor
        public ContrutorProduct(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }


        //Metedos da classe
        public double ValorTotalEmEstoque()
        {
            return Price * Quantity;
        }

        public void AdicionarProdutos(int quantity)
        {
            Quantity = Quantity + quantity;

            // OU Quantity += quantity;
        }

        public void RemoverProdutos(int quantity)
        {
            Quantity = Quantity - quantity;
            // OU Quantity -= quantity;
        }

        //Vamos Converter um object para String usando o ToString()

        public override string ToString()
        {
            return Name
                + ", R$ "
                + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantity
                + " unidade, total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}

