
Console.Clear();
Console.WriteLine("Estruturas de Repetição");
Console.WriteLine();
For();
While();
DoWhile();

void For()
{
    for (int i = 0; i <= 10; i++)
    {
        Console.WriteLine(i);
    }

    Console.WriteLine();

    for (int j = 10; j >= 0; j--)
    {
        Console.WriteLine(j);
    }

    Console.WriteLine();
    string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
    foreach (string i in cars)
    {
        Console.WriteLine(i);
    }

}

void While()
{
    int i = 0;
    while (i <= 10)
    {
        Console.WriteLine(i);
        i++;
    }
    Console.WriteLine();
}

void DoWhile()
{
    int i = 0;
    do
    {
        Console.WriteLine(i);
        i++;
    }
    while (i < 10);
}