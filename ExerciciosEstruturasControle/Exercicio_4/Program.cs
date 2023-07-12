//4 - Escreva um programa para exibir a tabela de multiplicação de um número natural maior que zero recebido via teclado
//-Verifique se o número é maior que zero e emita uma mensagem
//- Considere a tabela de multiplicação de 1 até 10
//- Após exibir a tabela torne a solicitar outro número 
//- Para sair do loop defina uma condição de saída 

int n;

while (true)
{
    Console.Write($"Digite um número\t");
    n = Convert.ToInt32(Console.ReadLine());

    if (n > 0)
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{n} x {i} = {n * i}");
        }
        Console.WriteLine();
    }
    else if (n == 00)
    {
        break;
    }
    else
    {
        Console.WriteLine("Digite um número maior que zero");
    }
}

Console.WriteLine("Fim de processamento...");
