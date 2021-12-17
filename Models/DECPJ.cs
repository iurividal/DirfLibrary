using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DirfLibrary.Models
{
    public class DECPJ
    {

        public string Identificador => "DECPJ";

        [MaxLength(14)]
        public string CNPJ { get; set; }

        [MaxLength(150)]
        public string NomeEmpresarial { get; set; }

        /// <summary>
        /// 0 – Pessoa jurídica de direito privado
        ///1 – Órgãos, autarquias e fundações da administração pública federal
        ///2 – Órgãos, autarquias e fundações da administração pública estadual, municipal ou do Distrito Federal
        ///3 – Empresa pública ou sociedade de economia mista federal
        ///4 – Empresa pública ou sociedade de economia mista estadual, municipal ou do Distrito Federal
        ///8 – Entidade com alteração de natureza jurídica (uso restrito)
        /// </summary>
        [MaxLength(1)]
        public int NaturarezaDeclarante { get; set; }


        [MaxLength(11)]
        public string CPFResponsavel { get; set; }

        /// <summary>
        /// S - Sócio ostensivo
        /// N – Sócio ostensivo Não é sócio ostensivo
        /// </summary>
        [MaxLength(1)]
        public string Indicador06 { get; set; }


        /// <summary>
        /// Indicador de declarante depositário de crédito decorrente de decisão judicial
        /// S -- Depositário de crédito decorrente de descisao judicial
        /// N –– Depositá Não é depositário de crédito decorrente de decisão judicial
        /// </summary>
        [MaxLength(1)]
        public string Indicador07 { get; set; }


        /// <summary>
        /// Indicador de declarante de instituição  administradora ou intermediadora de fundo ou clube de investimento
        /// 
        /// </summary>
        [MaxLength(1)]
        public string Indicador08 { get; set; }

        /// <summary>
        /// indicador de declarante de rendimentos pagos  a residentes ou domiciliados no exterio
        /// </summary>
        [MaxLength(1)]
        public string Indicador09 { get; set; }

        /// <summary>
        /// Indicador de plano privado de assistência à   saúde – coletivo empresarial
        /// </summary>
        [MaxLength(1)]
        public string Indicador10 { get; set; }

        /// <summary>
        /// Indicador de entidade em que a União detém
        ///maioria do capital social sujeito a voto, recebe
        ///recursos do Tesouro Nacional e está obrigada
        ///a registrar a execução orçamentária no Siafi
        ///(IN 1.234/2012, art. 4º, incisos III e IV)
        /// </summary>
        [MaxLength(1)]
        public string Indicador11 { get; set; }


        /// <summary>
        /// Indicador de fundação pública de direito privado instituída pela União, Estados, Municípios ou Distrito Federal
        /// </summary>
        [MaxLength(1)]
        public string Indicador12 { get; set; }

        /// <summary>
        /// Indicador de situação especial da declaração
        /// </summary>
        [MaxLength(1)]
        public string Indicador13 { get; set; }


        [MaxLength(8)]
        public string DataEvento { get; set; }

        /// <summary>
        /// 1 – Encerramento de espólio
        /// 2 – Saída definitiva do Brasil
        /// </summary>
        [MaxLength(1)]
        public string TipoEvento { get; set; }
    }


}
