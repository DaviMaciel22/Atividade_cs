namespace uvv_academico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio");

            ProfessorDE pde1 = new ProfessorDE("Vinicius", 123456789, 40, 8000);
            ProfessorHorista ph1 = new ProfessorHorista("Davi", 987654321, 50, 2000, 5);

            pde1.calcularBeneficio();
            ph1.calcularBeneficio();
        }
    }
}
