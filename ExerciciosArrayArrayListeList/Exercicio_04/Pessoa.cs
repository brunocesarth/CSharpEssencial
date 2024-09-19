public class Pessoa
{
    public string Nome { get; set; } = string.Empty;
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }

    public Pessoa()
    {
    }

    public void Exibir() => Console.WriteLine($"{Nome} \t {Idade}");
}