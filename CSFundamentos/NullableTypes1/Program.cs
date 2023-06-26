Console.WriteLine("## Nullable Types ##\n");

//Nullable<int> i = null;
//Nullable<double> d = null;
//Nullable<bool> b = null;

//int? i = null;
//double? d = null;
//bool? b = null;

//Console.WriteLine(i);
//Console.WriteLine(d);
//Console.WriteLine(b);

int? a = null;
int b = a ?? 0;
Console.WriteLine(b);

int? x = 4;
int? y = 3;
int? z = x * y;
Console.WriteLine(z);

int? d = 100;
if (d.HasValue)
    Console.WriteLine($"d = {d.Value}");
else
    Console.WriteLine("d não possui um valor (null");

Console.ReadKey();
