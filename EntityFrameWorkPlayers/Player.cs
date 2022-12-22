using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWorkPlayers
{
    [Table("player")]
    public class Player
    {
        [Key]
        public int PlayerId { get; set; }
        [Required]
        public string NomePlayer { get; set; }
        [Required]
        public string CognomePlayer { get; set; }
        public int Punteggio { get; set; }
        public int NumeroPartiteGiocate { get; set; }
        public int NumeroPartiteVinte { get; set; }

    }
}
