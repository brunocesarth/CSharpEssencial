Carro chevrolet = new("Sedan", "Chevrolet", "Onix", 2016, 110);

//chevrolet.Acelerar(chevrolet.Marca);

Console.WriteLine($"{chevrolet.Modelo} {chevrolet.Montadora} {chevrolet.Marca}" +
$" {chevrolet.Ano} {chevrolet.Potencia} CV");


Console.WriteLine("Aumentando a Potencia (por valor : + 3CV) : ");
var novaPotenciaChevrolet = chevrolet.AumentarPotencia(chevrolet.Potencia);
Console.Write("-> " + novaPotenciaChevrolet);
Console.WriteLine("\nO valor do campo Potencia não foi alterado : " + chevrolet.Potencia);


Carro ford = new("SUV", "Ford", "EcoSport", 2018, 120);

//ford.Acelerar(ford.Marca);

Console.WriteLine($"{ford.Modelo} {ford.Montadora} {ford.Marca}" +
$" {ford.Ano} {ford.Potencia} CV");

Console.Write("\nAumentando a Potencia (por referência : +5CV) : ");
var novaPotenciaFord = ford.AumentarPotencia(ref ford.Potencia);
Console.Write("-> " + novaPotenciaFord);
Console.WriteLine("\nO valor do campo Potencia foi alterado : " + ford.Potencia);



var novaPotenciaChev = chevrolet.AumentarPotenciaVelocidade(chevrolet.Potencia, out double velocidade);
Console.WriteLine("\nO valor do campo nova potencia é : " + novaPotenciaChev);
Console.WriteLine("\nO valor do campo nova velocidade é : " + velocidade);

Console.ReadKey();

