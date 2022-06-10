System.Console.Clear();
Console.WriteLine("Teste de Condições");
System.Console.WriteLine();

var condicao1 = true;
var condicao2 = false;
var condicao3 = true;

Console.WriteLine($"Condição 1: {condicao1}");
Console.WriteLine($"Condição 2: {condicao2}");
Console.WriteLine($"Condição 3: {condicao3}");

if (condicao1)
{
    Console.WriteLine($"Condição 1 é :{condicao1}");
}

if (!condicao2)
{
    Console.WriteLine($"Condição 2 é :{condicao2}");
}

if (condicao2)
{
    // Não vai entrar aqui!
} else
{
    Console.WriteLine($"Condição 2 é :{condicao2}");
}

if ((condicao1 && condicao2))
{
    Console.WriteLine("Aceitou a comparação AND");
}
else
{
    Console.WriteLine($"Não aceitou a condição AND: {condicao1 && condicao2}");
}

if (condicao1 && condicao3)
{
    Console.WriteLine($"Aceitou a comparação AND: { condicao1 && condicao3}");
}

if (condicao1 || condicao2)
{
    Console.WriteLine($"Aceitou a comparação OR: { condicao1 || condicao2}");
}

if (condicao2)
{
    //Não vai entrar
} else if (condicao1)
{
    Console.WriteLine($"else if ({condicao1})");
} else
{
    // Não vai entrar
}
var i = 1;
switch (i)
{
    case < 5:
        Console.WriteLine($"Case para 'i < 5' i = {i}");
        break;
    case > 5:
        Console.WriteLine($"Case para 'i > 5' i = {i}");
        break;

    default:
        break;
}
