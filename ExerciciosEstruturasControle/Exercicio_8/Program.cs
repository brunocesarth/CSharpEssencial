//8 - Escreva um programa para calcular o fatorial de um número inteiro. 
//O fatorial de um número é representado por : n! => n * (n – 1) *(n – 2) ....2 * 1
//Exemplo: fatorial de 6 é representado por 6! = 6*5*4*3*2*1

int N, x;
long resultado;
resultado = 1;

Console.Write("Digite um número para calcular o fatorial:\t");
N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++)
{
    resultado *= i;
}
Console.WriteLine($"!{N} = {resultado}");
