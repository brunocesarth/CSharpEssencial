using System.Linq;

List<Produto> produtos = [new Produto() { Nome = "Clips", Preco = 3.95m }, new Produto() { Nome = "Caneta", Preco = 5.99m }, new Produto() { Nome = "Lápis", Preco = 4.15m }, new Produto() { Nome = "Estojo", Preco = 6.99m }, new Produto() { Nome = "Caderno", Preco = 7.55m }];
ExibirLista(produtos);
Console.WriteLine();

produtos.Add(new Produto() { Nome = "Mochila", Preco = 22.44m });

ExibirLista(produtos);

Console.WriteLine();
ExibirLista(([.. produtos.OrderBy(x => x.Nome)]));

Console.WriteLine();
Console.WriteLine("Produtos com valor inferior a R$ 5,00");
foreach (var produto in produtos)
{
    if (produto.Preco < 5.00m)
    {
        Console.WriteLine($"{produto.Nome}");
    }
}

Console.WriteLine();

var indexDoProduto = produtos.FindIndex(x => x.Nome == "Estojo");

if(indexDoProduto < 0)
{
    Console.WriteLine($"O produto não existe na lista");
}
else
{
    Console.WriteLine($"O produto está na lista e seu index é {indexDoProduto}");
}

Console.ReadKey();

void ExibirLista(List<Produto> produtos)
{
    decimal valorTotalProdutos = 0;
    decimal mediaPrecos = 0;
    foreach (Produto produto in produtos)
    {
        Console.WriteLine($"{produto.Nome} \t {produto.Preco:C}");
        valorTotalProdutos += produto.Preco;
    }
    mediaPrecos = valorTotalProdutos / produtos.Count;

    Console.WriteLine($"O soma do valor de todos os produtos é {valorTotalProdutos:C}");
    Console.WriteLine($"A média do valor dos produtos é {mediaPrecos:C}");
    Console.WriteLine($"A lista possui {produtos.Count} produtos");
}