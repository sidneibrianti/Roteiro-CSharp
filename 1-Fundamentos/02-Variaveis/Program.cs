// See https://aka.ms/new-console-template for more information
Console.Clear();
Console.WriteLine("Variaveis");

NumerosIntegrais();
NumerosReais();
Caracteres();
Boolean();
Stringes();
VariaveisVar();
VariaveisObject();
VariaveisConstantes();
DataHora();
Structs();
Classes();
Enumeradores();



static void NumerosIntegrais()
{
    // Integral com sinal
    Console.WriteLine("Tipos Integral com sinal");
    Console.WriteLine("Tipo: sbyte: " + typeof(sbyte) + " => " + sizeof(sbyte) * 8 + "bits, de " + sbyte.MinValue + " a " + sbyte.MaxValue);
    Console.WriteLine("Tipo: short: " + typeof(short) + " => " + sizeof(short) * 8 + "bits, de " + short.MinValue + " a " + short.MaxValue);
    Console.WriteLine("Tipo: int: " + typeof(int) + " => " + sizeof(int) * 8 + "bits, de " + int.MinValue + " a " + int.MaxValue);
    Console.WriteLine("Tipo: long: " + typeof(long) + " => " + sizeof(long) * 8 + "bits, de " + long.MinValue + " a " + long.MaxValue);
    Console.WriteLine();
    // Integral sem sinal
    Console.WriteLine("Tipos Integral sem sinal");
    Console.WriteLine("Tipo: byte: " + typeof(byte) + " => " + sizeof(byte) * 8 + "bits, de " + byte.MinValue + " a " + byte.MaxValue);
    Console.WriteLine("Tipo: ushort: " + typeof(ushort) + " => " + sizeof(ushort) * 8 + "bits, de " + ushort.MinValue + " a " + ushort.MaxValue);
    Console.WriteLine("Tipo: uint: " + typeof(uint) + " => " + sizeof(uint) * 8 + "bits, de " + uint.MinValue + " a " + uint.MaxValue);
    Console.WriteLine("Tipo: ulong: " + typeof(ulong) + " => " + sizeof(ulong) * 8 + "bits, de " + ulong.MinValue + " a " + ulong.MaxValue);
    Console.WriteLine("---------------");

    // Declarando Variaveis

    // Integral com sinal
    sbyte inteiro1 = 10;
    short inteiro2 = 20;
    int inteiro3 = 30;
    long inteiro4 = 40L;
    Console.WriteLine(inteiro1);
    Console.WriteLine(inteiro2);
    Console.WriteLine(inteiro3);
    Console.WriteLine(inteiro4);
    Console.WriteLine("----------------");

    // Integral sem sinal
    byte inteiro5 = 10;
    ushort inteiro6 = 20;
    uint inteiro7 = 30;
    ulong inteiro8 = 40L;

    Console.WriteLine(inteiro5);
    Console.WriteLine(inteiro6);
    Console.WriteLine(inteiro7);
    Console.WriteLine(inteiro8);
    Console.WriteLine("----------------");

    // Variaveis por Referência
    int i = 16;
    ref int j = ref i;
    Console.WriteLine(i + " e " + j);
    j = 20;
    Console.WriteLine(i + " e " + j);

    string texto = "Hoje é Quarta-Feira";
    ref string texto2 = ref texto;
    Console.WriteLine(texto + " e " + texto2);
    texto2 = "O dia mudou!";
    Console.WriteLine(texto + " e " + texto2);

}

static void NumerosReais()
{
    Console.WriteLine("Tipos Reais");
    Console.WriteLine("Tipo: float: " + typeof(float) + " => " + sizeof(float) * 8 + "bits, de " + float.MinValue + " a " + float.MaxValue);
    Console.WriteLine("Tipo: double: " + typeof(double) + " => " + sizeof(double) * 8 + "bits, de " + double.MinValue + " a " + double.MaxValue);
    Console.WriteLine("Tipo: decimal: " + typeof(decimal) + " => " + sizeof(decimal) * 8 + "bits, de " + decimal.MinValue + " a " + decimal.MaxValue);
    Console.WriteLine();

    // Declarando Variaveis
    float real1 = 100.75f;
    double real2 = 12500.45;
    decimal real3 = 752538.457m;
    double? real4 = 1234.56; // O "?" indica que variavel poder ser nula.

    Console.WriteLine($"1-{real1}");
    Console.WriteLine("2-" + real2);
    Console.WriteLine("3-" + real3);
    Console.WriteLine("4-" + real4);
    real4 = null;
    Console.WriteLine("5-" + real4);
    real4 = 12.3456;
    Console.WriteLine("6-" + real4);

    Console.WriteLine();
}

