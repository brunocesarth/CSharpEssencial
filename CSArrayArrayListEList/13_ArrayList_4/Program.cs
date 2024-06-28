using System.Collections;

.var lista = new ArrayList() { "Maria", 5, true, 4.5, null, DateTime.Now };

//Verificar se um elemento existe na coleção

var res1 = lista.Contains(5);           //true
bool res2 = lista.Contains("Mari");     //false

Console.WriteLine(res1);
Console.WriteLine(res2);
Console.WriteLine(lista.Contains(null));

var list = new ArrayList() { "Maria", "Ana", "Zilda", "Carlos", "Diná" };

Console.WriteLine("\nArrayList original \n");
foreach (var item in list)
{
    Console.WriteLine($"{item}");
}

list.Sort();

Console.WriteLine("\nNúmero de elementos no array " + list.Count);
Console.WriteLine("\nArrayList ordenado \n");
foreach (var item in list)
{
    Console.WriteLine($"{item}");
}

list.Clear();
Console.WriteLine("\nNúmero de elementos no array depois do Clear " + list.Count);

Console.ReadKey();
