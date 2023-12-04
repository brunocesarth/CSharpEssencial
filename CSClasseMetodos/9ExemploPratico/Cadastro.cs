namespace _9ExemploPratico
{
    public class Cadastro
    {
        public Cliente Registrar()
        {
            Cliente cliente = new Cliente("Maria", 23, 3000);
            return cliente;
        }

        public Cliente Registrar(Cliente cliente)
        {
            cliente.Renda = 3500;
            return cliente;
        }

        public void ExibirDados(Cliente cliente)
        {
            Console.WriteLine($"{cliente.Nome} {cliente.Idade} {cliente.Renda.ToString("c")}");
        }

        public void ExibirDados(string texto, Cliente cliente)
        {
            Console.Write($"\n{texto}\t");
            Console.Write($"{cliente.Nome} - {cliente.Renda.ToString("c")}");
        }
    }
}
