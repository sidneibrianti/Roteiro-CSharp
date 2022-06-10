using System.Globalization;

Console.Clear();
Console.WriteLine("Formatação de Números");
Console.WriteLine();
//Aula01();
//Aula02();
Aula03();

void Aula01()
{
    CultureInfo ci = new CultureInfo("pt-br");
    // Output decimal point values
    decimal dec = 10761.937554m;
    Console.WriteLine("Números em Decimal");
    Console.WriteLine("C: {0}", dec.ToString("C", ci));           // "C: R$ 10.761,94"
    Console.WriteLine("E: {0}", dec.ToString("E03", ci));         // "E: 1,076E+004"
    Console.WriteLine("F: {0}", dec.ToString("F04", ci));         // "F: 10761,9376"
    Console.WriteLine("G: {0}", dec.ToString("G", ci));           // "G: 10761,937554"
    Console.WriteLine("N: {0}", dec.ToString("N03", ci));         // "N: 10.761,938"
    Console.WriteLine("P: {0}", (dec / 10000).ToString("P02", ci)); // "P: 107,62 %"
    //Console.WriteLine("R: {0}", dec.ToString("R", ci));           // "ERRO NÃO É ACEITO EM Decimal"
    Console.WriteLine();

    // Output floating point values
    float f = 10761.937554f;
    Console.WriteLine("Números em Float");
    Console.WriteLine("C: {0}", f.ToString("C", ci));           // "C: R$ 10.761,94"
    Console.WriteLine("E: {0}", f.ToString("E03", ci));         // "E: 1,076E+004"
    Console.WriteLine("F: {0}", f.ToString("F04", ci));         // "F: 10761,9376"
    Console.WriteLine("G: {0}", f.ToString("G", ci));           // "G: 10761,937554"
    Console.WriteLine("N: {0}", f.ToString("N03", ci));         // "N: 10.761,938"
    Console.WriteLine("P: {0}", (f / 10000).ToString("P02", ci)); // "P: 107,62 %"
    Console.WriteLine("R: {0}", f.ToString("R", ci));           // "R: 10761,937554"
    Console.WriteLine();

    // Output floating point values
    double d = 10761.937554f;
    Console.WriteLine("Números em Double");
    Console.WriteLine("C: {0}", d.ToString("C", ci));           // "C: R$ 10.761,94"
    Console.WriteLine("E: {0}", d.ToString("E03", ci));         // "E: 1,076E+004"
    Console.WriteLine("F: {0}", d.ToString("F04", ci));         // "F: 10761,9376"
    Console.WriteLine("G: {0}", d.ToString("G", ci));           // "G: 10761,937554"
    Console.WriteLine("N: {0}", d.ToString("N03", ci));         // "N: 10.761,938"
    Console.WriteLine("P: {0}", (d / 10000).ToString("P02", ci)); // "P: 107,62 %"
    Console.WriteLine("R: {0}", d.ToString("R", ci));           // "R: 10761,937554"
    Console.WriteLine();

    // Output integral values
    int i = 8395;
    Console.WriteLine("Números em Inteiro");
    Console.WriteLine("C: {0}", i.ToString("C", ci));           // "C: $8,395.00"
    Console.WriteLine("D: {0}", i.ToString("D6", ci));          // "D: 008395"
    Console.WriteLine("E: {0}", i.ToString("E03", ci));         // "E: 8.395E+003"
    Console.WriteLine("F: {0}", i.ToString("F01", ci));         // "F: 8395.0"
    Console.WriteLine("G: {0}", i.ToString("G", ci));           // "G: 8395"
    Console.WriteLine("N: {0}", i.ToString("N01", ci));         // "N: 8,395.0"
    Console.WriteLine("P: {0}", (i / 10000.0).ToString("P02", ci)); // "P: 83.95 %"
    Console.WriteLine("X: 0x{0}", i.ToString("X", ci));           // "X: 0x20CB"
    Console.WriteLine();
}

