﻿Console.WriteLine("Array Multidimensional 1\n");

int[,] a;

a = new int[2, 2];
a[0, 0] = 0;
a[0, 1] = 1;
a[1, 0] = 2;
a[1, 1] = 3;

Console.WriteLine("\nArray A\n");
Console.WriteLine(a[0, 0]);
Console.WriteLine(a[0, 1]);
Console.WriteLine(a[1, 0]);
Console.WriteLine(a[1, 1]);

Console.WriteLine("\nArray B\n");
//int[,] b = new int[2, 2] { { 20, 30 }, { 40, 50 } };
int[,] b = { { 20, 30 }, { 40, 50 } };

Console.WriteLine(b[0, 0]);
Console.WriteLine(b[0, 1]);
Console.WriteLine(b[1, 0]);
Console.WriteLine(b[1, 1]);

Console.ReadKey();
