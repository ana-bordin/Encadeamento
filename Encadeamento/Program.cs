namespace Encadeamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa;
            Endereco endereco = new Endereco("14801300", "Araraquara", "SP", "Sao Bento", "Rua", "Centro", 2291, "");
            pessoa = new Pessoa("Fabio", 51, endereco);

            Console.WriteLine(pessoa.ToString());
        }
    }
}
