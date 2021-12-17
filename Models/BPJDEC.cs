using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DirfLibrary.Models
{

    /// <summary>
    /// Regras de validação do registro:
    ///- Serão apresentados todos os CNPJ em ordem crescente;
    ///- Devem ser apresentados depois dos registros com identificador BPFDEC, caso exista o registro;
    /// </summary>
    public class BPJDEC
    {
        private string cNPJ;

        [MaxLength(6)]
        public string Identificador => "BPJDEC";

        [MaxLength(14)]
        public string CNPJ
        {
            get
            {
                return string.Join("", Regex.Split(cNPJ, @"[^\d]"));
            }
            set => cNPJ = value;
        }

        [MaxLength(150)]
        public string NomeEmpresarial { get; set; }




    }
}
