string[,] alunos = new string[2, 5];

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.Write($"Digite o aluno para a posição [{i},{j}]: ");
        alunos[i, j] = Console.ReadLine();
    }
}

for (int i = 0; i < alunos.GetLength(0); i++)
{
    for (int j = 0; j < alunos.GetLength(1); j++)
    {
        Console.WriteLine($"Aluno: {alunos[i, j]} no indice [{i},{j}]");
    }
}

Console.ReadKey();
