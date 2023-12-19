Console.WriteLine("### MÉTODOS ESTÁTICOS ###\n");

var somar = Calculadora.Somar(10, 10);
var subtrair = Calculadora.Subtrair(10, 10);
var multiplicar = Calculadora.Multiplicar(10, 10);
var dividir = Calculadora.Dividir(10, 10);

Console.WriteLine(somar);
Console.WriteLine(subtrair);
Console.WriteLine(multiplicar);
Console.WriteLine(dividir);

Console.ReadKey();

public class Calculadora
{
    public static int Somar(int n1, int n2) => n1 + n2;
    public static int Subtrair(int n1, int n2) => n1 - n2;
    public static int Multiplicar(int n1, int n2) => n1 * n2;
    public static int Dividir(int n1, int n2) => n1 / n2;
}

/*
 * O modificador static pode ser usado em classes, interfaces, structs, campos, métodos, propriedades, operadores, eventos e construtores.
 * Os métodos estaticos são métodos que não dependem de um objeto ou seja não dependem da criação de uma instância da classe para serem acessados.
 * Os métodos estáticos pertencem à classe e não ao objeto.
 * Como o método estático não possui ligação com um objeto, ele não pode usar variáveis de instância, que são variáveis do objeto.
 * Exemplos: Classes Math e Console e o método Main
*/