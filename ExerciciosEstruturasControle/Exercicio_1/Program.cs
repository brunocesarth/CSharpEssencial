Console.WriteLine("1- Escreva um programa para receber 3 números inteiros e a seguir calcular e exibir qual deles é o maior\r\n");
Console.WriteLine("Encontre o maior dentre os 3 números: ");
Console.Write("Primeiro número: \t");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Segundo número: \t");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Segundo número: \t");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"O primeiro número: {n1} é o maior");
}
else if (n2 > n3 && n2 > n1)
{
    Console.WriteLine($"O segundo número: {n2} é maior");
}
else if (n3 > n1 && n3 > n2)
{
    Console.WriteLine($"O terceiro número: {n3} é maior");
}

Console.ReadKey();
