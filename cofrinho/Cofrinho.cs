namespace Cofrinho
{
    public class Cofrinho
    {
        public List<Moeda> Moedas { get; }

        public Cofrinho()
        {
            this.Moedas = new List<Moeda>();
        }

        public void AdicionarMoeda(Moeda m)
        {
            Moedas.Add(m);
            Console.WriteLine($"Moeda {m.Nome} adicionada ao cofrinho.");
        }

        public void CalcularTotal()
        {
            double total = 0;
            foreach (Moeda m in Moedas)
            {
                total += m.Valor;
            }
            Console.WriteLine($"Total no cofrinho: {total}");
        }


    }
}