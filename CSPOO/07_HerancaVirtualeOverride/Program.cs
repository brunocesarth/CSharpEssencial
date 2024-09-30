﻿var gato = new Gato() { Nome = "Bichano" };
gato.ExibeNome();

var cao = new Cachorro() { Nome = "Pipoca" };
cao.ExibeNome();

Console.ReadKey();

// Classe base
class Animal
{
    public string? Nome { get; set; }
    public virtual void ExibeNome()
    {
        Console.WriteLine($"\nMeu nome é {Nome}.");
    }
}

// Classe derivada
class Gato : Animal
{
    public override void ExibeNome()
    {
        Console.WriteLine($"\nEu sou um gato. Meu nome é: {Nome}");
    }
}

class Cachorro : Animal { }