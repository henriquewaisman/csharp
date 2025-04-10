namespace Heritage.Models.Veiculos
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        
        public Veiculo()
        {

        }
        public Veiculo(string marca, string modelo, int ano)
        {
            Marca = marca;
            Modelo = modelo;
            Ano = ano;
        }

        public virtual void ExibirInfo()
        {
            Console.Write($"{Marca} {Modelo} {Ano}");
        }
    }
}