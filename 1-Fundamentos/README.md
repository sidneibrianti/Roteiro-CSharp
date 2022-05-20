# Fundamentos C #

### Documentação

[![Microsoft_Doc](https://img.shields.io/badge/Microsoft_Docs-.Net--6-666666?style=flat&logo=microsoft&logoColor=white)](https://docs.microsoft.com/pt-br/dotnet/api/system?view=net-6.0)

### Linguagens

![C#](https://shields.io/badge/C%23-blue?logo=csharp&logoColor=white&style=flat)

### IDE

[![VSCode](https://shields.io/badge/VSCode-0078d7?logo=visual-studio-code&logoColor=white&style=flat)](https://code.visualstudio.com)
[![VisualStudio](https://shields.io/badge/Visual_Studio-5C2D91?logo=visual-studio&logoColor=white&style=flat)](https://visualstudio.microsoft.com)

### Roteiro de Estudos

1. Comentários:

    ```csharp
        //  Comentários de Linhas
        
        /*  
            Comentários de multiplas linhas.
            Linha 2
            .
            .
            .
            .
            Linha n
        */

        /// <summary>
        ///  Está classe é muito importante
        /// </summary>
        public class MinhaClasse {}
    ```

2. Variaveis:

    1. Nomenclatura:

        [Referência Documentação Microsoft](https://docs.microsoft.com/pt-br/dotnet/standard/design-guidelines/naming-guidelines)

        1. Variaveis:

            ```csharp
            int numero;
            string primeiroNome;
            bool salvarArquivo = true;
            ```

        2. Funções e Métodos:

            ```csharp
            public string GetNome()
            public bool Verificar()
            public void Executar()
            ```

        3. Classes:

            ```csharp
            public class Veiculos { }
            public class Automoveis { }
            public class Caminhoes { }
            ```

        4. Propriedades:

            ```csharp
            public string Nome { get; set; }
            public DateTime DataDeNascimento { get; set; }
            public int CodigoDoProduto { get; set; }
            ```

        5. Parâmetros:

            ```csharp
            public void SetNome(string nome)
            public bool Verificar(int codigoDoCliente)
            public void Executar(DateTime dataDaExecucao)
            ```

        6. Campos:

            ```csharp
            protected string _nome;
            private int _qtdProdutos;
            private int _codProduto;
            private string _cliente;
            private DateTime _dtNascimento;
            ```

        7. Interfaces:

            ```csharp
            public class IPedidoService { }
            public class IHistoricoDaCompra { }
            public class IItemDoPedido { }
            ```

    2. Números Inteiros:

        ```csharp
        // sem sinal
        int numero;
        int numero = 0;
        sbyte numero;
        sbyte numero = 0;
        short numero;
        short numero = 2;
        long numero;
        long numero = 3L;
        var numero = 2; // nesse caso numero assume int

        // com sinal
        byte numero;
        byte numero = -1;
        ushort numero;
        ushort numero = 2;
        uint numero;
        uint numero = -34;
        ulong numero;
        ulong numero = -5L;
        ```

    3. Números Reais:

        ```csharp
        double numero;
        double numero = 1.2345;
        decimal numero;
        decimal numero = 1.2345m;
        float numero;
        float numero = 1.2345f;
        var numero = 1.2345; // nesse caso numero assume double
        ```

    4. Caracteres:

        ```csharp
        char letra = '\u0041';
        char escape = '\n';
        char literal = 'H';
        ```

    5. Boolean:

        ```csharp
        bool ultimaPagina = true;
        bool primeiraPagina = false;
        ```

    6. String:

        ```csharp
        string texto = @"Lorem ipsum dolor sit amet,\n consectetur adipiscing elit.\n In fringilla.";
        string texto = "Lorem ipsum dolor sit amet,\n consectetur adipiscing elit.\n In fringilla.";
        string nome = "José";
        string sobrenome = "Silva";
        //Concatenação
        string mensagem = "nome: " + nome;
        //Interpolação
        string mensagem = $"sobrenome: {sobrenome}";
        //Método String Format
        string mensagem = String.Format("nome: {0} e sobrenome: {1}, idade: {2}", nome, sobrenome,idade);
        ```

    7. Tipo Var:

        ```csharp
        var valor = 100;
        valor = 20;
        valor = "Lorem";  //Depois de atribuido um primeio valor inteiro não pode mais mudar o tipo da variavel 
        ```

    8. Tipo Object:

        ```csharp
        object obj = false;
        obj = 200;
        obj = "Has one stopped all it raven rustling on that i";
        ```

    9. Constantes:

        ```csharp
        const double pi = 3.1415;
        const string nome2 = "Herauf nebel sich tönen des";
        ```

    10. Tipo Dinamico:

        ```csharp
        dynamic dinamica = 100;
        dynamic dinamica2;
        dynamica2 = "Der den";

        dinamica = "An mit";
        dinamica2 = 345;
        ```

    11. Data e Hora:

        ```csharp
        DateTime dateTime = new();
        dateTime = DateTime.Now;
        dateTime =  new DateTime(2022, 04, 01, 10, 30, 45);
        ```

    12. Struct:

        ```csharp
        //Tipos por Valor
        struct Dados
        {
            public int valor;
            public Dados(int _valor)
            {
                valor = _valor;
            }
        }
        ```

    13. Classes:

        ```csharp
        // Tipos por Referência
        class Dados
        {
            // Fields ou Campos
            public int valor;
            public int ano;
            private string nome;
            // Properties ou Propriedades
            public string Nome {get;set;}
            // Constructor ou Construtor
            public Dados(int _valor, int ano, string nome)
            {
                valor = _valor; 
                this.ano = ano;
                this.Nome = nome;
            }

            // Methods ou Métodos
            public Resultado()
            {
                Console.WriteLine(nome + "tinha o valor de "+ valor + " no ano " + ano);
            }
        }
        ```

    14. Enumeradores:

        ```csharp
        enum DiasdaSemana
        {
            Domingo,
            Segunda_Feira,
            Terça_Feira,
            Quarta_Feira,
            Quinta_Feira,
            Sexta_Feira,
            Sabado
        }
        ```

3. Conversões

    1. Conversão Implícita

        ```csharp
        byte num1 = 100; // 8 bits, de 0 a 255
        ushort num2; // 16 bits, 0 a 65.535

        float num3 = 1250.45f;
        double num4 = num3;

        num3 = num1;
        num2 = num1;
        ```

    2. Conversão Explícita

        ```csharp
        ushort num1 = 500;
        byte num2 = (byte)num1;

        float num3 = 2500.786f;
        int num4 = (int)1985.75f;

        char letra = (char)97;
        ```

    3. Parse

        ```csharp
        string txtNumero = "1985";
        int numero = int.Parse(txtNumero);
        byte num1 = byte.Parse("120");
        double num2 = double.Parse("125623,57");
        float num3 = float.Parse("457,75");
        ```

    4. Classe Convert

        ```csharp
        string texto = Convert.ToString(2500);
        double num1 = Convert.ToDouble(false);
        int num2 = Convert.ToInt32('C');
        ```

4. Operadores

    1. Matemáticos

        ```csharp
        int num1 = 17;
        int num2 = 3;
        int soma = num1 + num2;
        int subtracao = num1 - num2;
        int multiplicao = num1 * num2;
        int divisao1 = num1 / num2;
        float divisao2 = (float)num1 / num2;
        int resto = num1 % num2;
        ```

    2. Precedência de Operadores

        ```csharp
        double num1 = 100;
        double num2 = 10;
        double num3 = 5;
        double res = (num1 + num2) * (num3 / 3);
        ```

    3. Incremento e decremento

        ```csharp
        int num = 10;
        int num1 = num;

        num1 = num1 + 1;
        
        num1 = num;
        num1++;

        num1 = num;
        ++num1;

        num1 = num;
        num1--;

        num1 = num;
        --num1;
        ```

    4. Concatenação

        ```csharp
        string nome = "João ";
        string sobreNome = "Silva";
        string nomeCompleto = nome + sobreNome + " " + 1982;
        ```

    5. Atribuição

        ```csharp
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
        ```

    6. Igualdade/Comparação

        ```csharp
        bool res = 100 == (50 * 2);
        Console.WriteLine("100 == (50 * 2) => " + res);

        bool res2 = (200 / 2) != (100 + 100);
        Console.WriteLine("(200 / 2) != (100 + 100) => " + res2);

        string nome = "João";
        bool res3 = nome != "Lucas";
        Console.WriteLine("nome = João\nnome != Pedro => " + res3);
        ```

    7. Relacionais

        ```csharp
        bool res1 = 100 < 50 * 2;
        Console.WriteLine("100 < 50 * 2 => " + res1);

        bool res2 = 100 + 25 > 50 * 2;
        Console.WriteLine("100 + 25 > 50 * 2 => " + res2);

        bool res3 = 100 <= 50 * 2;
        Console.WriteLine("100 <= 50 * 2 =>" + res3);

        bool res4 = 75 >= 50;
        Console.WriteLine("75 >= 50 => " + res4);
        ```

    8. Lógicos

        ```csharp
        bool res1 = 100 >= 50;
        Console.WriteLine("res1 = 100 >= 50 => " + res1);

        bool res2 = 60 == 50;
        Console.WriteLine("res2 = 60 == 50 => " + res2);
        Console.WriteLine("&& = and \n|| = or");
        
        bool final = res1 && res2;
        Console.WriteLine("res1 && res2 => "+ final);
        final = res1 || res2;
        Console.WriteLine("res1 || res2 => " + final);
        ```

5. String

    1. Atribuição de Literal $,@, \

        ```csharp
        var texto = "Testando " + " ";
        var texto2 = $"Testando {texto}";
        var texto3 = $"Testando {1 + 1}";
        var texto4 = @"\Testando \\";
        ```

    2. CompareTo

        ```csharp
        var texto = "Testando";
        texto.CompareTo("Testando"); // true
        texto.CompareTo("testando"); // false
        texto.CompareTo(""); // false
        texto.CompareTo(null); // false
        ```

    3. Contains

        ```csharp
        var texto = "Este é um texto de teste";
        texto.Contains("teste"); // true
        texto.Contains("Teste"); // false
        texto.Contains("Teste", StringComparison.OrdinalIgnoreCase); // true
        ```

    4. StartsWith e EndsWith

        ```csharp
        var texto = "Este é um texto de teste";
        texto.StartsWith("Este"); // true
        texto.StartsWith("este"); // false
        texto.StartsWith("este", StringComparison.OrdinalIgnoreCase); // true

        texto.EndsWith("Teste"); // false
        texto.EndsWith("teste"); // true
        texto.EndsWith("teste", StringComparison.OrdinalIgnoreCase); // true
        ```

    5. Equals

        ```csharp
        var texto = "Este é um texto de teste";
        texto.Equals("Este é um texto de teste"); // true
        texto.Equals("este é um texto de teste"); // false
        texto.Equals("este é um texto de teste", StringComparison.OrdinalIgnoreCase); // true
        ```

    6. IndexOf e LastIndexOf

        ```csharp
        var texto = "Este é um texto de teste";
        Console.WriteLine(texto.IndexOf("e"));
        Console.WriteLine(texto.LastIndexOf("s"));
        ```

    7. ToLower e ToUpper

        ```csharp
        var texto = "Este é um texto de teste";
        Console.WriteLine(texto.ToLower());
        Console.WriteLine(texto.ToUpper());
        ```

    8. Insert

        ```csharp
        var texto = "Este é um texto de teste";
        Console.WriteLine(texto.Insert(5, "AQUI "));
        ```

    9. Length

        ```csharp
        var texto = "Este é um texto de teste";
        Console.WriteLine(texto.Length);
        ```

    10. Remove

        ```csharp
        var texto = "Este é um texto de teste";
        Console.WriteLine(texto.Remove(0, 5));
        ```

    11. Replace

        ```csharp
        var texto = "Este é um texto de teste";
        Console.WriteLine(texto.Replace("Este", "Isto"));
        Console.WriteLine(texto.Replace("texto", "exemplo"));
        ```

    12. Split

        ```csharp
        var texto = "Este é um texto, de teste";
        var divisao = texto.Split(',');
        Console.WriteLine(divisao[0]);
        Console.WriteLine(divisao[1]);
        ```

    13. Substring

        ```csharp
        var texto = "Este é um texto de teste";
        Console.WriteLine(texto.Substring(0, 5));
        Console.WriteLine(texto.Substring(texto.LastIndexOf(" ") + 1, 5));
        ```

    14. Trim

        ```csharp
        var texto = "Este é           um texto de teste";
        Console.WriteLine(texto.Trim());
        texto = "       Este é um texto de teste             ";
        Console.WriteLine(texto.Trim());
        ```

    15. StringBuilder

        ```csharp
        var texto = new StringBuilder();
        texto.Append("Este");
        texto.Append("é");
        texto.Append("um");
        texto.Append(Environment.NewLine);
        texto.Append("texto");
        Console.WriteLine(texto.ToString());
        ```

    16. Compare

        ```csharp
        Console.WriteLine(string.Compare("texto","texto"));
        Console.WriteLine(string.Compare("Isto é um texto","Isto e um texto",
                            CultureInfo.CurrentCulture,CompareOptions.IgnoreNonSpace));
        Console.WriteLine(string.Compare("Isto é um texto","isto e um texto",
                            CultureInfo.CurrentCulture,CompareOptions.IgnoreNonSpace));
        Console.WriteLine(string.Compare("Isto é um texto","isto e um texto",
                            CultureInfo.CurrentCulture,CompareOptions.IgnoreSymbols));
        ```

6. Datas

    [Documentação MS Datetime](https://docs.microsoft.com/pt-br/dotnet/api/system.datetime?view=net-6.0)
    [Documentação MS Timespan](https://docs.microsoft.com/pt-br/dotnet/api/system.timespan?view=net-6.0)

    1. Globalization

        ```csharp
        var pt = new System.Globalization.CultureInfo("pt-BR");
        var de = new System.Globalization.CultureInfo("de-DE");
        ```

    2. Now

        ```csharp
        var atual = System.Globalization.CultureInfo.CurrentCulture;    
        Console.WriteLine(DateTime.Now.ToString("D", atual));
        Console.WriteLine(DateTime.Now.ToString("d", atual));

        Console.WriteLine(DateTime.Now.ToString("D", pt));
        Console.WriteLine(DateTime.Now.ToString("d", pt));

        Console.WriteLine(DateTime.Now.ToString("D", de));
        Console.WriteLine(DateTime.Now.ToString("d", de));
        ```

    3. UtcNow e ToLocalTime

        ```csharp
        var dateTime = DateTime.UtcNow;
        Console.WriteLine(dateTime);
        Console.WriteLine(dateTime.ToLocalTime());
        ```

    4. TimeZoneInfo

        ```csharp
        var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
        Console.WriteLine(timezoneAustralia);

        var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);
        Console.WriteLine(horaAustralia);

        var horaAtual = TimeZoneInfo.ConvertTimeToUtc(horaAustralia, timezoneAustralia);
        Console.WriteLine(horaAtual);

        var timezones = TimeZoneInfo.GetSystemTimeZones();
        foreach (var timezone in timezones)
        {
            Console.WriteLine(timezone.Id);
            Console.WriteLine(timezone);
            Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
        }

        var brazilTime = TimeZoneInfo.FindSystemTimeZoneById("");
        ```

    5. TimeSpan

        ```csharp
        var date1 = new DateTime(2020, 1, 1, 15, 0, 0);
        var date2 = DateTime.Now;
        TimeSpan interval = date2 - date1;
        Console.WriteLine($"Value of Days Component:{interval.Days}");
        Console.WriteLine($"Total Number of Days:{interval.TotalDays}");
        Console.WriteLine($"Value of Hours Component:{interval.Hours}");
        Console.WriteLine($"Total Number of Hours:{interval.TotalHours}");
        Console.WriteLine($"Value of Minutes Component:{interval.Minutes}");
        Console.WriteLine($"Total Number of Minutes:{interval.TotalMinutes}");
        Console.WriteLine($"Value of Seconds Component:{interval.Seconds}");
        Console.WriteLine($"Total Number of Seconds:{interval.TotalSeconds}");
        Console.WriteLine($"Value of Milliseconds Component:{interval.Milliseconds}");
        Console.WriteLine($"Total Number of Milliseconds:{interval.TotalMilliseconds}");
        Console.WriteLine($"Ticks:{interval.Ticks}");

        var timeSpan = new TimeSpan();
        Console.WriteLine(timeSpan);

        var timeSpanNanosegundos = new TimeSpan(1);
        Console.WriteLine(timeSpanNanosegundos);

        var timeSpanHoraMinutoSegundo = new TimeSpan(8, 12, 50);
        Console.WriteLine(timeSpanHoraMinutoSegundo);

        var timeSpanDiaHoraMinutoSegundo = new TimeSpan(3, 5, 50, 10);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo);

        var timeSpanDiaHoraMinutoSegundoMilissegundo = new TimeSpan(15, 12, 55, 8, 100);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundoMilissegundo);

        Console.WriteLine(timeSpanHoraMinutoSegundo - timeSpanDiaHoraMinutoSegundo);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Days);
        Console.WriteLine(timeSpanDiaHoraMinutoSegundo.Add(new TimeSpan(12, 0, 0)));

        Console.WriteLine(DateTime.DaysInMonth(2020, 2));
        Console.WriteLine(IsWeekend(DateTime.Now.DayOfWeek));
        Console.WriteLine(DateTime.Now.IsDaylightSavingTime());
        ```

7. Formatação de Números

    [Documentação MS CultureInfo](https://docs.microsoft.com/pt-br/dotnet/standard/base-types/standard-numeric-format-strings)
    [Documentaçaõ MS Format](https://docs.microsoft.com/pt-br/dotnet/standard/base-types/formatting-types)

    1. CultureInfo

        ```csharp
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


        // Formatações especiais
        double value;

        value = 123;
        Console.WriteLine(value.ToString("00000")); // Displays 00123
        Console.WriteLine(String.Format("{0:00000}", value)); // Displays 00123

        value = 1.2;
        Console.WriteLine(value.ToString("0.00",
                            CultureInfo.InvariantCulture)); // Displays 1.20

        Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:0.00}", value)); // Displays 1.20

        Console.WriteLine(value.ToString("00.00", 
                            CultureInfo.InvariantCulture)); // Displays 01.20

        Console.WriteLine(String.Format(CultureInfo.InvariantCulture, "{0:00.00}", value)); // Displays 01.20

        CultureInfo daDK = CultureInfo.CreateSpecificCulture("da-DK");
        Console.WriteLine(value.ToString("00.00", daDK)); // Displays 01,20
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
        S```

8. Arrays

    [Documentação MS Array](https://docs.microsoft.com/pt-br/dotnet/api/system.array?view=net-6.0)

    1. Unidimensional

        ```csharp
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
        ```

    2. Multidimensional

        ```csharp
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
        ```

9. Condições

    1. if , if .. else, if .. else if .. else

        ```csharp
        var condicao1 = true;
        var condicao2 = false;
        var condicao3 = true;

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
        ```

    2. Swich .. case

    ```csharp

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
    ```

10. Repetição

    1. for

        ```csharp
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        for(int j = 10; j >=0; j--)
        {
            Console.WriteLine(j);
        }
        ```

    2. while

        ```csharp
        int i = 0;
        while (i <= 10)
        {
            Console.WriteLine(i);
            i++;
        }
        ```

    3. do .. while

        ```csharp
        int j = 0;
        do
        {
            Console.WriteLine(j);
            j++;
        }
        while (j < 10);
        ```

    4. foreach

        ```csharp
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
        foreach (string i in cars)
        {
            Console.WriteLine(i);
        }
        ```

11. Lista e Tuplas

    [Documentação](https://docs.microsoft.com/pt-br/dotnet/csharp/tour-of-csharp/tutorials/arrays-and-collections)

    ```csharp
     Maneiras que podemos inicilizar as listas!

    var nomes = new List<string> { "<name>", "Ana", "Felipe" };

    List<string> nomes = new List<string>();
    nomes.Add("<nome>");
    nomes.Add("Ana");
    nomes.Add("Felipe");

    List<string> nomes = new();
    // Alguns código entre a Declaração a lista e Inicialização!
    Console.WriteLine();
    nomes.Add("<nome>");
    nomes.Add("Ana");
    nomes.Add("Felipe");

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

    (double, int) t1 = (4.5, 3);
    Console.WriteLine($"Tuplas com elementos {t1.Item1} e {t1.Item2}.");

    (string Nome, int Idade) t2 = ("Pedro", 25);
    Console.WriteLine($"Nome: {t2.Nome}, Idade: {t2.Idade}.");
    ```

12. Dicionários

    ```csharp
    struct Cliente
    {
        public string Nome;
        public string SobreNome;
    }
    
    // Declaração 1:
    var clientes = new Dictionary<int, Cliente>
    {
        { 1, new Cliente { Nome = "Pedro", SobreNome = "Silva" } },
        { 2, new Cliente { Nome = "João", SobreNome = "Severino" } },
        { 3, new Cliente { Nome = "Manoel", SobreNome = "Silvério" } }
    };

    // Declaração 2:
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
    ```

13. Exceções

    [Documentação](https://docs.microsoft.com/pt-br/dotnet/api/system.exception?view=net-6.0)
    [Referência 1](https://stackify.com/csharp-exception-handling-best-practices/)
    [Referência 2](https://www.macoratti.net/13/07/c_excep.htm)

    ```csharp
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
        e.Data.Add("Info2",i);
        e.Data.Add("Info3",dt);
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
    ```
