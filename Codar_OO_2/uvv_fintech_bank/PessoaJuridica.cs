namespace uvv_fintech_bank
{
    public class PessoaJuridica : Pessoa
    {
        public long CNPJ { get; set; }
        public string RazaoSocial { get; set; }
        public string NomeRepresentante { get; set; }

        public PessoaJuridica(string nome, string endereco, string telefone, long cnpj, string razaoSocial, string nomeRepresentante) : base(nome, endereco, telefone)
        {
            CNPJ = cnpj;
            RazaoSocial = razaoSocial;
            NomeRepresentante = nomeRepresentante;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Telefone: {Telefone}");
            Console.WriteLine($"CNPJ: {CNPJ}");
            Console.WriteLine($"Razão Social: {RazaoSocial}");
            Console.WriteLine($"Nome do Representante: {NomeRepresentante}");
        }

        
    }
}