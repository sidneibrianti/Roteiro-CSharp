Console.Clear();
Console.WriteLine("Listas e Tuplas");
Console.WriteLine();

Lista01();
Lista02();
Lista03();
Tuplas();

void Lista01()
{
    var nomes = new List<string> { "<name>", "Ana", "Felipe" };

    foreach (var nome in nomes)
    {
        Console.WriteLine($"Olá {nome.ToUpper()}!");
    }

    Console.WriteLine();
    nomes.Add("Maria");
    nomes.Add("Bill");
    nomes.Remove("Ana");
    foreach (var nome in nomes)
    {
        Console.WriteLine($"Olá {nome.ToLower()}!");
    }

}
void Lista02()
{
    List<string> nomes = new();
    Console.WriteLine();
    nomes.Add("<nome>");
    nomes.Add("Ana");
    nomes.Add("Felipe");

    foreach (var nome in nomes)
    {
        Console.WriteLine($"Olá {nome.ToUpper()}!");
    }

    Console.WriteLine();
    nomes.Add("Maria");
    nomes.Add("Bill");
    nomes.Remove("Ana");
    foreach (var nome in nomes)
    {
        Console.WriteLine($"Olá {nome.ToLower()}!");
    }

}
void Lista03()
{
    List<string> nomes = new List<string>
    {
        "<nome>",
        "Ana",
        "Felipe"
    };

    foreach (var nome in nomes)
    {
        Console.WriteLine($"Olá {nome.ToUpper()}!");
    }

    Console.WriteLine();
    nomes.Add("Maria");
    nomes.Add("Bill");
    nomes.Remove("Ana");
    foreach (var nome in nomes)
    {
        Console.WriteLine($"Olá {nome.ToLower()}!");
    }

}

void Tuplas()
{
    (double, int) t1 = (4.5, 3);
    Console.WriteLine($"Tuplas com elementos {t1.Item1} e {t1.Item2}.");


    (string Nome, int Idade) t2 = ("Pedro", 25);
    Console.WriteLine($"Nome: {t2.Nome}, Idade: {t2.Idade}.");
}