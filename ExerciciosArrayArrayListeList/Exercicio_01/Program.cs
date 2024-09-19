List<string> frutas =  ["Maça", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Abacate", "Mamão", "Pêssego", "Amora"];

foreach(var f in frutas)
{
    Console.WriteLine(f);

}
Console.WriteLine(frutas.Count);
Console.WriteLine();
Console.WriteLine(frutas[^2]);
Console.WriteLine(frutas[1]);

frutas[2] = "Kiwi";
frutas[^1] = "Caqui";

var ordemAscendente = frutas.OrderBy(f => f).ToList();
Console.WriteLine();
foreach(var f in ordemAscendente)
{
    Console.WriteLine(f);
}

var ordemDescendente = frutas.OrderByDescending(f => f).ToList();
Console.WriteLine();
foreach (var f in ordemDescendente)
{
    Console.WriteLine(f);
}