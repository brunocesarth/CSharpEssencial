Random random = new Random();

Console.WriteLine(random.Next());
Console.WriteLine(random.Next(20));
Console.WriteLine(random.Next(10, 20));
Console.WriteLine(random.NextDouble());

byte[] randBytes = new byte[10];
Random randNum = new Random();
randNum.NextBytes(randBytes);

for (int i = 0; i < 10; i++)
{
    Console.WriteLine(randBytes[i]);
}

Console.WriteLine("Sorteio da MegaSena\n");

Random random1 = new Random();
int[] numerosSorteados = new int[6];

for (int i = 0; i < 6; i++)
{
    int numeroAleatorio;
    do
    {
        numeroAleatorio = random1.Next(1, 61);
    }
    while (numerosSorteados.Contains(numeroAleatorio));

    numerosSorteados[i] = numeroAleatorio;
}

Array.Sort(numerosSorteados);

Console.WriteLine("Números Sorteados\n");
Console.WriteLine(string.Join(" ", numerosSorteados));

Console.ReadKey();
