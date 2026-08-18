namespace aeroporto_moderno
{
    public class Grifo : ITransporteVoador
    {
        public string nome { get; set; }
        public int capacidade { get; set; }

        public Grifo(string nome, int capacidade)
        {
            this.nome = nome;
            this.capacidade = capacidade;
        }

        public void voar(string origem, string destino, int passageiros)
        {
            if (passageiros > capacidade)
            {
                Console.WriteLine($"Não é possível transportar {passageiros} passageiros. A capacidade máxima é de {capacidade} passageiros.");
            }
            else
            {
                Console.WriteLine($"O grifo {nome} está voando de {origem} para {destino} com {passageiros} passageiros.");
            }
        }
    }
}