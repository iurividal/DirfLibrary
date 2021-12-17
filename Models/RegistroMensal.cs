using System;

namespace DirfLibrary.Models
{
    public class RegistroMensal
    {
        private string janeiro;
        private string fevereiro;
        private string marco;
        private string abril;
        private string maio;
        private string junho;
        private string julho;
        private string agosto;
        private string setembro;
        private string outubro;
        private string novembro;
        private string dezembro;
        private string decimoTerceiro;


        public RegistroMensal(decimal? janeiro, decimal? fevereiro, decimal? marco, decimal? abril, decimal? maio, decimal? junho, decimal? julho, decimal? agosto, decimal? setembro, decimal? outubro, decimal? novembro, decimal? dezembro, decimal? decimoTerceiro)
        {
            this.janeiro = FormataValor(janeiro);
            this.fevereiro = FormataValor(fevereiro);
            this.marco = FormataValor(marco);
            this.abril = FormataValor(abril);
            this.maio = FormataValor(maio);
            this.junho = FormataValor(junho);
            this.julho = FormataValor(julho);
            this.agosto = FormataValor(agosto);
            this.setembro = FormataValor(setembro);
            this.outubro = FormataValor(outubro);
            this.novembro = FormataValor(novembro);
            this.dezembro = FormataValor(dezembro);
            this.decimoTerceiro = FormataValor(decimoTerceiro);
        }

        public string Janeiro { get => janeiro; set => janeiro = value; }
        public string Fevereiro { get => fevereiro; set => fevereiro = value; }
        public string Marco { get => marco; set => marco = value; }
        public string Abril { get => abril; set => abril = value; }
        public string Maio { get => maio; set => maio = value; }
        public string Junho { get => junho; set => junho = value; }
        public string Julho { get => julho; set => julho = value; }
        public string Agosto { get => agosto; set => agosto = value; }
        public string Setembro { get => setembro; set => setembro = value; }
        public string Outubro { get => outubro; set => outubro = value; }
        public string Novembro { get => novembro; set => novembro = value; }
        public string Dezembro { get => dezembro; set => dezembro = value; }
        public string DecimoTerceiro { get => decimoTerceiro; set => decimoTerceiro = value; }

        private string FormataValor(decimal? valor)
        {
            if (valor == null || valor == 0)
                return "";

            var x = string.Format("{0:0.00}", valor).Replace(",","");

            

            return x;
        }
    }
}
