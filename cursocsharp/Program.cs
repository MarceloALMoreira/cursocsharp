// See https://aka.ms/new-console-template for more information



using cursocsharp.models.Secao3_RecapitulacaoLogicaDeProgramcao;
using cursocsharp.models.Secao4;
using System;
using System.Globalization;




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

static void chamaClasseEstuturaCondicional(){
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

//chamaClasseRetangulo();

//chamaClasseFuncionario();

//chamaClasseConversorDeMoeda();

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

