using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalJuris
{
    [Table("cad_responsavel", Schema = "public")]
    public class Responsavel
    {
        [Column("id_responsavel")]
        [Key]        
        public int ResonsavelId { get; set; }

        [Column("nome_responsavel")]
        public string NomeResponsavel { get; set; }
    }
}
