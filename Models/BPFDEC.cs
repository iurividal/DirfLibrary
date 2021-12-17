using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirfLibrary.Models
{
    public class BPFDEC
    {

        public string Idenficador => "BPFDEC";

        [MaxLength(11)]
        public string CPF { get; set; }

        [MaxLength(60)]
        public string Nome { get; set; }

        [MaxLength(4)]
        public string DataLaudo { get; set; }

        /// <summary>
        /// Indicador de identificação do alimentando
        /// </summary>
        [MaxLength(1)]
        public string Indenficador05 { get; set; }

        /// <summary>
        /// Indicador de identificação da previdência  complementar
        /// </summary>
        [MaxLength(1)]
        public string Indenficador06 { get; set; }



    }
}
