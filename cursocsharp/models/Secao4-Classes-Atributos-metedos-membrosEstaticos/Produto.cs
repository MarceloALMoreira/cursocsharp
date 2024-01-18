using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursocsharp.models.Secao4_Classes_Atributos_metedos_membrosEstaticos
{
    internal class Produto
    {
        /* 
         * Aqui vamos aprender usar o Object To String
         • Discussão
            • Toda classe em C# é uma subclasse da classe Object
            • Object possui os seguintes métodos:
            • GetType - retorna o tipo do objeto
            • Equals - compara se o objeto é igual a outro
            • GetHashCode - retorna um código hash do objeto
            • ToString - converte o objeto para string
        */


        //Atributos da classe
        public string Name;
        public double Price;
        public int Quantity;


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
