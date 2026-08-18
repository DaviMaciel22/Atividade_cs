namespace uvv_academico
{
    public class ProfessorDE : Professor
    {
        public ProfessorDE(string nome, int matricula, int cargaHoraria, double beneficio) : base(nome, matricula, cargaHoraria, beneficio)
        {
        }
        
        public override void calcularBeneficio()
        {
            beneficio = beneficio * 2;
            Console.WriteLine($"O valor do benefício é {beneficio}");
        }
    }
}