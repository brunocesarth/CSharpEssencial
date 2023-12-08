﻿Console.WriteLine("### Parâmetros opcionais ###\n");


Console.WriteLine("Informe o destino");
var destino = Console.ReadLine();

Console.WriteLine("Informe o titulo");
var titulo = Console.ReadLine();

Console.WriteLine("Informe o assunto");
var assunto = Console.ReadLine();

Email email = new();

email.Enviar();
email.Enviar(destino);
email.Enviar(destino, titulo);
email.Enviar(destino, titulo, assunto);


Console.ReadKey();

public class Email
{
    public void Enviar(string destino = "Destino Padrão", string titulo = "Titulo Padrão", string assunto = "Assunto Padrão")
    {
        Console.WriteLine($"`\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}