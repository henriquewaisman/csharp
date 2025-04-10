namespace Heritage.Models.Veiculos
{
    public class Carro : Veiculo
    {
        public int NumeroPortas { get; set; }

        public Carro()
        {

        }
        public Carro(string marca, string modelo, int ano, int numeroPortas) : base(marca, modelo, ano)
        {
            NumeroPortas = numeroPortas;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($" {NumeroPortas} portas.");
        }
    }
}