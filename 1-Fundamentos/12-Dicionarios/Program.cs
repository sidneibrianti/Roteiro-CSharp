Console.Clear();
Console.WriteLine("Dicionários");
Console.WriteLine();

Dicionario01();
Console.WriteLine();
Dicionario02();

void Dicionario01()
{
    var clientes = new Dictionary<int, Cliente>
    {
        { 1, new Cliente { Nome = "Pedro", SobreNome = "Silva" } },
        { 2, new Cliente { Nome = "João", SobreNome = "Severino" } },
        { 3, new Cliente { Nome = "Manoel", SobreNome = "Silvério" } }
    };

    foreach (KeyValuePair<int, Cliente> cliente in clientes)
    {
        Console.WriteLine($"Código Cliente:{cliente.Key} - Nome:{cliente.Value.Nome}, Sobrenome: {cliente.Value.SobreNome}");
    }
    Console.WriteLine();
    Console.WriteLine("Removendo um item!");
    Console.WriteLine();
    clientes.Remove(2);
    foreach (KeyValuePair<int, Cliente> cliente in clientes)
    {
        Console.WriteLine($"Código Cliente:{cliente.Key} - Nome:{cliente.Value.Nome}, Sobrenome: {cliente.Value.SobreNome}");
    }
}

void Dicionario02()
{
    var clientes = new Dictionary<int, Cliente>();
    clientes.Add(1, new Cliente { Nome = "Pedro", SobreNome = "Silva" });
    clientes.Add(2, new Cliente { Nome = "João", SobreNome = "Severino" });
    clientes.Add(3, new Cliente { Nome = "Manoel", SobreNome = "Silvério" });

    foreach (KeyValuePair<int, Cliente> cliente in clientes)
    {
        Console.WriteLine($"Código Cliente:{cliente.Key} - Nome:{cliente.Value.Nome}, Sobrenome: {cliente.Value.SobreNome}");
    }
    Console.WriteLine();
    Console.WriteLine("Removendo um item!");
    Console.WriteLine();
    clientes.Remove(2);
    foreach (KeyValuePair<int, Cliente> cliente in clientes)
    {
        Console.WriteLine($"Código Cliente:{cliente.Key} - Nome:{cliente.Value.Nome}, Sobrenome: {cliente.Value.SobreNome}");
    }
}
struct Cliente
{
    public string Nome;
    public string SobreNome;
    
}