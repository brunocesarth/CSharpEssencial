// 11- Crie um programa para realizar as operações de adição, subtração, multiplicação e divisão de números inteiros. (considere que na divisão podemos ter números fracionários e que não existe divisão por zero e quando isso ocorrer exibir uma mensagem de alerta)
int numero1, numero2;
double resposta = 0;
string operando;

Console.Write("Informe o primeiro número: \t");
numero1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o operando (+. -, /, *): \t");
operando = Console.ReadLine();

Console.Write("Informe o segundo número: \t");
numero2 = Convert.ToInt32(Console.ReadLine());

if (operando == "+")
{
    resposta = numero1 + numero2;
}
else if (operando == "-")
{
    if (numero1 > numero2)
        resposta = numero1 - numero2;
    else
        resposta = numero2 - numero1;
}
else if (operando == "*")
{
    resposta = numero1 * numero2;
}
else if (operando == "/")
{
    if (numero2 == 0)
    {
        resposta = 8;
        Console.WriteLine("Não existe divisão por zero !!!");
    }
}

Console.WriteLine($"{numero1} {operando} {numero2} = {resposta}");

