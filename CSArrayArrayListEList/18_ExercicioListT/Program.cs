using _18_ExercicioListT;

List<Aluno> alunos =
[
    new Aluno() { Nome = "Maria", Nota = 8.75 },
    new Aluno() { Nome = "Manoel", Nota = 6.95 },
    new Aluno() { Nome = "Amanda", Nota = 7.25 },
    new Aluno() { Nome = "Carlos", Nota = 6.55 },
    new Aluno() { Nome = "Jaime", Nota = 8.50 },
    new Aluno() { Nome = "Debora", Nota = 5.95 },
    new Aluno() { Nome = "Alicia", Nota = 9.25 },
    new Aluno() { Nome = "Sandra", Nota = 5.55 },
    new Aluno() { Nome = "Marta", Nota = 7.85 },
    new Aluno() { Nome = "Sueli", Nota = 9.15 },
];

Console.WriteLine("Exercício 1");
ListarAlunos(alunos);

alunos.Add(new Aluno() { Nome = "Bia", Nota = 7.75 });
alunos.Add(new Aluno() { Nome = "Mario", Nota = 8.95 });

Console.WriteLine();
Console.WriteLine("Exercício 2");
ListarAlunos(alunos);

Console.WriteLine();
Console.WriteLine("Exercício 3");
alunos.Remove(alunos.Find(f => f.Nome == "Amanda"));
ListarAlunos(alunos);

Console.WriteLine();
Console.WriteLine("Exercício 4");
ListarAlunos(alunos.OrderBy(f => f.Nome).ToList());

Console.WriteLine();
Console.WriteLine("Exercício 5");
ListarAlunos(alunos.FindAll(a => a.Nota >= 8.0));


Console.ReadKey();
void ListarAlunos(List<Aluno> alunos)
{
    double mediaAritmetica = 0.0;
    double somaNotas = 0.0;
    foreach (var aluno in alunos)
    {
        Console.WriteLine($"Nome: {aluno.Nome}, Nota: {aluno.Nota}");
        somaNotas += aluno.Nota;
    }
    mediaAritmetica = somaNotas/alunos.Count;
    Console.WriteLine($"Média Aritmética da sala {mediaAritmetica:F}");
}
