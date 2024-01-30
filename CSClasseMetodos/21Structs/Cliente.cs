
/*
 * STRUCTS
 * Uma struct é um tipo de dado definido pelo usuário que é composta por outros tipos de dados e funcionalidades relacionadas (semelhante a uma classe).
 * Uma struct pode conter campos, métodos, constantes, construtores, propriedades, indexadores, operadores e mesmo outro tipos de estruturas.
 * A principal diferença entre classe e structs é que structs são TIPOS DE VALOR e não de referência. (membros e instâncias de uma strcut são criadas na memória STACK e contém seus dados)
 * 
 * Sintaxe:
 * struct <nome_do_tipo>
 * {
 *      //membros: campos, propriedades, métodos, construtor, etc.
 * }
 * 
 * Ex:
 * struct Pessoa
 * {
 *      public string Nome;
 *      public int Idade{ get; set;}
 *      
 *      public void Exibir
 *      {
 *          Console.WriteLine("Struct");
 *      }
 * }
 */





public struct Cliente
{
    public string? Nome { get; set; }
    public int Idade { get; set; }

    public Cliente(string? nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}
