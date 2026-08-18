namespace uvv_academico
{
    public abstract class Professor(string nome, int matricula, int cargaHoraria, double beneficio)
    {
        public String Nome { get; set; } = nome;
        public int matricula { get; set; } = matricula;
        public int cargaHoraria { get; set; } = cargaHoraria;
        public double beneficio { get; set; } = beneficio;

        public abstract void calcularBeneficio();
    }
}