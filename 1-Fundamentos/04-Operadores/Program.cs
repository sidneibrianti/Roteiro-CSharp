// See https://aka.ms/new-console-template for more information
Console.WriteLine("Operadores");

OperadoresMatematico();
PrecedenciaOperadores();
IncrementoDecremento();
Concanetacao();
OperadoresAtribuicao();
IgualdadeComparacao();
Relacionais();
Logicos();

void OperadoresMatematico()
{
    int num1 = 17;
    int num2 = 3;
    int resultado = num1 + num2;
    Console.WriteLine("num1 = " + num1 + "\nnum2 = " + num2);
    Console.WriteLine("num1 + num2 = " + (num1 + num2));
    Console.WriteLine($"num1 - num2 = {num1 - num2}");
    Console.WriteLine($"num1 * num2 = {num1 * num2}");
    Console.WriteLine($"num1 / num2 = {num1 / num2}"); // Trunca o valor
    Console.WriteLine($"(float)num1 / num2 = {(float)num1 / num2}");
    Console.WriteLine($"num1 % num2 = {num1 % num2}");
    Console.Write("int resultado = num1 + num2 = " + resultado);
}

void PrecedenciaOperadores()
{
    double num1 = 100;
    double num2 = 10;
    double num3 = 5;
    double res1 = num1 + num2 * num3 / 3;
    double res2 = (num1 + num2) * (num3 / 3);
    Console.WriteLine("num1 = " + num1);
    Console.WriteLine("num2 = " + num2);
    Console.WriteLine("mum3 = " + num3);
    Console.WriteLine("num1 + num2 * num3 / 3 = num1 + (num2 * num3)/3 " + res1 );
    Console.WriteLine("(num1 + num2) * (num3 / 3) = " + res2);
}

void IncrementoDecremento()
{
    int num = 10;
    int num1 = num;
    
    Console.WriteLine($"num1 = {num1}");
    num1 = num1 + 1;
    Console.WriteLine("num1 = num1 + 1 = " + num1);
    Console.WriteLine("--------------------------");
    num1 = num;
    Console.WriteLine($"num1 = {num1++}");
    Console.WriteLine($"num1 = {num1}");
    Console.WriteLine("--------------------------");
    num1 = num;
    Console.WriteLine($"num1 = {++num1}");
    Console.WriteLine($"num1 = {num1}");
    Console.WriteLine("--------------------------");
    num1 = num;
    Console.WriteLine($"num1 = {num1--}");
    Console.WriteLine($"num1 = {num1}");
    Console.WriteLine("--------------------------");
    num1 = num;
    Console.WriteLine($"num1 = {--num1}");
    Console.WriteLine($"num1 = {num1}");
}

void Concanetacao()
{
    string nome = "João ";
    string sobreNome = "Silva";
    string nomeCompleto = nome + sobreNome + " " + 1982;
    Console.WriteLine(nomeCompleto);
}

void OperadoresAtribuicao()
{
    int num = 13;
    int num1 = num;

    Console.WriteLine("num1 = " + num1);
    num1 += 20;
    Console.WriteLine("num1 += 20 => num1 = " + num1);
    num1 = num;
    num1 -= 2;
    Console.WriteLine("num1 -= 2 => num1 = " + num1);
    num1 = num;
    num1 *= 3;
    Console.WriteLine("num1 *= 3 => num1 = " + num1);
    num1 = num;
    num1 /= 2;
    Console.WriteLine("num1 /= 2 => num1 = " + num1); // Truncado
    num1 = num;
    num1 %= 2;
    Console.WriteLine("num1 %= 2 => num1 = " + num1);

    string nome = "João";
    nome += " Silva";

    Console.WriteLine(nome);
}

void IgualdadeComparacao()
{
    bool res = 100 == (50 * 2);
    Console.WriteLine("100 == (50 * 2) => " + res);
    bool res2 = (200 / 2) != (100 + 100);
    Console.WriteLine("(200 / 2) != (100 + 100) => " + res2);
    string nome = "João";
    bool res3 = nome != "Lucas";
    Console.WriteLine("nome = João\nnome != Pedro => " + res3);
}

void Relacionais()
{
    bool res1 = 100 < 50 * 2;
    Console.WriteLine("100 < 50 * 2 => " + res1);
    bool res2 = 100 + 25 > 50 * 2;
    Console.WriteLine("100 + 25 > 50 * 2 => " + res2);
    bool res3 = 100 <= 50 * 2;
    Console.WriteLine("100 <= 50 * 2 => " + res3);
    bool res4 = 75 >= 50;
    Console.WriteLine("75 >= 50 => " + res4);
}

void Logicos()
{
    bool res1 = 100 >= 50;
    Console.WriteLine("res1 = 100 >= 50 => " + res1);
    bool res2 = 60 == 50;
    Console.WriteLine("res2 = 60 == 50 => " + res2);
    Console.WriteLine("&& = and \n|| = or");
    bool final = res1 && res2;
    Console.WriteLine("res1 && res2 => " + final);
    bool final2 = res1 || res2;
    Console.WriteLine("res1 || res2 => " + final2);
}