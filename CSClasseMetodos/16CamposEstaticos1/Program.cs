Console.WriteLine("### Campos Estáticos 1");



Console.ReadKey();

public class Cliente
{
    public static string? Nome;
    public static int Idade;

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}

/*
 * Um membro estático é definido usando o modificador static na declaração do membro
 */