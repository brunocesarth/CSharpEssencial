public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Ano;
    public int Potencia;


    public Carro(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
    }

    public Carro(string? modelo, string? montadora)
    {
        Modelo = modelo;
        Montadora = montadora;
    }

    public void Acelerar(string marca)
    {
        Console.WriteLine("\nAcelerando o meu " + marca);
    }

    public double VelocidadeMaxima(int potencia)
    {
        return potencia * 1.75;
    }

    public int AumentarPotencia(int potencia)
    {
        potencia += 3;
        return potencia;
    }

    public int AumentarPotencia(ref int potencia)
    {
        potencia += 5;
        return potencia;
    }

    public int AumentarPotenciaVelocidade(int potencia, out double velocidade)
    {
        potencia += 7;
        velocidade = potencia * 1.75;
        return potencia;
    }

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 2023)
    {
        Console.WriteLine($"{modelo}\n" +
            $"{montadora}\n" +
            $"{marca}\n" +
            $"{potencia} \n" +
            $"{ano}");
    }
}
