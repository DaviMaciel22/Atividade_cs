namespace Cofrinho
{
    class Program
    {
        static void Main(string[] args)
        {
            Moeda m1 = new Moeda(1.00, "Real");
            Moeda m2 = new Moeda(0.50, "Cinquenta Centavos");
            Cofrinho c1 = new Cofrinho();
            c1.AdicionarMoeda(m1);
            c1.AdicionarMoeda(m2);
            c1.CalcularTotal();
            Console.WriteLine("===================");
            Moeda m3 = new Moeda(0.25, "Vinte e Cinco Centavos");

            c1.AdicionarMoeda(m3);
            c1.ContarMoedasTotais();
            c1.ContarMoedasPorTipo();
            c1.MoedaDeMaiorValor();
        }
    }
}
