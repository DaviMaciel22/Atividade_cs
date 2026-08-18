namespace Cofrinho
{
    public class Moeda
    {
        public double Valor { get; set; }
        public string Nome { get; }

        public Moeda(double v, string n)
        {
            this.Valor = v;
            this.Nome = n;
        }


    }
}