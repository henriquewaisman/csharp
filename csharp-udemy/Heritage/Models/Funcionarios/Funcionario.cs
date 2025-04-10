namespace Heritage.Models.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }        
        public double SalarioBase { get; set; }

        public Funcionario()
        {

        }   
        public Funcionario(string nome, double salarioBase)
        {
            Nome = nome;
            SalarioBase = salarioBase;
        }   

        public virtual double CalcularSalario()
        {
            return SalarioBase;
        }



    }
}