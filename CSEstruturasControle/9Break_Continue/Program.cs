Console.WriteLine("## break e continue ##\n");

for (; ; )
{
    Console.WriteLine("Tecle algo (X sai)");
    var opcao = Console.ReadLine();

    Console.WriteLine(opcao.ToUpper());

    if (opcao == "X" || opcao == "x")
    {
        Console.WriteLine("Tchau...");
        break;
    }
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();

Console.WriteLine("-------------------------");

for (int i = 1; i <= 10; i++)
{
    if (i == 4)
        continue;
    Console.WriteLine(i);
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();



Console.WriteLine("-------------------------");

int n = 1;
while (n <= 10)
{
    if (n == 5)
    {
        n = n + 1;
        continue;
    }
    Console.WriteLine($"{n}");
    n++;
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();

Console.WriteLine("-------------------------");

for (int i = 0;i <= 10; i++)
{
    if (i == 5)
        continue;

    if (i > 8)
        break;

    Console.WriteLine(i);
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