static void Caracteres()
{
    /*
    A linguagem C# define as seguintes sequências de caracteres escape:

    Sequência Escape Representação
    \a      Sinal sonoro(alerta)
    \b      Backspace
    \f      Alimentação de formulário
    \n      Nova linha
    \r      Carriage return
    \t      Tabulação horizontal
    \v      Tabulação vertical
    \'      Aspas simples
    \"      Aspas duplas
    \\      Barra invertida
    \?      Interrogação
    \Ooo   Caractere ASCII na notação octal
    \xhh   Caractere ASCII na notação hexadecimal
    \xhhhh Caractere Unicode com código de valor hexadecimal xxxx. 
    \uhhhh Caractere Unicode com código de valor hexadecimal xxxx, onde hhhh pode assumir valores entre 0000 e ffff
    */


    char letra = '\u0041'; //https://www.fileformat.info/info/unicode/char/0041/index.htm
    char escape = '\n';
    char literal = 'C';
    Console.WriteLine("Tipos Caractere 'char'");
    Console.WriteLine("Tipo: char: " + typeof(char) + " => " + sizeof(char) * 8 + "bits");

    Console.WriteLine("\\u0041: " + letra);
    Console.WriteLine("\\n: " + escape);
    Console.WriteLine("C: " + literal);
    Console.WriteLine();
}

static void Boolean()
{
    bool receberSaldo = false;
    receberSaldo = true;
    Console.WriteLine("Tipo Boolean 'bool'");
    Console.WriteLine("Tipo: bool: " + typeof(bool) + " => " + sizeof(bool) * 8 + "bits");
    Console.WriteLine(receberSaldo);
    Console.WriteLine();
}

static void Stringes() 
{
    string texto1 = @"Lorem ipsum dolor sit amet,\n consectetur adipiscing elit.\n In fringilla.";
    string texto2 = "Lorem ipsum dolor sit amet,\n consectetur adipiscing elit.\n In fringilla.";
    string nome = "José";
    string sobrenome = "Silva";
    int idade = 26;
    string mensagem1;
    mensagem1 = texto1;
    // Concatenação
    string mensagem2 = "nome: " + nome;
    // Interpolação
    string mensagem3 = $"sobrenome: {sobrenome}";
    // Método String Format
    string mensagem4 = String.Format("nome: {0} e sobrenome: {1}, idade: {2}", nome, sobrenome, idade);
    mensagem1 = texto1;
    Console.WriteLine("Tipo String 'string'");
    Console.WriteLine("Tipo: string: " + typeof(string));
    Console.WriteLine(mensagem1);
    Console.WriteLine(mensagem2);
    Console.WriteLine(mensagem3);
    Console.WriteLine(mensagem4);
    Console.WriteLine(texto2);
    Console.WriteLine();
}

static void VariaveisVar()
{
    var valor = 100;
    valor = 20;
    //valor = "Lorem";  //Depois de atribuido um primeio valor inteiro não pode mais mudar o tipo da variavel 
    Console.WriteLine(valor);
    Console.WriteLine();
}

static void VariaveisObject()
{
    object obj = false;
    obj = 200;
    obj = "Has one stopped all it raven rustling on that i"; 
    Console.WriteLine(obj);
    Console.WriteLine();
}

static void VariaveisConstantes()
{
    const double pi = 3.1415;
    const string nome2 = "Herauf nebel sich tönen des";
    Console.WriteLine(nome2);
    Console.WriteLine(pi);
    Console.WriteLine();
}

