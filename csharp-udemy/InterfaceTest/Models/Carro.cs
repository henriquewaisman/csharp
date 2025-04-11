namespace InterfaceTest.Models
{
    public class Carro : IVeiculos
    {

        public Carro()
        {

        }
        
        void IVeiculos.Ligar()
        {
           Console.WriteLine("Carro ligado");     
        }
        void IVeiculos.Desligar()
        {
            Console.WriteLine("Carro desligado");
        }
    }
}