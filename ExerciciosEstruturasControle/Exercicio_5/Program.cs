//5 - Escreva um programa para solicitar ao usuário que escolha a resposta correta de uma lista de opções de resposta de uma pergunta. O usuário pode optar por continuar respondendo a pergunta ou parar de responder. Não utilize a instrução break.

string resposta = "";

while (resposta != "x" && resposta != "X")
{
    Console.WriteLine($"Qua a instrução para sair de um loop?\n" +
        $"a.quit\n" +
        $"b.continue\n" +
        $"c.break\n" +
        $"d.exit\n" +
        $"Qual a opção correta?(Tecle x para sair)");

    resposta = Console.ReadLine();

    if (resposta == "c" || resposta == "C")
        Console.WriteLine("Resposta Correta");
    else if ((resposta == "B" || resposta == "b") || (resposta == "A" || resposta == "a") || (resposta == "d" || resposta == "D"))
        Console.WriteLine("Resposta incorreta");
    else if (resposta != "x" && resposta != "X")
        Console.WriteLine("Opção não existe");
}
