namespace Heritage.Models.Veiculos
{
    public class Moto : Veiculo
    {
        public int Cilindradas { get; set; }

        public Moto()
        {

        }
        public Moto(string marca, string modelo, int ano, int cilindradas) : base(marca, modelo, ano)
        {
            Cilindradas = cilindradas;
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine($" {Cilindradas} cc");
        }
    }
}