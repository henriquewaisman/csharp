namespace Heritage.Models.Pessoa
{
    public class Aluno : Pessoa
    {
        public double NotaFinal { get; set; }

        public Aluno()
        {

        }

        public Aluno(string nome, int idade, double notaFinal) : base(nome, idade)
        {
            NotaFinal = notaFinal;
        }

        public override void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Nota Final: {NotaFinal}");
        }
    }
}