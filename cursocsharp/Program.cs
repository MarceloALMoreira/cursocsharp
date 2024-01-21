// See https://aka.ms/new-console-template for more information



using cursocsharp.models.Secao3_RecapitulacaoLogicaDeProgramcao;
using cursocsharp.models.Secao4;
using cursocsharp.models.Secao4_Classes_Atributos_metedos_membrosEstaticos;
using cursocsharp.models.Secao5__Contrutor_this_sobreCarga_encapsulamento;
using System;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Linq;


/*  AULA 3 Recapitulação Logica de Programção em C# */

//chamaClasseTiposBasicos();

//chamaClasseValorMinimoEMaximo();

//chamaClasseSaidaDedados();

//chamaClassePlaceholdeInterpolacaoConcatenacao();

//chamaClasseConvessaoImplicitaECasting();

//chamaClasseOperadoresAritimeticos();

//chamaClasseEntradaDeDados();




// AULA 3 Funções 

//chamaClasseOperadoresComparativos();

//chamaClasseOperadoresLogicos();

//chamaClasseEstuturaCondicional();

//chamaClasseFuncao();

//chamaClasseEstruturaEquanto();

static void chamaClasseTiposBasicos()
{
    //Instancia da classe
    //TiposBasicos tipos = new TiposBasicos();

    //Ou acessar quando direto pela classe quando for static
    TiposBasicos.TiposBasicosDados();
}

static void chamaClasseValorMinimoEMaximo()
{
    ValorMinimoMaximo valor = new ValorMinimoMaximo();
    valor.valoresMinimoEMaximo();
}

static void chamaClasseSaidaDedados()
{
    SaidaDeDados saida = new SaidaDeDados();

    saida.saidaDeDados();
}

static void chamaClassePlaceholdeInterpolacaoConcatenacao()
{
    PlaceholdeInterpolacaoConcatenacao placeholde = new PlaceholdeInterpolacaoConcatenacao();
    placeholde.placeholdInterpolacaoConcatencao();
}

static void chamaClasseConvessaoImplicitaECasting()
{
    ConvessaImplicitaECasting convesaoECasting = new ConvessaImplicitaECasting();
    convesaoECasting.convesaoImplicitaEcasting();
}

static void chamaClasseOperadoresAritimeticos()
{
    OperadoresAritimeticos operador = new OperadoresAritimeticos();
    operador.operadoresAritmetico();
}

static void chamaClasseEntradaDeDados()
{
    EntradaDeDados entrada = new EntradaDeDados();
    entrada.entradaDeDados();
}

static void chamaClasseOperadoresComparativos()
{
    OperadoresComprativos operadorComprativo = new OperadoresComprativos();
    operadorComprativo.operadorComparativo();
}

static void chamaClasseOperadoresLogicos()
{
    OperadoresLogicos operadorLogicos = new OperadoresLogicos();
    operadorLogicos.operadoreLogico();
}

static void chamaClasseEstuturaCondicional()
{
    EstuturaCondicional estuturaCondigional = new EstuturaCondicional();
    estuturaCondigional.estruturaCondicionais();

    Pessoa.verificaIdadePessoa();

}

static void chamaClasseFuncao()
{
    Funcoes func = new Funcoes();
    func.PrimeiraFuncao();
}

static void chamaClasseEstruturaEquanto()
{
    EstruturaEquanto enquanto = new EstruturaEquanto();
    enquanto.enquanto();
}




/*  AULA 4 Classes, Atributos, Métodos, Membros Estaticos */

//chmaClasseProduto();

//chamaClasseRetangulo();

//chamaClasseFuncionario();

//chamaClasseConversorDeMoeda();

static void chmaClasseProduto()
{
    Produto produto = new Produto();

    Console.WriteLine("Entre os dados do produto:");
    Console.Write("Nome: ");
    produto.Name = Console.ReadLine();
    Console.Write("Preço: ");
    produto.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantidade no estoque: ");
    produto.Quantity = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine("Dados do produto: " + produto);
    Console.WriteLine();
    Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
    int quantity = int.Parse(Console.ReadLine());
    produto.AdicionarProdutos(quantity);
    Console.WriteLine();
    Console.WriteLine("Dados atualizados: " + produto);
    Console.WriteLine();
    Console.Write("Digite o número de produtos a ser removido do estoque: ");
    quantity = int.Parse(Console.ReadLine());
    produto.RemoverProdutos(quantity);
    Console.WriteLine();
    Console.WriteLine("Dados atualizados: " + produto);

}

