using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AulaCodeFirst.Modelos
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }

        [Required]
        [StringLength(49)]
        public string Nome { get; set; }
        public string Descricao { get; set; }


        // Relacionamento Categoria <-------->

        public virtual ICollection<Produto> Produtos { get; set; }
                                           



    }
}
