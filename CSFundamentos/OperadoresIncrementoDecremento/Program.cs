Console.WriteLine("## Operadores Incremento e Decremento ##\n");

//int x = 10;
//x++;
//Console.WriteLine(x);

//x--;
//Console.WriteLine(x);

int x = 0;
Console.WriteLine($"x = {x}");

// Pós-Incremento -> primeiro resolve depois incrementa
int resultado1 = x++ + 10;

Console.WriteLine($"Pós-Incremento ==> {resultado1}");
Console.WriteLine($"Valor de x ==> {x}\n");


// Pré-Incremento -> primeiro incrementa depois resolve
int y = 0;
Console.WriteLine($"y = {y}");
int resultado2 = ++y + 10;

Console.WriteLine($"Pré-Incremento ==> {resultado2}");
Console.WriteLine($"Valor de y ==> {y}\n");

// Pós-Decremento -> primeiro resolve depois decrementa
x = 0;
Console.WriteLine($"x ={x}");
resultado1 = x-- + 10;
Console.WriteLine($"Pós-Decremento ==> {resultado1}");
Console.WriteLine($"Valor de x ==> {x}\n");


// Pré-Decremento -> primeiro decrementa depois resolve
y = 0;
Console.WriteLine($"x ={y}");
resultado1 = --y + 10;
Console.WriteLine($"Pré-Decremento ==> {resultado1}");
Console.WriteLine($"Valor de y ==> {y}\n");


Console.ReadKey();
