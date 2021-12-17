using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DirfLibrary.Models;

namespace DirfLibrary
{
    public class Repository
    {

        public DIRFModel Header(int anoReferencia, int anoCalendario)
        {
            DIRFModel model = new DIRFModel();

            model.DIRF = new DIRF
            {
                AnoReferencia = anoReferencia,
                AnoCalendario = anoCalendario,
                IndicadorRetificadora = "N",
                NumeroRecibo = ""
            };

            model.RESPO = new RESPO
            {
                CPF = "30437498808",
                Nome = "ELLEN RODRIGUES TARCHIANI CAMARGO",
                DDD = "11",
                Telefone = "40229928",
                Ramal = "2082",
                CorreioEletonico = "CONTABILIDADE@ADMCONSORCIO.COM.BR"
            };

            return model;

        }

        public DIRFModel MontarDIRF()
        {

            DIRFModel model = new DIRFModel();

            model.DIRF = new DIRF
            {
                AnoReferencia = 2021,
                AnoCalendario = 2020,
                IndicadorRetificadora = "N",
                NumeroRecibo = ""
            };

            model.RESPO = new RESPO
            {
                CPF = "30437498808",
                Nome = "ELLEN RODRIGUES TARCHIANI CAMARGO",
                DDD = "11",
                Telefone = "40229928",
                Ramal = "2082",
                CorreioEletonico = "CONTABILIDADE@ADMCONSORCIO.COM.BR"
            };

            model.DECPJ = new DECPJ
            {
                CNPJ = "56360266000108",
                NomeEmpresarial = "VALTRA ADMINISTRADORA DE CONSORCIOS LTDA",
                NaturarezaDeclarante = 0,
                CPFResponsavel = "79504000800",
                Indicador06 = "N",
                Indicador07 = "N",
                Indicador08 = "N",
                Indicador09 = "N",
                Indicador10 = "S",
                Indicador11 = "N",
                Indicador12 = "N",
                Indicador13 = "N",

            };


            model.IDREC = new List<IDREC>
            {
                new IDREC("0588")
            };


            model.BPFDECList = new List<BPFDECModels>();

            //ESSA PARTE DEVE SER PREENCHIDA COM OS DADOS DE PAGAMENTO

            BPFDECModels items = new BPFDECModels();

            items.BPFDEC = new BPFDEC
            {
                CPF = "00510981054",
                Nome = "LEONARDO EMERSON LAZZARIN",
                DataLaudo = "",
                Indenficador05 = "S",
                Indenficador06 = "S"

            };

            items.RTRT = new RTRT
            {
                RegistroMensal = new RegistroMensal(1000, 2000, null, null, null, null, null, null, null, null, null, null, null)
            };

            items.RTIRF = new RTIRF
            {
                RegistroMensal = new RegistroMensal(0, 7.20m, null, null, null, null, null, null, null, null, null, null, null)
            };


            model.BPFDECList.Add(items);

            return model;
        }


        public RESPO RESPO(string owner)
        {


            switch (owner.ToLower())
            {
                case "cmc":
                case "cnv":
                case "cnmf":
                    return new RESPO
                    {
                        CPF = "30437498808",
                        Nome = "ELLEN RODRIGUES TARCHIANI CAMARGO",
                        DDD = "11",
                        Telefone = "40229928",
                        Ramal = "2082",
                        Fax = "",
                        CorreioEletonico = "CONTABILIDADE@ADMCONSORCIO.COM.BR"
                    };


                default:
                    return new RESPO();

            }
        }


