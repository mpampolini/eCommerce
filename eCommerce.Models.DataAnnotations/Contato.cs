using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.Models
{
    public class Contato
    {
        public int Id { get; set; }
        
        public string? Telefone { get; set; }
        public string? Celular { get; set; }

        /*
         * Coluna - MER
         * Convenção: {Model} {PK} = UsuarioId
        */
        // UsuarioId(MER - Coluna) - FK(Propriedade do POO)
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        /*
         * POO - Relacionamento (Navegar)
        */

        /*
         * POO - Relacionamento (Navegar)
         * FK(Propriedade do POO) - UsuarioId(MER - Coluna)
         * [foreignKey("UsuarioId")]
        */
        public Usuario? Usuario { get; set; }        
    }
}
