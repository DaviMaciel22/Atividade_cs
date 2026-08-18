namespace uvv_fit
{
    public class PesoIdealPrincipal
    {
        public void CalcularPesoPrincipal(double altura)
        {
            Console.WriteLine("Qual é seu sexo? (M/F)");
            string sexo = Console.ReadLine();

            if (sexo == "M" || sexo == "m")
            {
                PesoIdealHomem pesoHomem = new PesoIdealHomem();
                pesoHomem.getPesoIdeal(altura);
            }
            else if (sexo == "F" || sexo == "f")
            {
                PesoIdealMulher pesoMulher = new PesoIdealMulher();
                pesoMulher.getPesoIdeal(altura);
            }
            else
            {
                Console.WriteLine("Sexo inválido. Por favor, insira 'M' para masculino ou 'F' para feminino.");
            }
        }
    }
}