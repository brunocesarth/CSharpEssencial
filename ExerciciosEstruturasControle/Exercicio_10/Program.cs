// 10 - Crie um programa que recebe na entrada de dados um número inteiro de 0 a 10 que representa a nota de um aluno. Com base na tabela a seguir imprima no console qual o resultado da avaliação do aluno. (Use a instrução switch, break e default em um loop infinito e defina uma condição de saida.)

int nota = 0;
do
{
    Console.Write("Digite a nota do aluno: \t");
    nota = Convert.ToInt32(Console.ReadLine());

    switch (nota)
    {
        case 0:
        case 1:
        case 2:
        case 3:
        case 4:
            Console.WriteLine("Nota F");
            break;
        case 5:
            Console.WriteLine("Nota E");
            break;
        case 6:
            Console.WriteLine("Nota C");
            break;
        case 7:
        case 8:
            Console.WriteLine("Nota B");
            break;
        case 9:
            Console.WriteLine("Nota A");
            break;
        case 10:
            Console.WriteLine("Nota A+");
            break;
        default:
            Console.WriteLine("Nota inválida");
            break;
    }
} while (nota != 99);
