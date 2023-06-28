Console.WriteLine("## Precedência de operadores ##\n");

int x = (10 - 2) * 3;
Console.WriteLine(x);

bool bo = !(9 != 8) && 5 >= 7 || 8 >= 6;
Console.WriteLine(bo);

bo = !(9 != 8) && (5 >= 7 || 8 >= 6);
Console.WriteLine(bo);

int a = 5, b = 6, c = 4;
int r = ((--a) * b) - (++c);
Console.WriteLine(r);

Console.ReadKey();
