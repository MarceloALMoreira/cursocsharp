using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace cursocsharp.models.Secao5__Contrutor_this_sobreCarga_encapsulamento
{
    internal class EncapsulamentoProduto
    {
        // Propriedades encapsuladas
        private string _name;
        private double _price;
        private int _quantity;


        //Construtor Padrão 
        public EncapsulamentoProduto()
        {
            _quantity = 0;
        }

        // Construtor Usando o this para acessar outro contrutor
     

        // Construtor para inicialização dos atributos
        public EncapsulamentoProduto(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        // Criando os Metedos get e Set para os atributos da classe
        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            if (name != null && name.Length > 1)
            {
                _name = name;
            }
        }


        // Método para calcular o valor total em estoque
        public double ValorTotalEmEstoque()
        {
            return _price * _quantity;
        }

        // Método para adicionar produtos ao estoque
        public void AdicionarProdutos(int quantity)
        {
            _quantity += quantity;
        }

        // Método para remover produtos do estoque
        public void RemoverProdutos(int quantity)
        {
            _quantity -= quantity;
        }

        // Sobrescrevendo o método ToString para formatar a saída
        public override string ToString()
        {
            return _name
                + ", R$ "
                + _price.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantity
                + " unidade, total: R$ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
