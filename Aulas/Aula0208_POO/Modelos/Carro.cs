using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos
{
    class Carro : Veiculos, IMotorizado
    {
        public int Velocidade { get; set; }

        public void Acelerar()
        {
            Console.WriteLine("Acelerando...:CARRO ");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("Freiando.:CARRO");
            Velocidade -= 3;
        }
    }
}