static void DataHora()
{
    /*
     Specifier	        Description	                                            Output
        d	            Short Date	                                            12/8/2015
        D	            Long Date	                                            Tuesday, December 08, 2015
        t	            Short Time	                                            3:15 PM
        T	            Long Time	                                            3:15:19 PM
        f	            Full date and time	                                    Tuesday, December 08, 2015 3:15 PM
        F	            Full date and time (long)	                            Tuesday, December 08, 2015 3:15:19 PM
        g	            Default date and time	                                12/8/2015 15:15
        G	            Default date and time (long)	                        12/8/2015 15:15
        M	            Day / Month	                                            8-Dec
        r	            RFC1123 date	                                        Tue, 08 Dec 2015 15:15:19 GMT
        s	            Sortable date/time	                                    2015-12-08T15:15:19
        u	            Universal time, local timezone	                        2015-12-08 15:15:19Z
        Y	            Month / Year	                                        December, 2015
        dd	            Day	                                                    8
        ddd             Short Day Name	                                        Tue
        dddd	        Full Day Name	                                        Tuesday
        hh	            2 digit hour	                                        3
        HH	            2 digit hour (24 hour)	                                15
        mm	            2 digit minute	                                        15
        MM	            Month	                                                12
        MMM	            Short Month name	                                    Dec
        MMMM	        Month name	                                            December
        ss	            seconds	                                                19
        fff	            milliseconds	                                        120
        FFF	            milliseconds without trailing zero                      12
        tt	            AM/PM	                                                PM
        yy	            2 digit year	                                        15
        yyyy	        4 digit year	                                        2015
        :	            Hours, minutes, seconds separator, e.g. {0:hh:mm:ss}    9:08:59
        /	            Year, month , day separator, e.g. {0:dd/MM/yyyy}	    8/4/2007
    */
    


    DateTime dateTime = new();
    Console.WriteLine("Método DateTime 'DateTime'");
    Console.WriteLine(dateTime);
    dateTime = DateTime.Now;
    Console.WriteLine(dateTime);
    Console.WriteLine(dateTime.ToString("r"));
    dateTime = new DateTime(2022, 04, 01, 10, 30, 45);
    Console.WriteLine(dateTime);
    Console.WriteLine(dateTime.ToString("F"));
    Console.WriteLine($"Min:{DateTime.MinValue} Max:{DateTime.MaxValue} Now:{DateTime.Now}");
}



void Structs()
{
    Dados dados = new Dados();

    dados.valor = 10;

    Console.WriteLine(dados.valor);
}

void Classes()
{
    DadosClasses dadosClasses = new DadosClasses(10,1971,"Sidnei");

    dadosClasses.Resultado();

    dadosClasses.Nome = "Brianti";

    dadosClasses.Resultado();
    
}

void Enumeradores()
{
    Console.WriteLine("Enun 'enun'");
    Console.WriteLine(DiasdaSemana.Domingo);
    Console.WriteLine(DiasdaSemana.Segunda_Feira);
    Console.WriteLine(DiasdaSemana.Terça_Feira);
    Console.WriteLine(DiasdaSemana.Quarta_Feira);
    Console.WriteLine(DiasdaSemana.Quinta_Feira);
    Console.WriteLine(DiasdaSemana.Sexta_Feira);
    Console.WriteLine(DiasdaSemana.Sabado);
    Console.WriteLine();
}

struct Dados
{
    public int valor;
    /// <summary>
    /// Initializes a new instance of the <see cref="Dados"/> class.
    /// </summary>
    /// <param name="_valor">The _valor.</param>
    public Dados(int _valor)
    {
        valor = _valor;
    }
}
/// <summary>
/// The dados.
/// </summary>

class DadosClasses
{
    // Fields ou Campos
    public int valor;
    public int ano;
    private string? nome;

    // Properties ou Propriedades
    /// <summary>
    /// Gets or sets the nome.
    /// </summary>
    public string? Nome
    {
        get
        {
            return nome;
        }
        set => nome = value;
    }

    // Constructor ou Construtor
    /// <summary>
    /// Initializes a new instance of the <see cref="DadosClasses"/> class.
    /// </summary>
    /// <param name="_valor">The _valor.</param>
    /// <param name="ano">The ano.</param>
    /// <param name="nome">The nome.</param>
    public DadosClasses(int _valor, int ano, string nome)
    {
        valor = _valor;
        this.ano = ano;
        this.nome = nome;
    }

    // Methods ou Métodos
    /// <summary>
    /// Resultados the.
    /// </summary>
    public void Resultado()
    {
        Console.WriteLine(nome + " tinha o valor de " + valor + " no ano " + ano);
    }
}
/// <summary>
/// The dias da semana.
/// </summary>

enum DiasdaSemana
{
    Domingo,
    Segunda_Feira,
    Terça_Feira,
    Quarta_Feira,
    Quinta_Feira,
    Sexta_Feira,
    Sabado
}


