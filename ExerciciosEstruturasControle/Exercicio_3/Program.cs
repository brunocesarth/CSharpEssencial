//3 - Escreva um programa para exibir os 10 primeiros números naturais e calcular a sua soma usando os loop while, do-while e for.

int i = 1;
int soma = 0;


while (i <= 10)
{
    Console.Write($"{i} ");
    i++;
}
Console.WriteLine();
i = 1;

do
{
    Console.Write($"{i} ");
    i++;
} while (i <= 10);

Console.WriteLine();

for (i = 1; i <= 10; i++)
{
    Console.Write($"{i} ");
    soma += i;
}
Console.WriteLine();
Console.WriteLine($"A soma dos números é: {soma}");
