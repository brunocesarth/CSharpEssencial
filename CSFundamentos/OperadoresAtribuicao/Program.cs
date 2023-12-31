﻿Console.WriteLine("## Operadores de atribuição ##\n");

// Usando operadores atribuição com tipos númericos

var x = 10;
Console.WriteLine($"Valor inicial de x = {x}");
Console.WriteLine($"x += 5 ==> {x += 5}");
Console.WriteLine($"x -= 3 ==> {x -= 3}");
Console.WriteLine($"x *= 4 ==> {x *= 4}");
Console.WriteLine($"x /= 5 ==> {x /= 5}");
Console.WriteLine($"x %= 5 ==> {x %= 5}");

Console.WriteLine("------------------------------");

string y = "123";
Console.WriteLine($"Valor inicial de y = {y}");

y += "456";

Console.WriteLine($"y += \"456\" ==> {y}");

Console.ReadKey();
