using _20_ExerciciosListT;

List<Aluno> alunos = [
    new Aluno() { Nome = "Maria", Nota = 8.75 },
    new Aluno() { Nome = "Manoel", Nota = 6.95 },
    new Aluno() { Nome = "Amanda", Nota = 7.25 },
    new Aluno() { Nome = "Carlos", Nota = 6.55 },
    new Aluno() { Nome = "Jaime", Nota = 8.50 },
    new Aluno() { Nome = "Debora", Nota = 5.95 },
    new Aluno() { Nome = "Alicia", Nota = 9.25 },
    new Aluno() { Nome = "Sandra", Nota = 5.55 },
    new Aluno() { Nome = "Marta", Nota = 7.85 },
    new Aluno() { Nome = "Sueli", Nota = 9.15 }
    ];

Console.WriteLine("Exercício 1");
ExibirLista(alunos);
Console.WriteLine();

Console.WriteLine("Exercício 2");
alunos.Add(new Aluno() { Nome = "Bia", Nota = 7.75 });
alunos.Add(new Aluno() { Nome = "Mario", Nota = 8.95 });
ExibirLista(alunos);
Console.WriteLine();

Console.WriteLine("Exercício 3");
var paraRemover = alunos.Find(x => x.Nome == "Amanda");
alunos.Remove(paraRemover);
ExibirLista(alunos);
Console.WriteLine();


Console.WriteLine("Exercício 4");
ExibirLista([.. alunos.OrderBy(a => a.Nome)]);
Console.WriteLine();

Console.WriteLine("Exercício 5");
ExibirLista(alunos.FindAll(a => a.Nota >= 8.00));
Console.WriteLine();

Console.ReadKey();
static void ExibirLista(List<Aluno> alunos)
{
    double mediaAritmetica = 0.0;
    double somaNotas = 0.0;
    foreach (var aluno in alunos)
    {
        Console.WriteLine($"Nome: {aluno.Nome} \tNota: {aluno.Nota:C}");
        somaNotas += aluno.Nota;
    }
    
    mediaAritmetica = somaNotas / alunos.Count();
    Console.WriteLine($"A média da sala é de {mediaAritmetica:C}");

}