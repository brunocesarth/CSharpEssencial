﻿using System.Threading.Channels;

Console.WriteLine("## Instrução if-else ##\n");

Console.WriteLine("Informe a nota do aluno \t");
var nota = Convert.ToInt32(Console.ReadLine());

if(nota > 5)
{
    Console.WriteLine("Aluno Aprovado");
}
else
{
    Console.WriteLine("Aluno Reprovado");
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();


Console.Write("Informe o valor de x\t");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o valor de y\t");
int y = Convert.ToInt32(Console.ReadLine());

if(x > y)
{
    Console.WriteLine("x é maior que y");
}
else
{
    if (x < y)
    {
        Console.WriteLine("x é menor que y");
    }
    else
    {
        Console.WriteLine("x é igual a y");
    }
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();