static void chamaClasseRetangulo()
{
    Retangulo ret = new Retangulo();

    Console.WriteLine("Entre a largura e altura do retângulo: ");

    ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("AREA =  " + ret.Area().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("PERIMETRO = " + ret.Perimetro().ToString("F2", CultureInfo.InvariantCulture));
    Console.WriteLine("DIAGONAL = " + ret.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
}

static void chamaClasseFuncionario()
{
    Funcionario funcionario = new Funcionario();

    Console.WriteLine("Entre com o Nome do Funcionario");
    Console.WriteLine("---------------------------");

    Console.Write("Nome: ");
    funcionario.Nome = Console.ReadLine();

    Console.Write("Slário Brunto: ");
    funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.Write("Imposto: ");
    funcionario.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine();
    Console.WriteLine("Funcionário: " + funcionario);

    Console.WriteLine();

    Console.WriteLine("Deseja aumentar o salário em qual porcentagem? ");
    double porcent = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    funcionario.AumentaSalario(porcent);

    Console.WriteLine();
    Console.WriteLine("Dados atualizados: " + funcionario);




}

static void chamaClasseConversorDeMoeda()
{
    Console.WriteLine("Qaul é a contação do dólar? ");
    double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("Quantos dólares você vai comprar? ");
    double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    double result = ConversorDeMoeda.dolarParaReal(quantia, cotacao);

    Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));

}




/*  AULA 5 Contrutores*/

//chamaClasseContrutorProduct();

chamaClasseEncapsulamentoProduto();

static void chamaClasseContrutorProduct()
{

    /* Neste caso eu so vou poder fazer a instancia da classe ja sabendo que temos certeza que vem dados antes.
     * 
     * Por isso vamos criar variaveis auxiliar para receber os valores e passar no (contrutor) da classe product
     *  
    */


    // Aqui ja estamos recebendo o valor do usuario e passando na instancia da classe para o contrutor
    Console.WriteLine("Entre os dados do produto:");
    Console.Write("Nome: ");
    string name = Console.ReadLine();
    Console.Write("Preço: ");
    double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Quantidade no estoque: ");
    int quantity = int.Parse(Console.ReadLine());


    //Garantindo que ja temos valores que recebemos nas variaveis auxilares.
    ContrutorProduct produto = new ContrutorProduct(name, price, quantity);

    Console.WriteLine();
    Console.WriteLine("Dados do produto: " + produto);
    Console.WriteLine();
    Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
    Console.WriteLine();
    quantity = int.Parse(Console.ReadLine());
    produto.AdicionarProdutos(quantity);
    Console.WriteLine();
    Console.WriteLine("Dados atualizados: " + produto);
    Console.WriteLine();
    Console.Write("Digite o número de produtos a ser removido do estoque: ");
    quantity = int.Parse(Console.ReadLine());
    produto.RemoverProdutos(quantity);
    Console.WriteLine();
    Console.WriteLine("Dados atualizados: " + produto);


    Console.WriteLine("Entra com o Produto 1 ");
    string name1 = Console.ReadLine();
    double price1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    int quantity1 = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



    //Exemplo de contrutor padrao
    ContrutorProduct produto1 = new ContrutorProduct
    {
        Name = name1,
        Price = price1,
        Quantity = quantity1
    };

    Console.WriteLine(produto1);





}

static void chamaClasseEncapsulamentoProduto()
{
    EncapsulamentoProduto produto = new EncapsulamentoProduto("TV", 500.00, 10);
    Console.WriteLine(produto.GetName());
    Console.Write("Digita um Novo nome para produto: ");

    string newName = Console.ReadLine();


    //produto.SetName(newName);

    //agora não preciso usar o setName para passar um nome valor eu posso usar como Atributo da classe

    produto.Name = newName;
    //produto.Price = 150.00;



    Console.WriteLine($"Seu produto é uma: {produto.Name}, no valor de {produto.Price.ToString("F2", CultureInfo.InvariantCulture)}");

}

