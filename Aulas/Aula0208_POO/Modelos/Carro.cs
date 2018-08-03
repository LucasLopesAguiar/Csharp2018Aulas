using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos
{
    class Carro : Veiculos, IMotorizado
    {
        public void Acelerar()
        {
            Console.WriteLine("Pisando no pedal");
            Velocidade += 5;
        }

        public void Frenar()
        {
            
        }
    }
}
