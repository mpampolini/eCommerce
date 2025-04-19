using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Models
{
    /*
         * Schema :
         * [Table] = Definir o nome da tabela
         * [Column] = Definir o nome da coluna
         * [NotMapped] = Não mapear a propriedade para a tabela
         * [ForeignKey] = Definir a chave estrangeira
         * [InverseProperty] = Defini a referência para cada FK vinda da mesma tabela
         * [DataBaseGenerated] = Definir se uma propriedade vai ou não ser gerenciada pelo banco de dados - Definir o tipo de geração da chave primária
         * 
         * DataAnnotations:
         * [Key] = Definir a chave primária PK
         * 
         * EF Core:
         * [Index] = Definir/Criar o índice no banco de dados (x - Unique)
    */

    /*
     * DataAnnotation, FluentAPI:
     * Code-First: Code -> DataBase - Criação do banco de dados a partir do código
     * DataBase-First: DataBase -> Code - Criação do código a partir do banco de dados
    */

    [Table("TB_USUARIOS")]
    public class Usuario
    {
        [Key]
        [Column("ID_USUARIO")]
        public int Id { get; set; }
        public string Nome { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Sexo { get; set; }

        [Column("REGISTRO_GERAL")]
        public string? RG { get; set; }
        public string CPF { get; set; } = null!;
        public string? NomeMae { get; set; }
        public string? NomePai { get; set; } = null!;
        public string? SituacaoCadastro { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //AutoIncremento
        public int Matricula { get; set; }
        /*
         * Software/Aplicativo - Não persistido
        *RegistroAtivo = (SituacaoCadastro == "Ativo") ? true : false;
        */
        [NotMapped]
        public bool RegistroAtivo { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTimeOffset DataCadastro { get; set; } //GETDATE()

        /*
         * Mapeando a chave estrangeira pela entidade forte
         * [ForeignKey("UsuarioId")]
        */
        public Contato? Contato { get; set; }
        public ICollection<EnderecoEntrega>? EnderecosEntrega { get; set; }
        public ICollection<Departamento>? Departamentos { get; set; }
    }
}
