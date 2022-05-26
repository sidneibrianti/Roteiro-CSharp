// See https://aka.ms/new-console-template for more information
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;

Console.WriteLine("String");
Console.WriteLine("----------------------");

AtribuicaoLiteral();
CompareTo();
Contains();
StartsWith();
Equals();
IndexOf();
ToLowerToUpper();
Insert();
Length();
Remove();
Replace();
Split();
Substring();
Trim();
Append();
Regex();
Compare();

//Console.ReadKey();

void AtribuicaoLiteral()
{
    var texto = "Testando " + " ";
    var texto2 = $"Testando {texto}";
    var texto3 = $"Testando {1 + 1}";
    var texto4 = @"\Testando \\";
    Console.WriteLine(texto);
    Console.WriteLine(texto2);
    Console.WriteLine(texto3);
    Console.WriteLine(texto4);
    Console.WriteLine();
}

void CompareTo()
{
    var texto = "Testando";
    Console.WriteLine(texto.CompareTo("Testando")); // Retorna 0 
    Console.WriteLine(texto.CompareTo("testando")); // Retorna 1
    Console.WriteLine(texto.CompareTo("")); // Retorna 1
    Console.WriteLine(texto.CompareTo(null)); // Retorna 1
    Console.WriteLine();
}

void Contains()
{
    var texto = "Este é um texto de teste";
    Console.WriteLine(texto.Contains("teste")); // true
    Console.WriteLine(texto.Contains("Teste")); // false
    Console.WriteLine(texto.Contains("Teste", StringComparison.OrdinalIgnoreCase)); // true
    //Console.WriteLine(texto.Contains(null)); // ERRO
    Console.WriteLine();
}

void StartsWith()
{
    var texto = "Este é um texto de teste";
    Console.WriteLine(texto.StartsWith("Este")); // true
    Console.WriteLine(texto.StartsWith("este")); // false
    Console.WriteLine(texto.StartsWith("este", StringComparison.OrdinalIgnoreCase)); // true
    Console.WriteLine(texto.EndsWith("Teste")); // false
    Console.WriteLine(texto.EndsWith("teste")); // true
    Console.WriteLine(texto.EndsWith("teste", StringComparison.OrdinalIgnoreCase)); // true
}

void Equals()
{
    var texto = "Este é um texto de teste";
    Console.WriteLine(texto.Equals("Este é um texto de teste")); // true
    Console.WriteLine(texto.Equals("este é um texto de teste")); // false
    Console.WriteLine(texto.Equals("este é um texto de teste", StringComparison.OrdinalIgnoreCase)); // true
}

void IndexOf()
{
    var texto = "Este é um texto de teste";
    Console.WriteLine(texto.IndexOf("e"));
    Console.WriteLine(texto.LastIndexOf("s"));
}

void ToLowerToUpper()
{
    var texto = "Este é um texto de teste";
    Console.WriteLine(texto.ToLower());
    Console.WriteLine(texto.ToUpper());
}

void Insert()
{
    var texto = "Este é um texto de teste";
    Console.WriteLine(texto.Insert(5, "AQUI "));
}

void Length()
{
    var texto = "Este é um texto de teste";
    Console.WriteLine(texto.Length);
}

void Remove()
{
    var texto = "Este é um texto de teste";
    Console.WriteLine(texto.Remove(0, 5));
}

void Replace()
{
    var texto = "Este é um texto de teste";
    Console.WriteLine(texto.Replace("Este", "Isto"));
    Console.WriteLine(texto.Replace("texto", "exemplo"));
}

void Split()
{
    var texto = "Este é um texto, de teste";
    var divisao = texto.Split(',');
    Console.WriteLine(divisao[0]);
    Console.WriteLine(divisao[1]);
    //Console.WriteLine(divisao[2]); // Exception
}

void Substring()
{
    var texto = "Este é um texto de teste";
    Console.WriteLine(texto.Substring(0, 5));
    Console.WriteLine(texto.Substring(texto.LastIndexOf(" ") + 1, 5));
}

void Trim()
{
    var texto = "Este é           um texto de teste";
    Console.WriteLine(texto.Trim());

    texto = "       Este é um texto de teste             ";
    Console.WriteLine(texto.Trim());
}

void Append()
{
    var texto = new StringBuilder();
    texto.Append("Est");
    texto.Append("e");
    texto.Append('é'); // Quando for um unico caracter podemos usa '' por ser char.
    texto.Append("um");
    texto.Append(Environment.NewLine);
    texto.Append("texto");
    Console.WriteLine(texto.ToString());
}

void Regex()
{
    // https://regexr.com/
    // Esse tema será tradao em separado em um tópico mais avançado
    var regex = new Regex(@"([0-9])\w+");
    Console.WriteLine(regex.IsMatch("Este é um texto de teste"));
    Console.WriteLine(regex.IsMatch("Este 25 um texto de teste"));
}

void Compare()
{
    Console.WriteLine(
                string.Compare(
                    "texto",
                    "texto"));

    Console.WriteLine(
        string.Compare(
            "Isto é um texto",
            "Isto e um texto",
            CultureInfo.CurrentCulture,
            CompareOptions.IgnoreNonSpace));

    Console.WriteLine(
        string.Compare(
            "Isto é um texto",
            "isto e um texto",
            CultureInfo.CurrentCulture,
            CompareOptions.IgnoreNonSpace));

    Console.WriteLine(
        string.Compare(
            "Isto é um texto",
            "isto e um texto",
            CultureInfo.CurrentCulture,
            CompareOptions.IgnoreSymbols));
}