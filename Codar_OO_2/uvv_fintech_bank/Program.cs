namespace uvv_fintech_bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PessoaFisica pf1 = new PessoaFisica("João Silva", "Rua A, 123", "1234-5678", "123.456.789-00", 1);
            PessoaJuridica pj1 = new PessoaJuridica("Empresa XYZ", "Av. B, 456", "9876-5432", 12345678000199, "Empresa XYZ Ltda.", "Maria Souza");

            pf1.ExibirInformacoes();
            pj1.ExibirInformacoes();
        }
    }
}
