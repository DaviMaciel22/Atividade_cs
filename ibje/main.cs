namespace IBGE
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = 1, i = 0;
            int faixaA = 0;
            int faixaB = 0;
            int faixaC = 0;
            int faixaD = 0;
            int faixaE = 0;

            double pA = 0, pB = 0, pC = 0, pD = 0, pE = 0;


            Console.WriteLine("=========================================================");
            Console.WriteLine("  Programa para calcular porcentagem de faixas etárias");
            Console.WriteLine("=========================================================");

            while (true){
                Console.WriteLine("Qual a sua idade?");
                string entrada_idade = Console.ReadLine();
                idade = int.Parse(entrada_idade);

                if (idade <= 0) 
                {
                    break;
                }

                if (idade >= 1 && idade <= 15){
                    faixaA++;
                }
                else if (idade >= 16 && idade <= 30){
                    faixaB++;
                }
                else if (idade >= 31 && idade <= 45){
                    faixaC++;
                }
                else if (idade >= 46 && idade <= 60){
                    faixaD++;
                }
                else if (idade >= 61){
                    faixaE++;
                }
                i++;
            };


            pA = ((double)faixaA / i) * 100;
            pB = ((double)faixaB / i) * 100;
            pC = ((double)faixaC / i) * 100;
            pD = ((double)faixaD / i) * 100;
            pE = ((double)faixaE / i) * 100;

            Console.WriteLine($"Porcentagens: \n A = {pA}%; \n B = {pB}%; \n C = {pC}%; \n D = {pD}%; \n E = {pE}%");


        }
    }
}