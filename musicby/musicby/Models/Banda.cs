using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace musicby.Models
{
    public class Banda
    {
        [Key]
        public int BandaId { get; set; }
        public string BandaName { get; set; }

        public string BandaGenero { get; set; }
    }
}
