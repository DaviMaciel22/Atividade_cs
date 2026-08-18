namespace Verao_capixaba_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0, soma = 0;
            Console.WriteLine("Média de temperatura no verão");
            Console.WriteLine("As temperaturas cadastradas devem ser maiores que 28°!");

            while(i < 15){
                Console.WriteLine($"Digite a temperatura do {i + 1}º dia: ");
                string stg_graus = Console.ReadLine();
                int graus = int.Parse(stg_graus);
                if(graus <= 28){
                    Console.WriteLine("A temperatura deve ser maior que 28°, tente novamente!");
                    continue;
                }
                i++;
                soma = soma + graus;
            }
            double media_verao = soma / 15;

            Console.WriteLine($"A temperatura média do verão é: {media_verao}");
        }
    }
}
