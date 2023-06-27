Console.WriteLine("Saída de dados : Formatação");
Console.WriteLine();

int idade = 25;
string nome = "Maria";
Console.Write(nome);
Console.Write(idade);
Console.WriteLine();

// Escreve na mesma linha 'Maria tem 25 anos'
Console.Write(nome);
Console.Write(" tem ");
Console.Write(idade);
Console.WriteLine(" anos ");

// Usar a concatenação : usando o operador +
Console.WriteLine("------Concatenação----------------------");
Console.WriteLine(nome + " tem " + idade + " anos");
Console.Write(nome + " tem " + idade + " anos");
Console.WriteLine();

// Usar a interpolação de strings : $ -> a interpolação {}
Console.WriteLine("------Interpolação-----------------------");
Console.WriteLine($"{nome} tem {idade} anos");

// Usar placeholders : usa {} com numeração com inicio em zero
Console.WriteLine("------PlaceHolders-----------------------");
Console.WriteLine("{0} tem {1} anos", nome, idade);

Console.ReadLine();
