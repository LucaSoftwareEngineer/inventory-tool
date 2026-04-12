using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_tool.Models
{
    [Table("materiale")]
    public class Materiale
    {
        [Key]
        [Column("mat_id")]
        public int Id { get; set; }

        [Column("mat_descrizione")]
        public string Descrizione { get; set; }

        [Column("mat_quantita")]
        public int Quantita { get; set; }

        [Column("mat_id_amministratore")]
        public int IdAmministratore { get; set; }

        [ForeignKey("IdAmministratore")]
        public Amministratore Amministratore { get; set; }
    }
}
