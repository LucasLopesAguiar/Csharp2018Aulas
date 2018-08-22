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
        [Required]
        [StringLength(36)]
        public String Nome { get; set; }
        public String Descricao { get; set; }

        //Relacionamento Categoria > Produto

        public ICollection<Produto> _ProdutosT { get; set; }


    }
}
