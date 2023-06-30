Console.WriteLine("Exercícios fase 2");

Console.WriteLine("Digite um número:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("digite mais um número:");
int y1 = Convert.ToInt32(Console.ReadLine());

string r = x

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

// 9- Escreva um programa que receba um nome e uma senha via teclado. Nome é uma string e Senha é um inteiro. Se o nome for igual a ‘admin’ ou ‘maria’ e a senha for igual a ‘123’ então exiba a mensagem ‘Login feito com sucesso’ caso contrário exiba a mensagem ‘Login inválido’: (use o operador condicional ternário)

Console.Write("Digite um nome: ");
nome = Console.ReadLine();
Console.Write("Digite uma senha: ");
int senha = Convert.ToInt32(Console.ReadLine());

string r = (nome == "admin" || nome == "maria") && senha == 123 ? "Login feito com sucesso" : "Login inválido";

Console.WriteLine(r);

/*
 10- Indique verdadeiro(V) ou falso (F) para as seguintes declarações de variáveis considerando 
a nomenclatura usada:
(V) string? nome; é um exemplo de nullable reference type;
(F) para x igual a 0 , Console.WriteLine(x++); imprime o valor 1
(V) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
(V) para y igual a 0 , Console.WriteLine(++y); imprime o valor 1
(F) (10 % 2 == 0) ? “Par” : “Impar”; Vai retornar “Impar”
(F) Para x=25 e y=5 , a expressão ( y >= x ) && ( y <= x ); retorna true;
(V) Os nullable reference types emitem um alerta em tempo de compilação para uso do null
(F) Para x = 10 , o código Console.WriteLine(x+=x); imprime o valor 10;
(F) Para x= 5 , a expressão !(9 >= x) && x <= 7 || x == 5); retorna false;
(V) O operador ?. permite verificar se um objeto é null e evitar o NullReferenceException
(V) Qualquer tipo de dado pode ser declarado como anulável com a ajuda do operador "?"

11- Escreva um programa que recebe via teclado dois números inteiros x e y e imprima no 
console se x é par ou não e se y é par ou não. Use o operador condicional ternário (? :)
 */
int 
