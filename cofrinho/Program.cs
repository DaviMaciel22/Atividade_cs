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
        }
    }
}
