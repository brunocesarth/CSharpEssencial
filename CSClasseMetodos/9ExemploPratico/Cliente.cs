namespace _9ExemploPratico
{
    public class Cliente
    {
        public string? Nome;
        public int Idade;
        public decimal Renda;

        public Cliente(string? nome, int idade, decimal renda)
        {
            Nome = nome;
            Idade = idade;
            Renda = renda;
        }

        public Cliente() { }

    }
}
