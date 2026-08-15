namespace gestao_rh
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f01 = new Funcionario();

            f01.Cadastrar();
            f01.ConsultarFuncionario();
            f01.AtualizarSalario(10000);
            f01.ListarDependentes();
        }
    }
}
