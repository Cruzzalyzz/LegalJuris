using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalJuris
{
    [Table("cad_cliente", Schema = "public")]
    public class Cliente
    {   
        [Column("id_cliente")]
        [Key]        
        public int ClienteId { get; set; }

        [Column("nome_cliente")]
        public string ClienteNome { get; set; }
    }
}