using System.Data.Entity;

namespace AulaCodeFirst.Modelos.DAL
{
    public class Contexto : DbContext
    {

        public Contexto() : base("nomeStringConexao")
        {
        }


        public DbSet <Categoria> Categorias { get; set; }
        public DbSet <Produto> Produtos { get; set; }
    }
}
