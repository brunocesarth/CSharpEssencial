﻿Aluno aluno1 = new();
Aluno aluno2 = new("José");

Console.ReadKey();

//Base
class Pessoa
{
    public Pessoa()
    {
        Console.WriteLine("Construtor da classe Pessoa");
    }

    public Pessoa(string nome)
    {
        Console.WriteLine("Construtor da classe Pessoa com parametro");
    }
}

//Derivada  
class Aluno : Pessoa
{
    public Aluno() : base()
    {
        Console.WriteLine("Construtor da classe Aluno");
    }

    public Aluno(string nome) : base(nome)
    {
        {
            Console.WriteLine("Construtor da classe Aluno com parametro");
        }
    }
}