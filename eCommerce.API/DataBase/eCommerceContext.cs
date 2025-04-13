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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Departamento>().HasData(
                new Departamento { Id = 1, Nome = "Informática" },
                new Departamento { Id = 2, Nome = "Celular" },
                new Departamento { Id = 3, Nome = "Eletrodomésticos" },
                new Departamento { Id = 4, Nome = "Móveis" },
                new Departamento { Id = 5, Nome = "Brinquedos" },
                new Departamento { Id = 6, Nome = "Roupas" },
                new Departamento { Id = 7, Nome = "Calçados" },
                new Departamento { Id = 8, Nome = "Esportes" },
                new Departamento { Id = 9, Nome = "Beleza" },
                new Departamento { Id = 10, Nome = "Saúde" },
                new Departamento { Id = 11, Nome = "Livros" },
                new Departamento { Id = 12, Nome = "Games" },
                new Departamento { Id = 13, Nome = "Automotivo" },
                new Departamento { Id = 14, Nome = "Casa e Jardim" },
                new Departamento { Id = 15, Nome = "Pet Shop" },
                new Departamento { Id = 16, Nome = "Relógios" },
                new Departamento { Id = 17, Nome = "Instrumentos Musicais" },
                new Departamento { Id = 18, Nome = "Ferramentas" },
                new Departamento { Id = 19, Nome = "Artigos para Festas" },
                new Departamento { Id = 20, Nome = "Artigos de Papelaria" },
                new Departamento { Id = 21, Nome = "Produtos Naturais" },
                new Departamento { Id = 22, Nome = "Produtos Orgânicos" },
                new Departamento { Id = 23, Nome = "Produtos para Bebês" },
                new Departamento { Id = 24, Nome = "Produtos para Crianças" },
                new Departamento { Id = 25, Nome = "Produtos para Idosos" },
                new Departamento { Id = 26, Nome = "Produtos para Animais" },
                new Departamento { Id = 27, Nome = "Produtos para Casa" },
                new Departamento { Id = 28, Nome = "Produtos para Jardim" }
            );
        }

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