        public DECPJ DECPJ(string owner)
        {
            switch (owner.ToLower())
            {
                case "cmc":
                    return new DECPJ
                    {
                        CNPJ = "04250224000293",
                        NomeEmpresarial = "MAGGI ADMINISTRADORA DE CONSORCIOS LTDA",
                        NaturarezaDeclarante = 0,
                        CPFResponsavel = "79504000800",
                        Indicador06 = "N",
                        Indicador07 = "N",
                        Indicador08 = "N",
                        Indicador09 = "N",
                        Indicador10 = "S",
                        Indicador11 = "N",
                        Indicador12 = "N",
                        Indicador13 = "N",
                        DataEvento = ""
                    };
                case "cnv":
                    return new DECPJ
                    {
                        CNPJ = "56360266000108",
                        NomeEmpresarial = "VALTRA ADMINISTRADORA DE CONSORCIOS LTDA",
                        NaturarezaDeclarante = 0,
                        CPFResponsavel = "79504000800",
                        Indicador06 = "N",
                        Indicador07 = "N",
                        Indicador08 = "N",
                        Indicador09 = "N",
                        Indicador10 = "S",
                        Indicador11 = "N",
                        Indicador12 = "N",
                        Indicador13 = "N",
                        DataEvento = ""

                    };
                case "cnmf":
                    return new DECPJ
                    {
                        CNPJ = "45793395000165",
                        NomeEmpresarial = "MASSSEY FERGUSON ADMINISTRADORA DE CONSORCIOS LTDA",
                        NaturarezaDeclarante = 0,
                        CPFResponsavel = "79504000800",
                        Indicador06 = "N",
                        Indicador07 = "N",
                        Indicador08 = "N",
                        Indicador09 = "N",
                        Indicador10 = "S",
                        Indicador11 = "N",
                        Indicador12 = "N",
                        Indicador13 = "N",
                        DataEvento = ""
                    };
                default:
                    return new DECPJ();

            }
        }

