Console.WriteLine("## Operador Uniário e Ternário ##\n");

int positivo = 1;
int resultado;

resultado = +positivo;
Console.WriteLine(resultado);

Console.Write("Informe o número: \n");
var n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"O negativo de {n} é {-n}");

Console.WriteLine("-------------------------------");

Console.Write("Informe a temperatura: \n");
var temp = Convert.ToDouble(Console.ReadLine());

var result = temp > 27 ? "Quente" : "Normal";

Console.WriteLine($"O tempo está {result}");

Console.WriteLine("-------------------------------");
Console.WriteLine("Informe o valor de x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o valor de y");
int y = Convert.ToInt32(Console.ReadLine());

string r = x > y ? "x é maior que y" :
           x < y ? "x é menor que y" :
           x == y ? "x é igual a y" : "Sem resultado";

Console.WriteLine(r);

Console.ReadKey();
