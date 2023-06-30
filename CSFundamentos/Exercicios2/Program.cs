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
(x) double para long
(x) double para float
(x) decimal para float
(x) long para int
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
(F) A sequencia \t inclui uma tabulação vertical


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
double x1, x2;

x1 = Convert.ToDouble((-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));
x2 = Convert.ToDouble((-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a));

Console.WriteLine(x1);
Console.WriteLine(x2);

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
(F) A ordem de precedência dos operadores lógicos é : ! , || e && (NOT, OR e AND)
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
Console.Write("Digite o x: ");
int x3 = Convert.ToInt32(Console.ReadLine());
Console.Write("Digite o y: ");
int y3 = Convert.ToInt32(Console.ReadLine());

string rx = x3 % 2 == 0 ? "Par" : "Impar";
string ry = y3 % 2 == 0 ? "Par" : "Impar";

Console.WriteLine(rx);
Console.WriteLine(ry);

//12 - Crie um programa que receba um numero inteiro x via teclado e calcule e imprima no console o resultado das seguintes operações : (x ^ 2->x ao quadrado) (pi = 3.1415
Console.Write("Digite o x: ");
int x4 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Math.Pow(x4, 2));
Console.WriteLine(-6 + x4 * 5);
Console.WriteLine((13 - 2) * x4);
Console.WriteLine((x4 + -2) * (20 / x4));
Console.WriteLine((12 + x4) / (x4 - 4));
Console.WriteLine(3 * (Math.Pow(x4, 2) + x4 + 10));
Console.WriteLine(Math.PI * Math.Pow(x4, 2));

/*
 13- Considere o seguinte trecho de código:
int y = 5 ;
y = (y++)+y+(++y); ou y = y++ + y + ++y;
Console.WriteLine(y);

 */

/* 
 14- Escreva um programa que solicite a temperatura em graus Celsius e converta para 
Kelvin e Farhenheit usando as fórmulas a seguir:
- Converter para Kelvin => K = C + 273 ;
- Converter para Farhenheit => F = (C * 9) / 5 + 32 
*/
Console.Write("Digite a temperatura(Cº): ");
double celsius = Convert.ToDouble(Console.ReadLine());
double k = celsius + 273;
double f = (celsius * 9) / 5 + 32;

Console.WriteLine($"Kelvin: {k}");
Console.WriteLine($"Fahrenheit: {f}");


/*15 - Escolha a opção que representa a exibição do resultado para o código usando os operadores de decremento e incremento (pré e pós) 
    (X) 5 2 2 2
*/