using _9ExemploPratico;

Console.WriteLine("### Exemplo prático ### \n");

Cadastro cadastro = new();

var cliente = cadastro.Registrar();
cadastro.ExibirDados(cliente);

// alterar renda
cliente = cadastro.Registrar(cliente);
cadastro.ExibirDados("Renda Alterada", cliente);

Console.ReadKey();