        public void EscreverArquivo(DIRFModel model, string filePath)
        {
            //var model = MontarDIRF();

            var path = filePath;

            using (StreamWriter stream = new StreamWriter(path, true))
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine($"{model.DIRF.Identificador}|{model.DIRF.AnoReferencia}|{model.DIRF.AnoCalendario}|{model.DIRF.IndicadorRetificadora}|{model.DIRF.NumeroRecibo}|{model.DIRF.IdentificadorEstrutaLayout}|");

                sb.AppendLine($"{model.RESPO.Identificador}|{model.RESPO.CPF}|{model.RESPO.Nome}|{model.RESPO.DDD}|{model.RESPO.Telefone}|{model.RESPO.Ramal}|{model.RESPO.Fax}|{model.RESPO.CorreioEletonico}|");

                sb.AppendLine($"{model.DECPJ.Identificador}|{ model.DECPJ.CNPJ}|{model.DECPJ.NomeEmpresarial }|{model.DECPJ.NaturarezaDeclarante}|{model.DECPJ.CPFResponsavel}|{model.DECPJ.Indicador06}|{model.DECPJ.Indicador07}|{model.DECPJ.Indicador08}|{model.DECPJ.Indicador09}|{model.DECPJ.Indicador10}|{model.DECPJ.Indicador11}|{model.DECPJ.Indicador12}|{model.DECPJ.Indicador13}|{model.DECPJ.DataEvento}|");


                foreach (var idrec in model.IDREC.OrderBy(a=>a.CodigoReceita))
                {
                    sb.AppendLine($"{idrec.Identificador}|{idrec.CodigoReceita}|");


                    if (model.BPFDECList != null)
                        foreach (var item in model.BPFDECList.OrderBy(a => a.BPFDEC.CPF))
                        {


                            sb.AppendLine($"{item.BPFDEC.Idenficador}|{item.BPFDEC.CPF}|{item.BPFDEC.Nome}|{item.BPFDEC.DataLaudo}|{item.BPFDEC.Indenficador05}|{item.BPFDEC.Indenficador06}|");

                            if (IsEscreveRegistroMensal(item.RTRT.RegistroMensal))
                                sb.AppendLine($"{item.RTRT.Identificador}|{item.RTRT.RegistroMensal.Janeiro}|{item.RTRT.RegistroMensal.Fevereiro}|{item.RTRT.RegistroMensal.Marco}|{item.RTRT.RegistroMensal.Abril}|{item.RTRT.RegistroMensal.Maio}|{item.RTRT.RegistroMensal.Junho}|{item.RTRT.RegistroMensal.Julho}|{item.RTRT.RegistroMensal.Agosto}|{item.RTRT.RegistroMensal.Setembro}|{item.RTRT.RegistroMensal.Outubro}|{item.RTRT.RegistroMensal.Novembro}|{item.RTRT.RegistroMensal.Dezembro}|{item.RTRT.RegistroMensal.DecimoTerceiro}|");

                            if (IsEscreveRegistroMensal(item.RTIRF.RegistroMensal))
                                sb.AppendLine($"{item.RTIRF.Idenficiador}|{item.RTIRF.RegistroMensal.Janeiro}|{item.RTIRF.RegistroMensal.Fevereiro}|{item.RTIRF.RegistroMensal.Marco}|{item.RTIRF.RegistroMensal.Abril}|{item.RTIRF.RegistroMensal.Maio}|{item.RTIRF.RegistroMensal.Junho}|{item.RTIRF.RegistroMensal.Julho}|{item.RTIRF.RegistroMensal.Agosto}|{item.RTIRF.RegistroMensal.Setembro}|{item.RTIRF.RegistroMensal.Outubro}|{item.RTIRF.RegistroMensal.Novembro}|{item.RTIRF.RegistroMensal.Dezembro}|{item.RTIRF.RegistroMensal.DecimoTerceiro}|");

                        }

                    if (model.BPJDECList != null)
                        foreach (var item in model.BPJDECList.OrderBy(a => a.BPJDEC.CNPJ))
                        {
                            sb.AppendLine($"{item.BPJDEC.Identificador}|{item.BPJDEC.CNPJ}|{item.BPJDEC.NomeEmpresarial}|");

                            if (IsEscreveRegistroMensal(item.RTRT.RegistroMensal))
                                sb.AppendLine($"{item.RTRT.Identificador}|{item.RTRT.RegistroMensal.Janeiro}|{item.RTRT.RegistroMensal.Fevereiro}|{item.RTRT.RegistroMensal.Marco}|{item.RTRT.RegistroMensal.Abril}|{item.RTRT.RegistroMensal.Maio}|{item.RTRT.RegistroMensal.Junho}|{item.RTRT.RegistroMensal.Julho}|{item.RTRT.RegistroMensal.Agosto}|{item.RTRT.RegistroMensal.Setembro}|{item.RTRT.RegistroMensal.Outubro}|{item.RTRT.RegistroMensal.Novembro}|{item.RTRT.RegistroMensal.Dezembro}|{item.RTRT.RegistroMensal.DecimoTerceiro}|");

                            if (IsEscreveRegistroMensal(item.RTIRF.RegistroMensal))
                                sb.AppendLine($"{item.RTIRF.Idenficiador}|{item.RTIRF.RegistroMensal.Janeiro}|{item.RTIRF.RegistroMensal.Fevereiro}|{item.RTIRF.RegistroMensal.Marco}|{item.RTIRF.RegistroMensal.Abril}|{item.RTIRF.RegistroMensal.Maio}|{item.RTIRF.RegistroMensal.Junho}|{item.RTIRF.RegistroMensal.Julho}|{item.RTIRF.RegistroMensal.Agosto}|{item.RTIRF.RegistroMensal.Setembro}|{item.RTIRF.RegistroMensal.Outubro}|{item.RTIRF.RegistroMensal.Novembro}|{item.RTIRF.RegistroMensal.Dezembro}|{item.RTIRF.RegistroMensal.DecimoTerceiro}|");

                        }
                }

                model.FIMDIRF = new FIMDIRF();

                sb.AppendLine($"{model.FIMDIRF.Identificador}|");


                stream.WriteLine(sb.ToString());
                stream.Flush();
                stream.Close();
            }



        }

        private bool IsEscreveRegistroMensal(RegistroMensal registro)
        {



            foreach (var xPropertyInfo in registro.GetType().GetProperties())
            {
                PropertyInfo propertyInfo = registro.GetType().GetProperty(xPropertyInfo.Name);

                if (propertyInfo == null) continue;

                var value = xPropertyInfo.GetValue(registro);

                if (!string.IsNullOrEmpty((string)value) && ((string)value) != "0")
                    return true;
            }

            return false;


        }

        private static object ChangeType(object value, Type conversion)
        {
            var t = conversion;

            if (t.IsGenericType && t.GetGenericTypeDefinition().Equals(typeof(Nullable<>)))
            {
                if (value == null)
                {
                    return null;
                }

                t = Nullable.GetUnderlyingType(t);
            }

            return Convert.ChangeType(value, t);
        }
    }
}
