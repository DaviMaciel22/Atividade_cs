namespace gestao_rh
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public float SalarioAtual { get; set; }
        public string CargoAtual { get; set; }
        public int Matricula { get; set; }

        public void Cadastrar()
        {
            Console.WriteLine("Método que recebe matrícula, nome, cargo e salário do funcionário e cadastra o funcionário.");
        }

        public void ConsultarFuncionario()
        {
            Console.WriteLine("Método que recebe matrícula do funcionário e retorna os dados do funcionário.");
        }

        public void AtualizarSalario(float novoSalario)
        {
            SalarioAtual = novoSalario;
            Console.WriteLine($"Método que recebe matrícula do funcionário e o novo salário, atualizando o salário do funcionário para {novoSalario}.");
        }

        public void ListarDependentes()
        {
            Console.WriteLine("Método que recebe matrícula do funcionário e retorna a lista de dependentes do funcionário.");
        }
    }
}