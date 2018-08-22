using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCodeFirst.Modelos
{
    class Categoria
    {

        [Key]
        public int CategoriaID { get; set; }
        public String Nome { get; set; }
        public String Descricao { get; set; }


    }
}
