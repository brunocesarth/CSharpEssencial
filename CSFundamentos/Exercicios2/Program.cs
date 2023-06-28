Console.WriteLine("Exercícios fase 2");

// 1 - Declare as variáveis nome, idade e nota atribuindo os valores "Paulo", 17 e 7.5 e exiba a saída no formato: Aluno <nome> tem <idade> anos e nota <nota> usando a concatenção e a interpolação de strings.
string nome = "Paulo";
int idade = 17;
double nota = 7.5;
// Concatenção
Console.WriteLine("Aluno " + nome + " tem " + idade + " anos e nota " + nota);
// Interpolação
Console.WriteLine($"Aluno {nome} tem {idade} anos e nota {nota}");

// 2 - Para o exercício anterior exiba o nome a idade e a nota em linhas separadas usando as sequências de escapes
Console.Write($"Aluno {nome}\n");
Console.Write($"Idade {idade}\n");
Console.Write($"Nota {nota}");

/*
3- Para qual tipo de dados você pode converter um float implicitamente ?
( ) int 
(x) double
( ) long
(x) decimal

4- Em qual conversão numérica você precisaria realizar o casting (convesão forçada) ? 
( ) int para long
( ) double para long
( ) double para float
( ) decimal para float
( ) long para int
(X) double para decimal


5- Escreva um programa que recebe 3 letras via teclado e as exiba na ordem reversa usando 
a concatenação e também a interpolação de strings
 */
Console.WriteLine("---------------------------");
Console.WriteLine("Escreva uma letra");
char letra1 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Escreva uma letra");
char letra2 = Convert.ToChar(Console.ReadLine());
Console.WriteLine("Escreva uma letra");
char letra3 = Convert.ToChar(Console.ReadLine());

// Interpolação
Console.WriteLine($"{letra3}, {letra2}, {letra1}");
// Concatenação
Console.WriteLine(letra3 + "," + letra2 + "," + letra1);

/*
6- Marque verdadeiro(V) ou falso(F) para os códigos abaixo:
(F) long resultado = 1.32;
(V) var nome = “Maria”;
(V) string resultado = 100.ToString();
(V) A sequência de escape \n inclui uma nova linha
(F) float f = 5.45; 
(V) decimal valor = (decimal) 10.99f;
(F) var status = null;
(V) object o = 12.45m;
(V) string titulo = true.ToString(); 
(V) A sequencia \t inclui uma tabulação vertical


7- Escreva um programa para receber dois valores via teclado do tipo double e a seguir 
realize as operações de soma, subtração, multiplicação, exponenciação, divisão e módulo 
exibindo o resultado:
 */

Console.WriteLine("Digite o primeiro valor: ");
double valor1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo valor: ");
double valor2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine(valor1 + valor2);
Console.WriteLine(valor1 - valor2);
Console.WriteLine(valor1 * valor2);
Console.WriteLine(Math.Pow(valor1, valor2));
Console.WriteLine(valor1 / valor2);
Console.WriteLine(valor1 % valor2);

//8 - Faça um programa para calcular o resultado da fórmula de baskara dados os valores de a b e c .
int a = 1, b = 12, c = -13;

