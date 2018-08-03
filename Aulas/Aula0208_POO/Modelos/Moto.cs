using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos
{
    class Moto : Veiculos, IMotorizado
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerando...:MOTO ");
            Velocidade += 8;
        }

        public void Frenar()
        {
            Console.WriteLine("Freiando.:MOTO");
            Velocidade -= 4;
        }
    }
}
