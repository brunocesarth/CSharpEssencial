using _02_SerializacaoBinaria;
using System.Runtime.Serialization.Formatters.Binary;

internal class Program
{
    static void Main(string[] args)
    {
        Aluno aluno1 = new Aluno(101, "Maria", "maria@yahoo.com.br", 17);
        var caminhoArquivo = @"d:\dados\Serializados\AlunoSerializado.bin";

        using (FileStream stream = new FileStream(caminhoArquivo,
                                    FileMode.OpenOrCreate,
                                    FileAccess.ReadWrite))
        {
#pragma warning disable SYSLIB0011
            var bf = new BinaryFormatter();
            bf.Serialize(stream, aluno1);

            Console.WriteLine("Tecle algo pare realizar a Desserialização");
            Console.ReadKey();

            stream.Seek(0, SeekOrigin.Begin);
            var alunoDesserializado = (Aluno)bf.Deserialize(stream);
            Console.WriteLine(alunoDesserializado.Name);
        }
#pragma warning disable SYSLIB0011
        Console.WriteLine("Serialização binária concluída");
        Console.ReadKey();
    }
}