namespace uvv_fit
{
    public class PesoIdealMulher : PesoIdealPessoa
    {
        public override void getPesoIdeal(double altura)
        {
            double Peso = (62.1 * altura) - 44.7;
            Console.WriteLine($"O peso ideal da mulher é {Peso:F2}");
        }
    }
}