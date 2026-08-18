namespace uvv_fit
{
    public class PesoIdealHomem : PesoIdealPessoa
    {
        public override void getPesoIdeal(double altura)
        {
            double peso = (72.7 * altura) - 58;
            Console.WriteLine($"O peso ideal do homem é {peso:F2}");
        }
    }
}