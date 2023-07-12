// 6- Crie um programa para exbir no console os números pares de 10 a 20, ambos incluídos, exceto 16, de 3 maneiras diferentes:

int i = 10;

while (i <= 20)
{
    if (i % 2 == 0)
    {
        if (i == 16)
        {
            i += 1;
            continue;
        }
        Console.WriteLine(i);
    }
    i++;
}

Console.WriteLine("------------------------------");

for (i = 10; i <= 20; i += 2)
{
    if (i % 2 == 0)
    {
        if (i == 16)
            continue;

        Console.WriteLine(i);
    }
}

Console.WriteLine("------------------------------");

i = 10;

do
{
    if (i % 2 == 0)
    {
        if (i == 16)
        {
            i += 1;
            continue;
        }
        Console.WriteLine(i);
    }
    i++;
} while (i <= 20);
