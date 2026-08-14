namespace MeuProjeto
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public float SalarioAtual { get; set; }
        public string CargoAtual { get; set; }
        public int Matricula { get; set; }

        public void Cadastrar()
        {
            Console.WriteLine("Digite o nome do funcionário:");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite a matrícula do funcionário:");
            Matricula = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o cargo atual do funcionário:");
            CargoAtual = Console.ReadLine();

            Console.WriteLine("Digite o salário atual do funcionário:");
            SalarioAtual = float.Parse(Console.ReadLine());
        }

        public void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}, Matrícula: {Matricula}, Cargo: {CargoAtual}, Salário: {SalarioAtual}");
        }
    }
}