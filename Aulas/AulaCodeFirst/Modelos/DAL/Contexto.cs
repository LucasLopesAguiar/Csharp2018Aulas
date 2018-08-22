using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
