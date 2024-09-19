ProcessaObjetos(1, "Maria", 3.45m, new Teste(), null);

Console.ReadKey();

void ProcessaObjetos(params object[] parametros)
{
    foreach(object obj in parametros)
    {
        Console.WriteLine(obj.GetType());
    }
}