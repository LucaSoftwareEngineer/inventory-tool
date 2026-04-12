using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_tool.Models
{
    [Table("amministratori")]
    public class Amministratore
    {
        [Key]
        [Column("amm_id")]
        public int Id { get; set; }

        [Column("amm_nome")]
        public string Nome { get; set; }

        [Column("amm_cognome")]
        public string Cognome { get; set; }

        [Column("amm_username")]
        public string Username { get; set; }

        [Column("amm_password")]
        public string Password { get; set; }

        public virtual ICollection<Materiale> Materiali { get; set; } = new List<Materiale>();

    }
}
