namespace Gestao_de_recursos_mercado
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0, limp = 0, hig = 0, ali = 0;
            Console.WriteLine("Leitor de Itens do Mercado");
            Console.WriteLine("Códigos de produtos:\n"
            +"'L' = Limpeza\n"
            +"'A' = Alimentação\n"
            +"'H' = Higiene");

            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine($"Digite o preço do {i + 1}º item: ");
                double preco = double.Parse(Console.ReadLine());
                Console.WriteLine($"Digite o código do {i + 1}º item: ");
                string code = Console.ReadLine();

                soma = soma + preco;

                if (code == "L" || code == "l")
                {
                    limp = limp + preco;
                }

                else if (code == "H" || code == "h")
                {
                    hig = hig + preco;
                }

                else if (code == "A" || code == "a")
                {
                    ali = ali + preco;
                }
            }

            Console.WriteLine($"O valor total da compra foi de {soma}");
            Console.WriteLine($"O total em Produtos de Limpeza foi: {limp}\n"
            +$"O total em produtos de Higiene foi {hig}\n"
            +$"O total em alimentos foi {ali}");
        }
    }
}

