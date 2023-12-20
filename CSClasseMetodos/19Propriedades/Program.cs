Console.WriteLine("### Propriedades ###\n");




Console.ReadKey();

/*
 * O uso de campos públicos permite que qualquer um que crie uma instância da classe possa acessar e atribuir valores aos campos sem nenhum controle e validação
 * Para resolver esse problema o C# permite usar PROPRIEDADES ao invés de CAMPOS
 * 
 * PROPRIEDADES
 * Uma propriedade é um membro da classe que fornece um mecanismo para ler, gravar ou calcular o valor de um campo privado.
 * As propriedades podem ser usadas como se fossem membros de dados públicos, mas possuem métodos especiais chamados acessadores.
 * Esse recurso permite que os dados sejam acessados com facilidade e ainda ajuda a promover a segurança e a flexibilidade dos métodos.
 * 
 * As propriedades permitem que uma classe exponha uma maneira pública de obter e definir valores, enquanto oculta o código de implementação ou verificação.
 * 
 * PROPRIEDADE : SINTAXE
 * Uma propriedade é uma combinação de um campo privado e de dois acessadores: o get e o set.
 * 
 * SINTAXE ANTIGA:
 ** Definição da propriedade Nome.
 * *public class Pessoa
 * *{
 * *   private string nome; //CAMPO
 * *   public string Nome //PROPRIEDADE
 * *   {
 * *     get{return nome;} // ACESSADOR GET
 * *     set{nome = value;} // ACESSADOR SET
 * *   }
 * *}
 * 
 * SINTAXE MODERNA:
 ** Mesma definição usando as propriedades automáticas.
 ** public class Pessoa
 ** {
 **      public string Nome {get;set;}
 ** }
 * 
 * 
 **USANDO CAMPOS PÚBLICOS
 **Permite o acesso ao campo para quem criar uma instância da classe e não tem controle sobre a atribuição de dados.
 **Os campos expõem o estado de um objeto da classe ao mundo exterior
 **public class Cliente
 **{
 **  public string? Nome;
 **  public int Idade;
 **
 **  public Cliente(string? nome, int idade)
 **  {
 **    Nome = nome;
 **    Idade = idade;
 **  }
 * }
 * 
 * 
 **USANDO PROPRIEDADES PÚBLICAS
 **Usa um CAMPO DE APOIO PRIVADO para definir e recuperar o valor da propriedades.
 **O acessador get retorna o valor do campo privado.
 **O acessador set pode realizar alguma validação de dados antes de atribuir um valor ao campo privado.
 **public class Cliente
 **{
 **  public string? Nome {get;set;}
 **  public int Idade {get;set;}
 ** 
 **  public Cliente(string? nome, int idade)
 **  {
 **    Nome = nome;
 **    Idade = idade;
 **  }
 **}
 *
 *
 *
 **As propriedades leitura e gravação têm um acessador get e um set (padrão)
 **public string? Nome {get;set;}
 **public int Idade {get;set;}
 *
 **As propriedades somente leitura têm um acessador GET, mas nenhum acessador set
 **public string? Nome{get;}
 **
 **As propriedades somente gravação têm um acessador SET, mas não tem um acessador get
 **private int Idade;
 **public int Idade { set{ idade = value; }
 *
 **PROPRIEDADES : VANTAGENS
 **Permitem um melhor controle dos membros da classe (reduz a possibilidade de você (ou outros) bagunçar o código)
 **Os campos privados podem ser somente leitura, se você usar apenas o método get, ou somente gravação, se você usar apenas o método set.
 **São mais flexíveis pois o programados pode alterar uma parte do código sem afetar outras partes.
 **Garantem uma maior segurança dos dados permitindo controlar o acesso
 **Um dos pilares da programação orientada a objetos é justamente o encapsulamento dos dados da classe, e, isso significa que o trabalho interno de uma classe deve ser escondido do mundo exterior.
 */