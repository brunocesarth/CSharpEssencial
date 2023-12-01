using Exercicio_01;

Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);

Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);

Console.WriteLine(chevrolet.ToString());
chevrolet.Acelerar(chevrolet.Marca);
Console.WriteLine();
Console.WriteLine(ford.ToString());
ford.Acelerar(ford.Marca);
