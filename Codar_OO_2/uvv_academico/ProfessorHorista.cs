namespace uvv_academico
{
    public class ProfessorHorista : Professor
    {
        public double ValorHora { get; set; }

        public ProfessorHorista(string nome, int matricula, int cargaHoraria, double beneficio, double ValorHora) : base(nome, matricula, cargaHoraria, beneficio)
        {
            this.ValorHora = ValorHora;
        }

        public override void calcularBeneficio()
        {
            beneficio = beneficio + (this.ValorHora * cargaHoraria);
            Console.WriteLine($"O valor do benefício é {beneficio}");
        }
    }
}