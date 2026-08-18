namespace robotica_oo
{
    public class Gato : Animal, IQuatroPernas, IRespirar
    {
        public Gato(string nome, int idade) : base(nome, idade)
        {
        }

        public override void EmitirSom()
        {
            Console.WriteLine("Miau!");
        }

        public void Correr()
        {
            Console.WriteLine("O gato está correndo.");
        }

        public void Respirar()
        {
            Console.WriteLine("O gato está respirando.");
        }
    }
}