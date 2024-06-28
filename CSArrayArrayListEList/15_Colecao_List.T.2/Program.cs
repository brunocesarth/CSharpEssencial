var lista = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Zé" };

lista.Add("Marta");
lista.Insert(2, "Bia");

Console.WriteLine(lista.Count + " itens");

var lista1 = new List<string>() { "Maria", "Pedro", "Ana" };
string[] array1 = { "Diná", "Carlos", "Pedro" };

lista1.AddRange(array1);
lista1.InsertRange(1, array1);

Console.WriteLine(lista1.Count + " itens");

var listaInteiros = new List<int> { 9, 5, 4, 1, 7, 8, 3, 6, 9, 0 };
listaInteiros.Remove(7);
listaInteiros.RemoveAt(4);
listaInteiros.RemoveRange(0, 2);
Console.WriteLine(listaInteiros.Count + " itens");

var nomes = new List<string>() { "Maria", "Ana", "Marcos", "Pedro" };

// Acessar um elemento da lista usando índice
var primeiro = nomes[0];
var quarto = nomes[3];

Console.WriteLine(primeiro);
Console.WriteLine(quarto);

nomes[0] = "Zé";
nomes[3] = "Silvia";

Console.WriteLine(nomes[0]);
Console.WriteLine(nomes[3]);

for (int i = 0; i < lista.Count; i++)
{
    Console.WriteLine(lista[i]);
}


foreach (var item in lista)
{
    Console.WriteLine(item);
}

var res1 = lista.Contains("Ana");
var res2 = lista.Contains("Zé");

var res3 = lista.Contains("Ze");
var res4 = lista.Contains("Mari");

Console.WriteLine(lista.Contains("Pedro"));

ExibirLista(lista);
Console.WriteLine();

lista.Sort();
ExibirLista(lista);
Console.WriteLine();

lista.Clear();
ExibirLista(lista);
Console.WriteLine("Fim");


Console.ReadKey();

static void ExibirLista(List<string> lista)
{
    foreach (var item in lista)
        Console.WriteLine(item);
}