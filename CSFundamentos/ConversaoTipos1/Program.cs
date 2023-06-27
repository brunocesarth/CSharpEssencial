Console.WriteLine("##Conversão de tipos##\n");

//int varInt = 100;
//double varDouble = varInt;

// byte -> 1 byte
// short -> 2bytes
// int -> 4 bytes
// long -> 8 bytes
// float -> 4 bytes
// double -> 8 bytes
// decimal -> 16 bytes
// Quando a conversão é feita de uma variavel de um tipo com menor valor para um tipo de maior valor, a conversão é implicita

//Console.WriteLine(varDouble);

int numeroInt = 2145678;
long numeroLong = numeroInt;
float numeroFloat = numeroInt;
double numeroDouble = numeroInt;
decimal numeroDecimal = numeroInt;

Console.WriteLine(numeroInt);
Console.WriteLine(numeroLong);
Console.WriteLine(numeroFloat);
Console.WriteLine(numeroDouble);
Console.WriteLine(numeroDecimal);


double varDouble = 12.456;      //8 bytes
int varInt = (int)varDouble;    //4 bytes (perda de precisão)

Console.WriteLine(varInt);

int num1 = 10;
int num2 = 4;

float resultado = (float) num1 / num2;

Console.WriteLine(resultado);

Console.ReadLine();
