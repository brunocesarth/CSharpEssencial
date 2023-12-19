Console.WriteLine("### Campos Estáticos 1 ###\n");

string nome = Cliente.Nome = "João";
int idade = Cliente.Idade = 15;

Console.WriteLine($"Nome: {nome} \n" +
    $"Idade: {idade} anos");

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
 * Um campo estático não pertence ao objeto mas à classe
 * Um campo(field) estático é compartilhado com todas as instâncias da classe e todas as instâncias acessam o mesmo local da memória
 */