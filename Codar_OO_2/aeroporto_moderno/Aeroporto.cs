namespace aeroporto_moderno
{
    public class Aeroporto
    {
        public string nome { get; set; }
        public string cidade { get; set; }
        public int capacidade { get; set; }

        public Aeroporto(string nome, string cidade, int capacidade)
        {
            this.nome = nome;
            this.cidade = cidade;
            this.capacidade = capacidade;
        }

        public void Aceitar(ITransporteVoador veiculo)
        {
            if (this.capacidade > 0)
            {
                capacidade --;
                if (veiculo is Aviao aviao)
                {
                    Console.WriteLine($"O aeroporto {nome} está aceitando o avião modelo {aviao.modelo} com capacidade de {aviao.capacidade} passageiros.");
                }
                else if (veiculo is Grifo grifo)
                {
                    Console.WriteLine($"O aeroporto {nome} está aceitando o grifo {grifo.nome} com capacidade de {grifo.capacidade} passageiros.");
                }
                else if (veiculo is Helicoptero helicoptero)
                {
                    Console.WriteLine($"O aeroporto {nome} está aceitando o helicóptero modelo {helicoptero.modelo} com capacidade de {helicoptero.capacidade} passageiros.");
                }
            }
            else
            {
                Console.WriteLine($"O aeroporto {nome} não tem capacidade para aceitar o veículo.");
            }
        }
    }
}