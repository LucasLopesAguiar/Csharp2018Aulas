using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCodeFirst.Modelos
{
 public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

    }
}
