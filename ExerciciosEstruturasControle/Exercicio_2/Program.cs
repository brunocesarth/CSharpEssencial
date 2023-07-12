//2- Escreva um programa para calcular a raiz da equação quadrática: ax² + bx + c = 0

int a, b, c;
double delta, x1, x2;
Console.WriteLine("Cálculo da equação do sgundo grau(ax^2+bx+c)");
Console.Write("Informe o valor de a:\t");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de b:\t");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Informe o valor de c:\t");
c = Convert.ToInt32(Console.ReadLine());


delta = b * b - 4 * a * c;

if (delta == 0)
{
    Console.Write("As duas raízes são iguais.\n");
    x1 = -b / (2.0 * a);
    x2 = x1;
    Console.WriteLine($"Primeria raiz x1 = {x1}");
    Console.WriteLine($"Segunda raiz x2 = {x2}");
}
else if (delta > 0)
{
    Console.WriteLine("Ambas as raizes são reais e diferentes");
    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
    Console.WriteLine($"Primeria raiz x1 = {x1}");
    Console.WriteLine($"Segunda raiz x2 = {x2}");
}
else
{
    Console.WriteLine("As raízes são imaginárias" +
        "\nSem solução para os números reais");
}
