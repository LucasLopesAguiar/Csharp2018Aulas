using System.Data.Entity;

namespace AulaCodeFirst.Modelos.DAL
{
    public class Contexto : DbContext
    {

        public Contexto() : base("nomeStringConexao")
            {
        }
    }
}