void Aula02()
{
    // Formatações especiais
    double value;

    value = 123;
    Console.WriteLine(value.ToString("00000")); // Displays 00123
    Console.WriteLine(String.Format("{0:00000}", value)); // Displays 00123

    value = 1.2;
    Console.WriteLine(value.ToString("0.00", CultureInfo.InvariantCulture)); // Displays 1.20
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.00}", value)); // Displays 1.20

    Console.WriteLine(value.ToString("00.00", CultureInfo.InvariantCulture)); // Displays 01.20
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:00.00}", value)); // Displays 01.20

    CultureInfo daDK = CultureInfo.CreateSpecificCulture("da-DK"); Console.WriteLine(value.ToString("00.00", daDK)); // Displays 01,20
    Console.WriteLine(String.Format(daDK, "{0:00.00}", value)); // Displays 01,20

    value = .56;
    Console.WriteLine(value.ToString("0.0", CultureInfo.InvariantCulture)); // Displays 0.6
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.0}", value)); // Displays 0.6

    value = 1234567890;
    Console.WriteLine(value.ToString("0,0", CultureInfo.InvariantCulture)); // Displays 1,234,567,890
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0,0}", value)); // Displays 1,234,567,890

    CultureInfo elGR = CultureInfo.CreateSpecificCulture("el-GR");
    Console.WriteLine(value.ToString("0,0", elGR)); // Displays 1.234.567.890
    Console.WriteLine(String.Format(elGR, "{0:0,0}", value)); // Displays 1.234.567.890

    value = 1234567890.123456;
    Console.WriteLine(value.ToString("0,0.0", CultureInfo.InvariantCulture)); // Displays 1,234,567,890.1
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0,0.0}", value)); // Displays 1,234,567,890.1

    value = 1234.567890;
    Console.WriteLine(value.ToString("0,0.00", CultureInfo.InvariantCulture)); // Displays 1,234.57
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0,0.00}", value)); // Displays 1,234.57

    // Usando "#"

    value = 1.2;
    Console.WriteLine(value.ToString("#.##", CultureInfo.InvariantCulture));
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#.##}", value)); // Displays 1.2

    value = 123;
    Console.WriteLine(value.ToString("#####"));
    Console.WriteLine(String.Format("{0:#####}", value)); // Displays 123

    value = 123456;
    Console.WriteLine(value.ToString("[##-##-##]"));
    Console.WriteLine(String.Format("{0:[##-##-##]}", value)); // Displays [12-34-56]

    value = 1234567890;
    Console.WriteLine(value.ToString("#"));
    Console.WriteLine(String.Format("{0:#}", value)); // Displays 1234567890

    Console.WriteLine(value.ToString("(###) ###-####"));
    Console.WriteLine(String.Format("{0:(###) ###-####}", value)); // Displays (123) 456-7890

    // Usando "."

    value = 1.2;
    Console.WriteLine(value.ToString("0.00", CultureInfo.InvariantCulture));
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.00}", value)); // Displays 1.20

    Console.WriteLine(value.ToString("00.00", CultureInfo.InvariantCulture));
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:00.00}", value)); // Displays 01.20

    Console.WriteLine(value.ToString("00.00",
                    CultureInfo.CreateSpecificCulture("da-DK")));
    Console.WriteLine(String.Format(CultureInfo.CreateSpecificCulture("da-DK"), "{0:00.00}", value)); // Displays 01,20

    value = .086;
    Console.WriteLine(value.ToString("#0.##%", CultureInfo.InvariantCulture));
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#0.##%}", value)); // Displays 8.6%

    value = 86000;
    Console.WriteLine(value.ToString("0.###E+0", CultureInfo.InvariantCulture));
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.###E+0}", value)); // Displays 8.6E+4

    //Usando ","

    value = 1234567890;
    Console.WriteLine(value.ToString("#,#", CultureInfo.InvariantCulture));
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#,#}", value)); // Displays 1,234,567,890

    Console.WriteLine(value.ToString("#,##0,,", CultureInfo.InvariantCulture));
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#,##0,,}", value)); // Displays 1,235

    value = 1234567890;
    Console.WriteLine(value.ToString("#,,", CultureInfo.InvariantCulture));
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#,,}", value)); // Displays 1235

    Console.WriteLine(value.ToString("#,,,", CultureInfo.InvariantCulture));
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#,,,}", value)); // Displays 1

    Console.WriteLine(value.ToString("#,##0,,", CultureInfo.InvariantCulture));
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#,##0,,}", value)); // Displays 1,235

    // Usando "%"

    value = .086;
    Console.WriteLine(value.ToString("#0.##%", CultureInfo.InvariantCulture));
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:#0.##%}", value)); // Displays 8.6%

    // Usando "‰"

    value = .00354;
    string perMilleFmt = "#0.## " + '\u2030';
    Console.WriteLine(value.ToString(perMilleFmt, CultureInfo.InvariantCulture));
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:" + perMilleFmt + "}", value)); // Displays 3.54‰

    //Usando  "E" ou "e"
    value = 86000;
    Console.WriteLine(value.ToString("0.###E+0", CultureInfo.InvariantCulture));
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.###E+0}", value)); // Displays 8.6E+4

    Console.WriteLine(value.ToString("0.###E+000", CultureInfo.InvariantCulture));
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.###E+000}", value)); // Displays 8.6E+004

    Console.WriteLine(value.ToString("0.###E-000", CultureInfo.InvariantCulture));
    Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.###E-000}", value)); // Displays 8.6E004

    // Usando "/"

    value = 123; // Aceita variavel tipo Int
    Console.WriteLine(value.ToString("\\#\\#\\# ##0 dollars and \\0\\0 cents \\#\\#\\#"));
    Console.WriteLine(String.Format("{0:\\#\\#\\# ##0 dollars and \\0\\0 cents \\#\\#\\#}", value)); // Displays ### 123 dollars and 00 cents ###

    Console.WriteLine(value.ToString(@"\#\#\# ##0 dollars and \0\0 cents \#\#\#"));
    Console.WriteLine(String.Format(@"{0:\#\#\# ##0 dollars and \0\0 cents \#\#\#}", value));  // Displays ### 123 dollars and 00 cents ###

    Console.WriteLine(value.ToString("\\\\\\\\\\\\ ##0 dollars and \\0\\0 cents \\\\\\\\\\\\"));
    Console.WriteLine(String.Format("{0:\\\\\\\\\\\\ ##0 dollars and \\0\\0 cents \\\\\\\\\\\\}", value)); // Displays \\\ 123 dollars and 00 cents \\\

    Console.WriteLine(value.ToString(@"\\\\\\ ##0 dollars and \0\0 cents \\\\\\"));
    Console.WriteLine(String.Format(@"{0:\\\\\\ ##0 dollars and \0\0 cents \\\\\\}", value)); // Displays \\\ 123 dollars and 00 cents \\\
}

void Aula03()
{
    // Usando ";"

    double posValue = 1234;
    double negValue = -1234;
    double zeroValue = 0;

    string fmt2 = "##;(##)";
    string fmt3 = "##;(##);**Zero**";

    Console.WriteLine(posValue.ToString(fmt2));
    Console.WriteLine(String.Format("{0:" + fmt2 + "}", posValue)); // Displays 1234

    Console.WriteLine(negValue.ToString(fmt2));
    Console.WriteLine(String.Format("{0:" + fmt2 + "}", negValue)); // Displays (1234)

    Console.WriteLine(zeroValue.ToString(fmt3));
    Console.WriteLine(String.Format("{0:" + fmt3 + "}", zeroValue)); // Displays **Zero**
}