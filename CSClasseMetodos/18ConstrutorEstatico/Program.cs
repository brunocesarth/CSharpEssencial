using _18ConstrutorEstatico;

Console.WriteLine("### Construtor Estático ###\n");

// Invoca o construtor parametrizado e o estático
Pessoa p1 = new("Maria", 19);

Console.WriteLine(p1.Nome + " - " + p1.Idade);
Console.WriteLine("Idade Minima " + Pessoa.IdadeMinima);

//Invoca somente o construtor parametrizado
Pessoa p2 = new(idade: 20, nome: "Manoel");
Console.WriteLine(p2.Nome + " - " + p2.Idade);
Console.WriteLine("Idade Minima " + Pessoa.IdadeMinima);

Console.ReadKey();


/*
 * Um construtor estático é usado para inicializar quaisquer membros estáticos ou para executar uma ação específica que precisa ser executada apenas uma vez,
 * Ele é chamado automaticamente antes que a primeira instância seja criada ou que quaisquer membros estáticos sejam referênciados.
 * 
 * Propriedades do construtor estático
 * * Um construtor estático não usa modificadores de acesso nem tem parâmetros.
 * * Uma classe ou struct só pode ter um único construtor estático.
 * * Um construtor estático não pode ser chamado diretamente.
 * * O usuário não tem controle sobre quando o construtor estático é executado no programa.
 * * Se você não fornecer um construtor estático pa inicializar campos estáticos, todos os campos estáticos serão inicializados com seu valor padrão.
 * * Se um construtor estático gerar uma exceção, o runtime não invocará uma segunda vez, e o membro estático permanecerá não inicializado durante o tempo de vida do aplicativo.
 * 
 * Para criar um construtor estático basta criar um construtor sem parâmetros usando a palavra-chave static
 */