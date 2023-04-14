using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalJuris
{
    [Table("cad_foro", Schema = "public")]
    public class Foro
    {
        [Column("id_foro")]
        [Key]        
        public int ForoId { get; set; }

        [Column("nome_foro")]
        public string ForoNome { get; set; }

        [Column("id_vara")]
        public int?  VaraId { get; set; }
    }
}
