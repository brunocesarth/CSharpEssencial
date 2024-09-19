using System.Collections;

ArrayList pessoasList = new ArrayList();
Pessoa pessoa;

for (int i = 0; i < 3; i++)
{
    pessoa = new Pessoa();
    Console.Write($"Digite o nome da {i + 1}ª pessoa: ");
    pessoa.Nome = Console.ReadLine();
    Console.Write($"Digite a idade da {i + 1}ª pessoa: ");
    pessoa.Idade = Convert.ToInt32(Console.ReadLine());
    pessoasList.Add(pessoa);
}
Console.WriteLine();

foreach (Pessoa p in pessoasList)
{
    ((Pessoa)p).Exibir();
}
Console.WriteLine();


pessoasList.Add(new Pessoa() { Nome = "Jaime", Idade = 20 });
pessoasList.Add(new Pessoa() { Nome = "Tânia", Idade = 18 });

foreach (Pessoa p in pessoasList)
{
    ((Pessoa)p).Exibir();
}
Console.WriteLine();


pessoasList.RemoveAt(pessoasList.Count - 1);

foreach (Pessoa p in pessoasList)
{
    ((Pessoa)p).Exibir();
}