namespace loja_de_roupas
{
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Estoque { get; set; }

        public Produto(string nome, double preco, int estoque)
        {
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }

        public void ExibirProduto()
        {
            Console.WriteLine($"Dados do produto {this.Nome}:\n"
            +$"Preço: {this.Preco}R$\n"
            +$"Quantidade em Estoque: {this.Estoque}");
        }

        public void AtualizarProduto(string nome, double preco, int estoque)
        {
            this.Nome = nome;
            this.Preco = preco;
            this.Estoque = estoque;
            Console.WriteLine($"Produto {this.Nome} atualizado com sucesso.");
            
        }
        public void CalcularValorTotalEstoque()
        {
            double valorTotal = this.Preco * this.Estoque;
            Console.WriteLine($"Valor total em estoque para o produto {this.Nome}: {valorTotal}R$");
           
        }
    }
}