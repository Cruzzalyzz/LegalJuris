using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalJuris
{
    [Table("cad_caso", Schema = "public")]
    public class Caso
    {
        [Column("id_caso")]
        [Key]        
        public int CasoId { get; set; }

        [Column("nome_caso")]
        public string CasoNome { get; set; }

        [Column("id_cliente")]
        public Int32? ClienteId { get; set; }

    }
}
