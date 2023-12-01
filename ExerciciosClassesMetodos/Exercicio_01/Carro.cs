using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_01
{
    internal class Carro
    {
        public string? Modelo { get; set; }
        public string? Montadora { get; set; }
        public string? Marca { get; set; }
        public int Ano { get; set; }
        public int Potencia { get; set; }

        public Carro(string modelo, string montadora, string marca, int ano, int potencia)
        {
            this.Modelo = modelo;
            this.Montadora = montadora;
            this.Marca = marca;
            this.Ano = ano;
            this.Potencia = potencia;
        }

        public void Acelerar(string marca)
        {
            Console.WriteLine($"Acelerando o meu {marca}");
        }

        public override string ToString()
        {
            return "Modelo:" + Modelo + "\n"
                + "Montadora: " + Montadora + "\n"
                + "Marca: " + Marca + "\n"
                + "Ano: " + Ano + "\n"
                + "Potência: " + Potencia +" CV" + "\n";
        }
    }
}
