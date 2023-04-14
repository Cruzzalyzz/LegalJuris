using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalJuris
{
    [Table("jur_processo", Schema = "public")]
    public class Processo
    {
        [Column("id_processo")]
        [Key] 
        public int ProcessoId { get; set; }

        [Column("numero_processo")]
        public string NumeroProcesso { get; set; }

        [Column("id_responsavel")]
        public int? ResonsavelId { get; set; }

        [Column("id_caso")]
        public int? CasoId { get; set; }

        [Column("id_comarca")]
        public int? ComarcaId { get; set; }
    }
}
