// Exercícios - Fase 1
// Fundamentos
// 1 - Crie uma variável chamada idade e atribua a ela o valor 35 e exiba seu valor.
int idade = 35;
Console.WriteLine(idade);

// 2 - Crie uma variável chamada nome e atribua o valor "Maria" e exiba o seu valor.
string nome = "Maria";
Console.WriteLine(nome);

// 3 - Crie uma variável chamada altura e atribua a ela o valor 3.45.
double altura = 3.45;
Console.WriteLine(altura);

// 4 - Crie uma variável chamada data e atribua a ela a data 04/09/1999 e exiba seu valor.
DateTime data = new DateTime(1999, 09, 04);
Console.WriteLine(data.ToShortDateString());

// 5 - Crie uma constante chamada ano e atribua a ela o valor 12 e exiba o seu valor.
const int ANO = 12;
Console.WriteLine(ANO);

// 6 - Declare uma variável nota do tipo double como sendo do tipo Nullable type e atribua o valor 7.80 e exiba o seu valor.
double? nota = 7.8;
Console.WriteLine(nota);

// 7 - Quais as diferenças entre os tipos por valor e os tipos por referência?
// O tipo valor mantem os dados na mesma alocação de memória, já o tipo referência são armazenados em outro local que aponta para os dados reais

// 8 - Inclua o tipo de dados correto entre os parênteses nas seguintes declarações de variáveis:
//(int) x = 10;
//(double) numero = 7.99;
//(char) letra = 'C';
//(float) temperatura = 27.4f;
//(bool) ativo = false;
//(string) nome = "Manoel";
//(decimal) salario = 950.99m;
//(datetime) hoje = DateTime.Now

// 9 - Dada as variáveis declaradas a seguir classifique-as em tipos por valor(V) e tipos por referência(R):
//(v) int n = 1;
//(r) string titulo = "A vida";
//(v) float f = 12.45f;
//(v) double d = 5.45;
//(v) decimal valor = 10.99m;
//(v) char sexo = ‘M’;
//(r) object o = null;

// 10 - O que é um nullable type e qual a sua utilidade?
//Serve para atribuir o valor NULL a dados que normalmente não aceitam esse tipo

// 11 - O que é Camel Case? Dê um exemplo de sua aplicação
// É uma convenção para normear variáveis 
// Ex: valorTotal

// 12 - O que é Pascal Case? Dê um exemplo de sua aplicação
// É uma convenção para nomear classes e métodos
// Ex: ImprimirEtiqueta

// 13 - Declare duas variáveis x e y como sendo do tipo int e atribua a ela os valores 77 e 66 e a seguir imprima o valor da soma de x com y.(Use o operador aritmético + para realizar a operação de soma)
int x = 77;
int y = 66;
Console.WriteLine(x + y);


// 14 - Quais os valores padrões dos tipos de dados bool, char, int, double, float, decimal e string.

//15 - Indique verdadeiro(V) ou falso(F) para as seguintes declarações de variáveis 
//considerando a nomenclatura usada:
//(f) double 1valor = 12.45;
//(f) string #nome = "Pedro"; 
//(v) float _temperatura = 12.45f;
//(f) double int = 5;
//(f) decimal renda extra = 91.45m;
//(f) bool status$conta = false;
//(v) string titulo3 = “Tópico 1”;
//(v) float salario_mensal = 1999.55f;
//(v) int percentualValorDesconto = 5;
//(v) const bool MENSALIDADE_EM_DIA = true;