using _7MetodosComRetorno;

Console.WriteLine("## Métodos com Retorno ##\n");

Calculadora calc = new();

var valor = calc.Somar(10, 10);
Console.WriteLine(valor);
Console.WriteLine(calc.Somar(10, 10));


Console.ReadKey();
