﻿using System;
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
            Console.WriteLine("Acelerando... ");
            Velocidade += 5;
        }

        public void Frenar()
        {
            Console.WriteLine("Freiando.");
            Velocidade -= 3;
        }
    }
}