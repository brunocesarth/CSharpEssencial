Console.WriteLine("### Argumentor por referência OUT ###\n");

Console.WriteLine("Informe o raio do círculo");
double raio = Convert.ToDouble(Console.ReadLine());

Circulo circulo = new();

double circunferencia = circulo.CalculaAreaPerimetro(raio, out double area);
Console.WriteLine("Perímetro da Circunferência " + circunferencia);
Console.WriteLine("Área da Circunferência " + area);

Console.ReadKey();

public class Circulo
{
    public double CalculaAreaPerimetro(double raio, out double area)
    {
        area = Math.PI * Math.Pow(raio, 2);
        double perimetro = 2 * Math.PI * raio;
        return perimetro;
    }
}