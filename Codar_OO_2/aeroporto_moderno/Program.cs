namespace aeroporto_moderno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Aeroporto aeroporto1 = new Aeroporto("Aeroporto pequeno", "São Paulo", 2);
            Aviao aviao1 = new Aviao("Boeing 747", 400);
            Grifo grifo1 = new Grifo("Grifo Mágico", 2);
            Helicoptero helicoptero1 = new Helicoptero("Robinson R44", 4);

            aviao1.voar("Rio de Janeiro", "São Paulo", 350);
            grifo1.voar("Belo Horizonte", "São Paulo", 1);
            helicoptero1.voar("Curitiba", "São Paulo", 3);
            aeroporto1.Aceitar(aviao1);
            aeroporto1.Aceitar(grifo1);
            aeroporto1.Aceitar(helicoptero1);
            aeroporto1.Liberar(aviao1);
            aeroporto1.Aceitar(helicoptero1);

        }
    }
}
