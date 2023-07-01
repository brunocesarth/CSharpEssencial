Console.WriteLine("## Estrutura switch-case ##\n");

int compra = 600;
Console.WriteLine("Valor da compra R$ 600,00\n");
Console.WriteLine("Informar o número de prestações (1 a 3)\t");
var numeroParcelas = Convert.ToInt32(Console.ReadLine());

switch (numeroParcelas)
{
    case 1:
        Console.WriteLine($"\nPrestação R${compra / numeroParcelas}");
        break;
    case 2:
        Console.WriteLine($"\nPretação R${compra / numeroParcelas}");
        break;
    case 3:
        Console.WriteLine($"\nPrestação R${compra / numeroParcelas}");
        break;
    default:
        Console.WriteLine($"\nValor inválido, informe 1, 2 ou 3");
        break;
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();


Console.WriteLine("---------------------------------------------");

Console.Write("Informe um número inteiro: \t");
int numero = Convert.ToInt32(Console.ReadLine());

switch (numero % 2)
{
    case 0:
        Console.WriteLine("\n" + numero + " é par");
        break;
    case 1:
        Console.WriteLine("\n" + numero + " é impar");
        break;
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();

Console.WriteLine("---------------------------------------------");

Console.WriteLine("Informe o nome do mês\t");
var mes = Console.ReadLine().ToLower();

switch (mes)
{
    case "janeiro":
    case "março":
    case "maior":
    case "julho":
    case "agosto":
    case "outubro":
    case "dezembro":
        Console.WriteLine("Este mês tem 31 dias");
        break;

    case "fevereiro":
        Console.WriteLine("Este mês tem 28 ou 29 dias");
        break;

    default:
        Console.WriteLine("Este mês tem 30 dias");
        break;
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();

Console.WriteLine("---------------------------------------------");

int cargo = 0;
int funcao = 0;

Console.WriteLine("Você é Gerente(1) ou Programador(2) ?\t");
cargo = Convert.ToInt32(Console.ReadLine());

if (cargo == 2)
{
    Console.WriteLine("Você é Junior(1) ou Senior(2) ?\t");
    funcao = Convert.ToInt32(Console.ReadLine());
}

switch (cargo)
{
    case 1:
        Console.WriteLine("\nBem-Vindo Gerente.");
        break;
    case 2:
        Console.WriteLine("\nBem-Vindo Programador.");
        switch (funcao)
        {
            case 1:
                Console.WriteLine("\nVocê é Junior");
                break;
            case 2:
                Console.WriteLine("\nVocê é Senior.");
                break;
            default:
                Console.WriteLine("\nFunção desconhecida");
                break;
        }
        break;
    default:
        Console.WriteLine("\nNão consigo te identificar");
        break;
}

Console.WriteLine("\nFim do processamento...");
Console.ReadKey();
