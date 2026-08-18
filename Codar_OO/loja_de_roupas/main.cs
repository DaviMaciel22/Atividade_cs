namespace loja_de_roupas
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p1 = new Produto("Camisa Polo", 80.00, 15);
            Produto p2 = new Produto("Calça Jeans", 140.99, 20);
            Produto p3 = new Produto("Tênis Esportivo", 250, 10);

            p1.ExibirProduto();
            p2.AtualizarProduto("Calça Jeans Cargo", 160.00, 18);
            p3.CalcularValorTotalEstoque();
        }
    }
}
