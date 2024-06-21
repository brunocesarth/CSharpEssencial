using _07_Exercicio;
using System.Text.Json;
using System.Xml.Serialization;

var caminhoArquivo = @"d:\dados\Serializados\listaAlunos.json";

List<Aluno> alunos = new List<Aluno>();
Aluno aluno1 = new(101, "Maria", "maria@gmail.com", 19);
Aluno aluno2 = new(102, "Fernanda", "fernanda@hotmail.com", 20);
Aluno aluno3 = new(103, "Javier", "javier@yahoo.com", 21);

alunos.Add(aluno1);
alunos.Add(aluno2);
alunos.Add(aluno3);

string lista = JsonSerializer.Serialize(alunos);
Console.WriteLine(lista);

using (FileStream stream = new FileStream(caminhoArquivo,
    FileMode.OpenOrCreate, FileAccess.ReadWrite))
{
    JsonSerializer.Serialize(stream, alunos);
}

var caminhoArquivoXML = @"d:\dados\Serializados\listaAlunos.xml";

var listaSerializer = new XmlSerializer(typeof(List<Aluno>));

using (var writer = new StreamWriter(caminhoArquivoXML))
{
    listaSerializer.Serialize(writer, alunos);
}

Console.ReadKey();
