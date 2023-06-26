Console.WriteLine("## Struct DateTime ##\n");

DateTime hoje = DateTime.Now;

// Extrair informações da data atual
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);
Console.WriteLine();

Console.WriteLine($"Hoje: {hoje}\n");
// Adicionando Valores
Console.WriteLine(hoje.AddDays(30));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(2));
Console.WriteLine(hoje.AddYears(5));

// Obter o dia da semana e do ano
Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);


// Data no formato longo e curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());

Console.ReadLine();


//// Criar uma data especifica, usando o formato: aaaa, mm, dd
//DateTime dataHoje = new DateTime(2022, 09, 06);
//Console.WriteLine(dataHoje);

//// Definir as horas
//DateTime dataHoraHoje = new DateTime(2022, 09, 06, 21, 10, 30);
//Console.WriteLine(dataHoraHoje);
