// 9- Escreva um programa para exibir as tabelas de multiplicação do 2 ao 6 usando o loop do-while aninhado

int i, j = 2;
do
{
    i = 1;
    do
    {
        Console.WriteLine($"{j} x {i} = {j * i}");
        i++;
    } while (i <= 10);
    Console.WriteLine();
    j++;
} while (j <= 6);
