namespace google_tradutor
{
    public class Palavra
    {
        public string Nome { get; set; }
        public List<Significado> Significados { get; }

        public Palavra (string nome)
        {
            this.Nome = nome;
            this.Significados = new List<Significado>();
        }

        public void AdicionarSignificado(Significado texto)
        {
            Significados.Add(texto);
            Console.WriteLine($"Significado adicionado à palavra {this.Nome}.");
        }
        
        public List<Significado> RecuperarSignificado()
        {
            return this.Significados;
        }
        public void RemoverSignificado(Significado texto)
        {
            Significados.Remove(texto);
            Console.WriteLine($"Significado da palavra{this.Nome} removido com sucesso.");
        }

        public Boolean PesquisarSignificado(Significado texto)
        {
            if (Significados.Contains(texto)){
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}