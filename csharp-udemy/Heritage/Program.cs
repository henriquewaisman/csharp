using Heritage.Models.Funcionarios;
using Heritage.Models.Pessoa;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario("Marcos", 15000);
            Gerente gerente = new Gerente("Luis", 10000, 5000);

            Console.WriteLine(funcionario.CalcularSalario());
            Console.WriteLine(gerente.CalcularSalario());

            Pessoa pessoa = new Pessoa("Henrique", 21);
            Aluno aluno = new Aluno("José", 21, 7.5);

            pessoa.Apresentar();
            aluno.Apresentar();
        }
    }
}