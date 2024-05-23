namespace _02_SerializacaoBinaria
{
    [Serializable]
    public class Aluno
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        [NonSerialized]
        public int Idade;

        public Aluno(int id, string name, string email, int idade)
        {
            ID = id;
            Name = name;
            Email = email;
            Idade = idade;
        }
    }
}
