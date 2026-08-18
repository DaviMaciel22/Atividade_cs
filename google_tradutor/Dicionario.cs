namespace google_tradutor
{
    public class Dicionario
    {
        public List<Palavra> Palavras{ get; }
        public Dicionario()
        {
            this.Palavras = new List<Palavra>();
        }

        public void AdicionarPalavra(Palavra p)
        {
            Palavras.Add(p);
            Console.WriteLine($"Palavra {p.Nome} adicionada ao dicionário.");
        }

        public void RecuperarPalavra(Palavra p)
        {
            foreach (Significado s in p.Significados)
            {
                Console.WriteLine(s);
            }
        }

        public void RemoverSignificado(Palavra p, Significado s)
        {
            p.Significados.Remove(s);
            Console.WriteLine($"Significado {s} removido da palavra {p}.");
        }

        public void PesquisarSignificado(Palavra p, Significado s)
        {
            if (p.Significados.Contains(s))
            {
                Console.WriteLine($"O significado está contido na lista dessa palavra!");
            }
            else
            {
                Console.WriteLine($"O significado não está contido na lista dessa palavra!");
            }
        }

    }
}