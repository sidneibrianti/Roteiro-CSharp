
Console.Clear();
Console.WriteLine("Datas:");
Console.WriteLine();

Aula01();
Aula02();
Aula03();
Aula04();
Aula05();

void Aula01()
{
    var pt = new System.Globalization.CultureInfo("pt-BR");
    var de = new System.Globalization.CultureInfo("de-DE");
    var atual = System.Globalization.CultureInfo.CurrentCulture;

    Console.WriteLine(DateTime.Now.ToString("D", atual));
    Console.WriteLine(DateTime.Now.ToString("d", atual));

    Console.WriteLine(DateTime.Now.ToString("D", pt));
    Console.WriteLine(DateTime.Now.ToString("d", pt));

    Console.WriteLine(DateTime.Now.ToString("D", de));
    Console.WriteLine(DateTime.Now.ToString("d", de));

}

void Aula02()
{
    var dateTime = DateTime.UtcNow;
    Console.WriteLine(dateTime);
    Console.WriteLine(dateTime.ToLocalTime());
    Console.WriteLine("--------------------");

    var timezoneAustralia = TimeZoneInfo.FindSystemTimeZoneById("Pacific/Auckland");
    Console.WriteLine(timezoneAustralia);

    var horaAustralia = TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezoneAustralia);
    Console.WriteLine(horaAustralia);

    var horaAtual = TimeZoneInfo.ConvertTimeToUtc(horaAustralia, timezoneAustralia);
    Console.WriteLine(horaAtual);
}

void Aula03()
{
    var dateTime = DateTime.UtcNow;
    var timezones = TimeZoneInfo.GetSystemTimeZones();
    foreach (var timezone in timezones)
    {
        Console.WriteLine(timezone.Id);
        Console.WriteLine(timezone);
        Console.WriteLine(TimeZoneInfo.ConvertTimeFromUtc(dateTime, timezone));
        Console.WriteLine("_________");
    }

    //var brazilTime = TimeZoneInfo.FindSystemTimeZoneById("");
}

void Aula04()
{
    var date1 = new DateTime(2020, 1, 1, 15, 0, 0);
    var date2 = DateTime.Now;
    Console.WriteLine($"Data1: {date1}");
    Console.WriteLine($"Data2: {date2}");
    TimeSpan interval = date2 - date1;
    Console.WriteLine($"Dias entre Data1 e Data2: {interval.Days}");
    Console.WriteLine($"Total de dias entre Data1 e Data2: {interval.TotalDays}");
    Console.WriteLine($"Horas entre Data1 e Data2: {interval.Hours}");
    Console.WriteLine($"Total de Horas entre Data1 e Data2: {interval.TotalHours}");
    Console.WriteLine($"Minutos entre Data1 e Data2: {interval.Minutes}");
    Console.WriteLine($"Total de Minutos entre Data1 e Data2: {interval.TotalMinutes}");
    Console.WriteLine($"Segundos entre Data1 e Data2: {interval.Seconds}");
    Console.WriteLine($"Total de Segundos entre Data1 e Data2: {interval.TotalSeconds}");
    Console.WriteLine($"Milisegundos entre Data1 e Data2: {interval.Milliseconds}");
    Console.WriteLine($"Total de Milisegundos entre Data1 e Data2: {interval.TotalMilliseconds}");
    Console.WriteLine($"Ticks: {interval.Ticks}");
}

void Aula05()
{
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
}
static bool IsWeekend(DayOfWeek today)
{
    return today == DayOfWeek.Saturday || today == DayOfWeek.Sunday;
}