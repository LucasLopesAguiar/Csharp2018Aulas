using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula0208_POO.Modelos
{
    class Veiculos
    {
        public string Placa { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }

        private string marca;
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }

    }
}
