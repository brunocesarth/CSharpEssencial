Console.WriteLine("Saída de dados : Usando sequencia de escapes\n");

string local = "c:\\dados\\poesias.txt";
string frase = "Ele falou : \"Não fui eu\"";

string pizza = "\nPizza \nde \nMussarela";
string bolo = "\nBolo \tde \tChocolate";

Console.WriteLine(pizza);
Console.WriteLine(bolo);

Console.ReadLine();


/*
 Sequência Escape = Representação
\a = Sinal sonoro(alerta)
\b = Backspace
\f = Alimentação de formulário
\n = Nova Linha
\r = Carriage Return
\t = Tabulação horizontal
\v = Tabulação vertical
\' = Aspas Simples
\" = Aspas Duplas
\\ = Barra invertida
\? = Interrogação
\u ooo = Caractere ASCII na notação unicode
\x hh = Caractere ASCII na notação hexadecimal
 */