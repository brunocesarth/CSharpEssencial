Console.WriteLine("###############################");
Console.WriteLine("Escolha a cor do carro:\r\n" +
    "1 - Branco,\r\n" +
    "2 - Vermelho,\r\n" +
    "3 - Preto,\r\n" +
    "4 - Cinza,\r\n" +
    "5 - Prata,\r\n" +
    "6 - Azul");

int cor = int.Parse(Console.ReadLine());

Carro carro = new("SUV","Volkswagen","Taos",2023, 110, cor);


carro.ExibirInfo(carro.Modelo, carro.Montadora, carro.Marca, carro.Potencia, carro.Ano, carro.Cor);
