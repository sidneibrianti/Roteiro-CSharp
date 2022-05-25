// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conversões");

ConversaoImplicita();
ConversaoExplicita();
ConversaoParse();
ClasseConvert();

void ConversaoImplicita()
{
    byte num1 = 100; // 8 bits, de 0 a 255
    ushort num2; // 16 bits, 0 a 65.535

    float num3 = 1250.456f;
    double num4 = num3; // Pode haver perda precisão na conversão

    double num5 = 1250.456;
    float num6 = (float)num5;

    num3 = num1;
    num2 = num1;
    int numero = 'C';

    Console.WriteLine(num1);
    Console.WriteLine(num2);
    Console.WriteLine(num3);
    Console.WriteLine(num4);
    Console.WriteLine(num6);
    Console.WriteLine(numero);
}

void ConversaoExplicita()
{
    ushort num1 = 500;
    byte num2 = (byte)num1;

    float num3 = 2500.786f;
    int num4 = (int)1985.75f;

    char letra = (char)97;
    Console.WriteLine(num1);
    Console.WriteLine(num2);
    Console.WriteLine(num3);
    Console.WriteLine(num4);
    Console.WriteLine(letra);
}

void ConversaoParse()
{
    string txtNumero = "1985";
    int numero = int.Parse(txtNumero);
    byte num1 = byte.Parse("120");
    double num2 = double.Parse("125623,57");
    float num3 = float.Parse("457,75");
    Console.WriteLine(txtNumero);
    Console.WriteLine(numero);
    Console.WriteLine(num1);
    Console.WriteLine(num2);
    Console.WriteLine(num3);
}

void ClasseConvert()
{
    string texto = Convert.ToString(2500);
    double num1 = Convert.ToDouble(false);
    int num2 = Convert.ToInt32('C');
    Console.WriteLine(texto);
    Console.WriteLine(num1);
    Console.WriteLine(num2);
}