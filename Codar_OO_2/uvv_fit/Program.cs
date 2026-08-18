namespace uvv_fit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PesoIdealHomem pih = new PesoIdealHomem();
            PesoIdealMulher pim = new PesoIdealMulher();
            PesoIdealPrincipal pip = new PesoIdealPrincipal();

            pim.getPesoIdeal(1.60);
            pih.getPesoIdeal(1.80);
            pip.CalcularPesoPrincipal(1.80);
            

        }
    }
}
