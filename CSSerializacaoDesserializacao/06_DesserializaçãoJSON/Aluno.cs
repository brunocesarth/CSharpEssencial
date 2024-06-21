namespace _06_DesserializaçãoJSON
{
    internal class Aluno
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }

        public Aluno() { }

        public Aluno(int id, string name, string email, int idade)
        {
            Id = id;
            Name = name;
            Email = email;
            Idade = idade;
        }
    }
}
