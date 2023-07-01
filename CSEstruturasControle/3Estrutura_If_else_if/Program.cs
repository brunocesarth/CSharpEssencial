Console.WriteLine("## Instrução if-else-if ##\n");

Console.WriteLine("\nInforme a nota do aluno \t");
var nota = Convert.ToDouble(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("Aluno reprovado");
}
else if (nota >= 5 && nota < 6)
{
    Console.WriteLine("Aluno em recuperação");
}
else if (nota >= 6 && nota <= 9)
{
    Console.WriteLine("Aluno Aprovado");
}
else
{
    Console.WriteLine("Aluno Aprovado com Distinção");
}

Console.WriteLine("Fim do processamento...");
Console.ReadKey();
