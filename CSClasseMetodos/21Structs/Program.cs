Console.WriteLine("### Structs ###\n");

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


Console.WriteLine("Exemplo 1");
Cliente cliente = new();

cliente.Nome = "Maria";
cliente.Idade = 19;

Console.WriteLine($"{cliente.Nome} {cliente.Idade}");

Console.WriteLine();
Console.WriteLine("Exemplo 2 - atribuição");


MinhaClasse mcls1 = new(), mcls2 = null;
MinhaStruct mstr1 = new(), mstr2 = new();

mcls1.x = mstr1.x = 5;
mcls1.y = mstr1.y = 10;

mcls2 = mcls1; // ref
mstr2 = mstr1; // valor

Console.ReadKey();

public class MinhaClasse
{
    public int x;
    public int y;
}

public struct MinhaStruct
{
    public int x;
    public int y;
}

/*
 * STRUCTS X CLASSES
 * 
 * CONSIDERE definir um struct em vez de uma classe se as instâncias do tipo forem pequenas e normalmente de curta duração ou se forem comumente incorporadas em outros objetos.
 * 
 * EVITE definir um struct, a menos que o tipo tenha todas as característica a seguir:
 * 
 * 1. Representa logicamente um único valor, semelhante aos tipos primitivos (int, double, etc.).
 * 2. Tem um tamanho de instância inferior da 16 bytes.
 * 3. É imutável.
 * 4. Não precisará sofrer conversão para tipo de referência (boxing) com frequência.
 */