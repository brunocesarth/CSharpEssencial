Console.WriteLine("\n ## Entrada de dados ##");

Console.WriteLine("\nInforme o seu nome:");
string nome = Console.ReadLine();

Console.WriteLine("\nO seu nome é " + nome);

Console.WriteLine($"\nO seu nome é {nome}");

Console.WriteLine("\nInforme a sua idade:");
int idade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("\nA sua idade é " +  idade + " anos");
Console.WriteLine($"\nA sua idade é {idade} anos");

Console.WriteLine($"\nO seu nome é {nome}");
Console.WriteLine($"\ne você tem {idade} anos");

Console.ReadKey();