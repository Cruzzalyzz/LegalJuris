using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalJuris
{
    [Table("cad_vara", Schema = "public")]
    public class Vara
    {
        [Column("id_vara")]
        [Key]        
        public int VaraId { get; set; }

        [Column("nome_vara")]
        public string VaraNome { get; set; }
        
    }
}
