//7 - Escreva um programa para exibir o padrão como triângulo de ângulo reto usando asterisco (*). Ex:
//*
//**
//***
//****

int i = 1, j = 0;

while(i <= 4)
{
    j = 0;
    while(j < i)
    {
        Console.Write("*");
        j++;
    }
    Console.WriteLine();
    i++;
}
