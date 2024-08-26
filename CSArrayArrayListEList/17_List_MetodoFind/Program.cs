
List<string> frutas = new() {
    "Uva","Banana", "Pera","Maça","Abacate","Laranja", "Morango"
};

// Usando predicado como uma função
var fruta1 = frutas.Find(Procura);
Console.WriteLine($"\nPredicado => {fruta1} ");

// Usando a expressão lambda
var fruta2 = frutas.Find(i => i.Contains('n'));
Console.WriteLine($"\nExpressão lambda => {fruta2} ");


Console.ReadKey();



static bool Procura (string item)
{
    return item.StartsWith('L');
}