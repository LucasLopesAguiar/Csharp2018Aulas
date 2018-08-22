using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaCodeFirst.Modelos
{
    public class Produto
    {
        
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Preco { get; set; }
        public string Imposto { get; set; }
        
        //Relacionamento Produto <--> Categoria
        //Famosa, chave estrangeira
        public int CategoriaID { get; set; }
        public virtual Categoria _Categoria { get; set; }//Propriedade de navegação


    }
}
