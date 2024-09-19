float[,] notas = new float[5, 5];
float mediaAritmetica = 0, nota = 0, somaNotas = 0;


for (int i = 0; i < 2; i++)
{
    Console.WriteLine($"Digite as notas do grupo {i+1}");
    for (int j = 0; j < 5; j++)
    {
        notas[i, j] = float.Parse(Console.ReadLine());
        nota = notas[i, j];
    }
    somaNotas += nota;
    mediaAritmetica = somaNotas / 5;
    Console.WriteLine($"A média aritmética do grupo {i+1} é {mediaAritmetica}");
    Console.WriteLine();
}
