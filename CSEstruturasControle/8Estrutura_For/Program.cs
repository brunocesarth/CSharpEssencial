Console.WriteLine("## Loop for ##\n");

int resultado, numero;
Console.WriteLine("Informe o número inteiro maior que zero: \t");
numero = Convert.ToInt32(Console.ReadLine());


if (numero > 0)
{
    for (int i = 1; i <= 10; i++)
    {
        resultado = numero * i;
        Console.WriteLine($"{numero} x {i} = {resultado}");
    }
}
else
{
    Console.WriteLine("Número inválido");
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();

Console.WriteLine("------------------------------");

for (int i = 0, j = 0; i + j <= 20; i++, j++)
{
    Console.WriteLine($"i={i} e j={j}");
}

int k = 1;
for (; k <= 10;)
{
    Console.WriteLine($"k = {k}");
    k++;
}

//Looping infinito
//for (; ; )
//{
//    Console.WriteLine($"k = {k}");
//    k++;
//}


for (int x = 0; x < 5; x++)
{
    for(int y = 0; y < 5; y++)
    {
        Console.Write($"({x},{y})");
    }
    Console.WriteLine();
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
