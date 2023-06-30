using System.Threading.Channels;

Console.WriteLine("## Instrução if ##\n");

Console.WriteLine("Cliente Especial (true/false)");
var resposta = Convert.ToBoolean(Console.ReadLine());

if (resposta)
    Console.WriteLine("Desconto de 10%");

Console.WriteLine("Fim do processamento");
Console.ReadKey();

Console.WriteLine("----------------------------------------");

Console.Write("Informe o valor de x \t");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de y \t");
int y = Convert.ToInt32(Console.ReadLine());

if(x > y)
{
    Console.WriteLine("X é maior que y");
}

if(x < y)
{
    Console.WriteLine("x é menor que y");
}

if(x == y)
{
    Console.WriteLine("x é igual a y");
}

Console.ReadKey();