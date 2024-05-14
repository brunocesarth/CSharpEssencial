string[] nomes = new string[5];
double[] notas = new double[5];
double mediaAritmetica = 0.0, somaDasMedias = 0.0;

Console.WriteLine("Digite os 5 alunos: ");
for (int i = 0; i < nomes.Length; i++)
{
    nomes[i] = Console.ReadLine();
}

Console.WriteLine("Digite as 5 notas: ");
for (int i = 0; i < notas.Length; i++)
{
    notas[i] = double.Parse(Console.ReadLine());
    somaDasMedias += notas[i];
}

Console.WriteLine("Lista dos nomes: ");
foreach (string nome in nomes)
{
    Console.WriteLine(nome);
}

Console.WriteLine("Lista das notas");

foreach (double nota in notas)
{
    Console.WriteLine(nota);
}

mediaAritmetica = somaDasMedias / notas.Count();

Console.WriteLine($"A média aritmética é: {mediaAritmetica}");
