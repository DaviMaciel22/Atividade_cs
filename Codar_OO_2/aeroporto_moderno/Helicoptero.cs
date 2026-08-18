namespace aeroporto_moderno
{
    public class Helicoptero : ITransporteVoador
    {
        public string modelo { get; set; }
        public int capacidade { get; set; }

        public Helicoptero(string modelo, int capacidade)
        {
            this.modelo = modelo;
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
                Console.WriteLine($"O helicóptero modelo {modelo} está voando de {origem} para {destino} com {passageiros} passageiros.");
            }
        }
    }
}