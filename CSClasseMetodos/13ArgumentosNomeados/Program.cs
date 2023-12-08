Console.WriteLine("### Argumentos nomeados ###\n");

Email email = new();

email.Enviar("bruno.cm.thobias@hotmail.com", "Urgente", "Reunião para marcar reunião");

email.Enviar(destino: "bruno.cm.thobias@hotmail.com", assunto: "Reunião para marcar reunião", titulo: "Urgente");
email.Enviar(titulo: "Urgente", assunto: "Reunião para marcar reunião", destino: "bruno.cm.thobias@hotmail.com");
email.Enviar(assunto: "Reunião para marcar reunião", titulo: "Urgente", destino: "bruno.cm.thobias@hotmail.com");

Console.ReadKey();


public class Email
{
    public void Enviar(string destino, string titulo, string assunto)
    {
        Console.WriteLine($"\nPara {destino} - {titulo} \n Assunto: {assunto}");
    }
}