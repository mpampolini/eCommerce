using Microsoft.EntityFrameworkCore;

namespace eCommerce.API.DataBase
{
    public class eCommerceContext : DbContext
    {
        public eCommerceContext(DbContextOptions<eCommerceContext> options) : base(options)
        {

        }

        public DbSet<Usuario> Usuarios { get; set; }
        DbSet<Contato> Contatos { get; set; }
        DbSet<EnderecoEntrega> EnderecosEntrega { get; set; }
        DbSet<Departamento> Departamentos { get; set; }
        
        #region Conexão sem distinção de ambientes de execução
        /*
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=eCommerce;Integrated Security=True;");
        }
        */
        #endregion
    }
}