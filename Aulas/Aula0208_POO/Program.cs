using Aula0208_POO.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro car = new Carro();
            car.Modelo = "Uno";
            car.Acelerar();
            Console.WriteLine("Velocidade: " + car.Velocidade);
            Console.ReadKey();

        }
    }
}
