// See https://aka.ms/new-console-template for more information
Console.WriteLine("Conversões");

ConversaoImplicita();

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
