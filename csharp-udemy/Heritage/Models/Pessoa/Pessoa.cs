namespace Heritage.Models.Pessoa
{
    public class Pessoa
    {

        public string Nome { get; set; }        
        public int Idade { get; set; }        
        
        public Pessoa ()
        {

        }
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public virtual void Apresentar()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}");
        }

    }
}