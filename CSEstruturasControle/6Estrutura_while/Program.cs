using System.Threading.Channels;

Console.WriteLine("## Instrução While ##\n");

var i = 1;

while (i <= 10)
{
    Console.WriteLine($"i = {i}");
    i++;
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();

i = 10;

while (i >= 1)
{
    Console.WriteLine($"i = {i}");
    i--;
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();

Console.WriteLine("-----------------------");

int numero;
int tabuada = 1;

Console.WriteLine("Digite um número maior do que zero");
numero = Convert.ToInt32(Console.ReadLine());

if (numero > 0)
    while (tabuada <= 10)
    {
        Console.WriteLine($"{numero} x {tabuada} = {numero * tabuada}");
        tabuada++;
    }
else
    Console.WriteLine("\nNúmero deve ser maior do que zero!!");

Console.WriteLine("Fim do processamento...");
Console.ReadKey();

Console.WriteLine("-----------------------");

while (true)
{
    Console.WriteLine("Digite um número inteiro: (Para sair tecle 999)");
    var var1 = Convert.ToInt32(Console.ReadLine());

    if (var1 == 999)
    {
        break;
    }

    if (var1 % 2 == 0)
    {
        Console.WriteLine($"{var1} é PAR");
    }
    else
    {
        Console.WriteLine($"{var1} é IMPAR");
    }
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();

Console.WriteLine("-----------------------");

int x = 0;
while (x < 5)
{
    int y = 0;
    while (y < 5)
    {
        Console.Write($"({x},{y})");
        y++;
    }
    x++;
    Console.WriteLine();
}

Console.WriteLine("Fim do processamento");
Console.ReadKey();
