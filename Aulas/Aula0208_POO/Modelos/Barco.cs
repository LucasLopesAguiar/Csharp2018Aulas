using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos
{
    class Barco : Veiculos, IMotorizado
    {
        public void Acelerar()
        {
            Console.WriteLine("Acelerando...:BARCO ");
            Velocidade += 3;
        }

        public void Frenar()
        {
            Console.WriteLine("Freiando.:BARCO");
            Velocidade -= 1;
        }
    }
}
