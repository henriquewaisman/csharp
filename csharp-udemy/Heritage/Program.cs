using Heritage.Models.Funcionarios;
using Heritage.Models.Pessoa;
using Heritage.Models.Veiculos;

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
        
            Carro carro = new Carro("Honda", "Civic", 2020, 4);
            Moto moto = new Moto("Honda", "Hornet", 2018, 1000);

            carro.ExibirInfo();
            moto.ExibirInfo();
        }
    }
}