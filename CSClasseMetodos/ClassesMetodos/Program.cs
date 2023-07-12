﻿Console.WriteLine("## Classes e Métodos ##\n");

int x = 100;

Pessoa p1 = new Pessoa();
p1.Nome = "Maria";
p1.Idade = 25;
p1.Sexo = "feminino";

Console.WriteLine($"{p1.Nome} {p1.Idade} {p1.Sexo}");

Pessoa p2 = new Pessoa();
p2.Nome = "Manoel";
p2.Idade = 23;
p2.Sexo = "masculino";

Console.WriteLine($"{p2.Nome} {p2.Idade} {p2.Sexo}");

Console.ReadKey();

class Pessoa
{
    public string? Nome { get; set; }
    public int Idade { get; set; }
    public string? Sexo { get; set; }
}