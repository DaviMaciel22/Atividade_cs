namespace Verao_capixaba
{
    class Program
    {
        static void Main(string[] args)
        {
            double C = 0, F = 0, K = 0;

            Console.WriteLine("Conversão de Temperaturas\n\n");
            Console.WriteLine("Digite 'C' para Celcius, 'F' para Fahrenheit e 'K' para Kelvin");

            Console.WriteLine("Qual temperatura você quer converter? ");
            string temp_convert = Console.ReadLine();

            Console.WriteLine("Para qual temperatura você quer converter? ");
            string temp_final = Console.ReadLine();

            Console.WriteLine("Digite a quantidade de graus: ");
            string stg_graus = Console.ReadLine();
            int graus = int.Parse(stg_graus);

            if(temp_convert == "C" && temp_final == "F"){
                C = graus;
                F = C * 1.8 + 32;
                Console.WriteLine($"{C}° Celcius em Fahrenheit é {F}°");
            }

            else if(temp_convert == "F" && temp_final == "C"){
                F = graus;
                C = (F - 32) / 1.8;
                Console.WriteLine($"{F}° Fahrenheit em Celcius é {C}°");
            }

            else if(temp_convert == "C" && temp_final == "K"){
                C = graus;
                K = C + 273.15;
                Console.WriteLine($"{C}° Celcius em Kelvin é {K}°");
            }

            else if(temp_convert == "K" && temp_final == "C"){
                K = graus;
                C = K - 273.15;
                Console.WriteLine($"{K}° Kelvin em Celcius é {C}°");
            }

        }
    }
}
