public class Carro
{
    public string? Modelo;
    public string? Montadora;
    public string? Marca;
    public int Cor;
    private int ano;
    public int Ano
    {
        get { return ano; }
        set
        {
            if (value < 2000)
            {
                ano = 2000;
            }
            else if (value > 2022)
            {
                ano = 2022;
            }
            else
            {
                ano = value;
            }
        }
    }
    public int Potencia;
    public static double ValorIpva;

    public Carro() { }

    public Carro(string? Modelo, string? Montadora, string? Marca, int Ano, int Potencia, int Cor)
    {
        this.Modelo = Modelo;
        this.Montadora = Montadora;
        this.Marca = Marca;
        this.Ano = Ano;
        this.Potencia = Potencia;
        this.Cor = Cor;
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
    
    static Carro()
    {
        ValorIpva = 4;
    }
    //public static void ObterValorIPVA()
    //{
    //    ValorIpva = 4;
    //}

    public void ExibirInfo(string modelo, string montadora, string marca, int potencia, int ano = 2023, int cor = 1)
    {
        Console.WriteLine($"{modelo}\n" +
            $"{montadora}\n" +
            $"{marca}\n" +
            $"{potencia} \n" +
            $"{ano}\n" +
            $"{cor}");
    }
}
