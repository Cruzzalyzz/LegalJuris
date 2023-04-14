using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalJuris
{
    [Table("cad_comarca", Schema = "public")]
    public class Comarca
    {
        [Column("id_comarca")]
        [Key]        
        public int ComarcaId { get; set; }

        [Column("nome_comarca")]
        public string ComarcaNome { get; set; }

        [Column("id_foro")]
        public int? ForoId { get; set; }
    }
}
