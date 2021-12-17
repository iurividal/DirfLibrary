using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirfLibrary.Models
{
    public class DIRF
    {
        [MaxLength(4)]
        public string Identificador => "DIRF";

        [MaxLength(4)]
        public int AnoReferencia { get; set; }

        [MaxLength(4)]
        public int AnoCalendario { get; set; }

        /// <summary>
        /// S, N
        /// </summary>
        [MaxLength(1)]
        public string IndicadorRetificadora { get; set; }

        [MaxLength(12)]
        public string NumeroRecibo { get; set; }


        [MaxLength(7)]
        public string IdentificadorEstrutaLayout => "VR4QLM8";

    }
}
