
public struct Cliente
{
    public string? Nome { get; set; }
    public string? Email { get; set; }

    private int idade;
    public int Idade
    {
        get { return idade; }
        set
        {
            if (value < 18)
            {
                idade = 18;
            }
            else
            {
                idade = value;
            }
        }
    }

    public Cliente(string? nome, string? email, int idade)
    {
        Nome = nome;
        Email = email;
        Idade = idade;
    }

    public void ExibirInfo(string nome, string email, int idade = 18)
    {
        Console.WriteLine($"{nome} \n" +
            $"{email} \n" +
            $"{idade} \n");
    }
}
