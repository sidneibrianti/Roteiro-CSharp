using System.Collections;

Console.Clear();
Console.WriteLine("Execeções");
Console.WriteLine();

var arr = new int[3];

try
{
    for (var index = 0; index < 10; index++)
        Console.WriteLine(arr[index]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine($"Erro - Message: {ex.Message}");
    Console.WriteLine($"Erro - StackTrace: {ex.StackTrace}");
    Console.WriteLine($"Erro - HResult: {ex.HResult}");
    Console.WriteLine($"Erro - InnerException: {ex.InnerException}");
    Console.WriteLine($"Erro - Source: {ex.Source}");
    Console.WriteLine($"Erro - TargetSite: {ex.TargetSite}");
}
try
{
    string s = "Informações.";
    int i = -903;
    DateTime dt = DateTime.Now;
    Exception e = new("Esta instrução é a mensagem de exceção original.");
    e.Data.Add("Info1", s);
    e.Data.Add("Info2", i);
    e.Data.Add("Info3", dt);
    e.HelpLink = "http://url";

    //e.Data["IntInfo"] = i;
    //e.Data["DateTimeInfo"] = dt;
    //e.HelpLink = "http://url";
    throw e;
}
catch (Exception e)
{
    Console.WriteLine("Uma exceção foi acionada.");
    Console.WriteLine(e.Message);
    Console.WriteLine(e.HelpLink);
    if (e.Data.Count > 0)
    {
        Console.WriteLine("Detalhes Extras:");

        foreach (DictionaryEntry de in e.Data)
            Console.WriteLine("    Key: {0,-20}      Valor: {1}",
                                "'" + de.Key.ToString() + "'", de.Value);
    }
}

