namespace robotica_oo
{
    internal class Program{
        static void Main(string[] args)
        {
            Gato gato1 = new Gato("Gato", 3);
            gato1.EmitirSom();
            gato1.Respirar();
            gato1.Correr();

            Robo robo1 = new Robo();
            robo1.Correr();
        }
    }
}
