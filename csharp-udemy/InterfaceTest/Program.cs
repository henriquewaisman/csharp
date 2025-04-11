using System;
using InterfaceTest.Models;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            IVeiculos carro = new Carro();

            carro.Ligar();
        }
    }
}