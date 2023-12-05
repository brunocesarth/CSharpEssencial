namespace Exercicio_02
{
    internal class Carro
    {
        public string? Modelo { get; set; }
        public string? Montadora { get; set; }
        public string? Marca { get; set; }
        public int Ano { get; set; }
        public int Potencia { get; set; }

        public Carro(string? modelo, string? montadora)
        {
            Modelo = modelo;
            Montadora = montadora;
        }

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

        public double VelocidadeMaxima(int potencia)
        {
            return potencia * 1.75;
        }

        public override string ToString()
        {
            return "Modelo:" + Modelo + "\n"
                + "Montadora: " + Montadora + "\n"
                + "Marca: " + Marca + "\n"
                + "Ano: " + Ano + "\n"
                + "Potência: " + Potencia + " CV" + "\n";
        }
    }
}
