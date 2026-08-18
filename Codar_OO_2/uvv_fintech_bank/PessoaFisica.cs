namespace uvv_fintech_bank
{
    public class PessoaFisica : Pessoa
    {
        public string CPF { get; set; }
        public int EstadoCivil { get; set; }

        public PessoaFisica(string nome, string endereco, string telefone, string cpf, int estadoCivil) : base(nome, endereco, telefone)
        {
            CPF = cpf;
            EstadoCivil = estadoCivil;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Estado Civil: {EstadoCivil}");
        }
    }
}