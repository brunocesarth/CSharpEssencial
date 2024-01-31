Cliente cliente = new(email: "Teste@teste.com", idade: 19, nome: "Testovaldo Testador");

cliente.ExibirInfo(cliente.Nome, cliente.Email, cliente.Idade);

Console.WriteLine();

cliente.ExibirInfo(cliente.Nome, cliente.Email);


Console.ReadKey();
