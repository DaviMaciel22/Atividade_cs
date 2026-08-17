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

        public void ContarMoedasTotais()
        {
            int quantidade_moedas = Moedas.Count();
            Console.WriteLine($"Quantidade de moedas no cofrinho: {quantidade_moedas}");
        }

        public void ContarMoedasPorTipo()
        {
            var moedas_por_tipo = Moedas.GroupBy(m => m.Nome);
            
            foreach (var grupo in moedas_por_tipo)
            {
                Console.WriteLine($"Tipo: {grupo.Key} - Quantidade: {grupo.Count()}");
            }
        }

        public void MoedaDeMaiorValor()
        {
            Moeda maior = Moedas[0];

            foreach (Moeda m in Moedas)
            {
                if (m.Valor > maior.Valor)
                {
                    maior = m;
                }
            }
            Console.WriteLine($"A moeda de maior valor é {maior.Nome}");
        }


    }
}