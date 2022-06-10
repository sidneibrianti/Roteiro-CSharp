Console.Clear();
Console.WriteLine("Arrays");
Console.WriteLine();

//Aula01();
Aula02();

void Aula01()
{
    int[] primeiro = new int[5];
    int[] segundo = primeiro; //Nos array a atribuição de = copia por referência

    primeiro[0] = 12;

    int[] terceiro = (int[])segundo.Clone();

    primeiro[1] = 13;
    segundo[2] = 25;
    terceiro[3] = 33;
    Console.WriteLine("Primeiro Array");
    Console.WriteLine(primeiro[0]);
    Console.WriteLine(primeiro[1]);
    Console.WriteLine(primeiro[2]);
    Console.WriteLine(primeiro[3]);
    Console.WriteLine(primeiro[4]);

    Console.WriteLine("Segundo Array");
    Console.WriteLine(segundo[0]);
    Console.WriteLine(segundo[1]);
    Console.WriteLine(segundo[2]);
    Console.WriteLine(segundo[3]);
    Console.WriteLine(segundo[4]);

    Console.WriteLine("Terceiro Array");
    Console.WriteLine(terceiro[0]);
    Console.WriteLine(terceiro[1]);
    Console.WriteLine(terceiro[2]);
    Console.WriteLine(terceiro[3]);
    Console.WriteLine(terceiro[4]);
    terceiro[0] = 50;
    Console.WriteLine("Terceiro Array");
    Console.WriteLine(terceiro[0]);
    Console.WriteLine(terceiro[1]);
    Console.WriteLine(terceiro[2]);
    Console.WriteLine(terceiro[3]);
    Console.WriteLine(terceiro[4]);

}

void Aula02()
{
    int[,] numeros = new int[2, 3];

    numeros[0, 0] = 10; //[Linha,Coluna]
    numeros[0, 1] = 20;
    numeros[0, 2] = 30;

    numeros[1, 0] = 40;
    numeros[1, 1] = 50;
    numeros[1, 2] = 60;

    Console.Write("[" + numeros[0, 0] + "]");
    Console.Write("[" + numeros[0, 1] + "]");
    Console.Write("[" + numeros[0, 2] + "]");

    Console.WriteLine();

    Console.Write("[" + numeros[1, 0] + "]");
    Console.Write("[" + numeros[1, 1] + "]");
    Console.Write("[" + numeros[1, 2] + "]");

    Console.WriteLine();

    string[,] textos =
    {
        { "Was","bang", "mögt" },
        { "Magna","rebum","labore"}
    };
    Console.Write("[" + textos[0, 0] + "]");
    Console.Write("[" + textos[0, 1] + "]");
    Console.Write("[" + textos[0, 2] + "]");
    Console.WriteLine();

    Console.Write("[" + textos[1, 0] + "]");
    Console.Write("[" + textos[1, 1] + "]");
    Console.Write("[" + textos[1, 2] + "]");
    Console.WriteLine();

    string[,] textos2 = new string[2, 2];

    textos2[0, 0] = "Hoje";
    textos2[0, 1] = "Agora";
    textos2[1, 0] = "Hora";
    textos2[1, 1] = "Minuto";
    Console.Write("[" + textos2[0, 0] + "]");
    Console.Write("[" + textos2[0, 1] + "]");
    Console.WriteLine();
    Console.Write("[" + textos2[1, 0] + "]");
    Console.Write("[" + textos2[1, 1] + "]");


}
