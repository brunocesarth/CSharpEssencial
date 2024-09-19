string pergunta;

do
{
    Console.Write("Digite um número inteiro: ");
    int n = Convert.ToInt32(Console.ReadLine());

    int[] nums = new int[n];

    for (int i = 0; i < n; i++)
    {
        Console.Write("Digite um número: ");
        nums[i] = int.Parse(Console.ReadLine());
    }


    Console.Write("Digite o número que deseja buscar no array: ");
    int numeroParaBuscar = Convert.ToInt32(Console.ReadLine());

    if (nums.Contains(numeroParaBuscar))
    {
        Console.WriteLine("Número existe no array!");
    }
    else
    {
        Console.WriteLine("Número NÃO existe no array!");
    }
    Console.WriteLine("Digite fim para encerrar o programa...\nOu tecle enter para continuar");
    pergunta = Console.ReadLine();
} while (pergunta != "fim");
