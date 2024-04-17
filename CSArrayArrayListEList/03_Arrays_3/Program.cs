Console.WriteLine(" ### Arrays 3 ### \n");

int[] numeros;

numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];

string[] nomes = { "Ana", "Maria", "Marta", "Paulo", "Carlos" };

foreach (int numero in numeros)
{
    Console.Write($"{numero} ");
}
Console.WriteLine();

foreach (string nome in nomes)
{
    Console.Write($"{nome} ");
}

Console.ReadKey();