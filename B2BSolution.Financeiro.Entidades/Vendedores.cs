using System.Runtime.Serialization;

namespace B2BSolution.Financeiro.Entidades
{
    [DataContract]
    public class Vendedores
    {
        [Atributo("ID_VENDEDOR_V")]
        [DataMember(Name = "ID_VENDEDOR_V")]
        public int IdVendedor { get; set; }

        [Atributo("ID_ENDERECO_VENDENDOR")]
        [DataMember(Name = "ID_ENDERECO_VENDENDOR")]
        public Endereco Endereco { get; set; }

        [Atributo("ID_CONTATO_VENDEDOR")]
        [DataMember(Name = "ID_CONTATO_VENDEDOR")]
        public Contato Contato { get; set; }

        [Atributo("NOME_VENDEDOR")]
        [DataMember(Name = "NOME_VENDEDOR")]
        public string Nome { get; set; }

        [Atributo("DOCUMENTO_VENDEDOR")]
        [DataMember(Name = "DOCUMENTO_VENDEDOR")]
        public string Documento { get; set; }

        [Atributo("COMISSAO_VENDEDOR")]
        [DataMember(Name = "COMISSAO_VENDEDOR")]
        public decimal Comissao { get; set; }

        [Atributo("TP_VENDEDOR")]
        [DataMember(Name = "TP_VENDEDOR")]
        public int TipoVendedor { get; set; }

        [Atributo("FL_ATIVO_VENDEDOR")]
        [DataMember(Name = "FL_ATIVO_VENDEDOR")]
        public bool Ativo { get; set; }

        [Atributo("ID_SUPERIOR")]
        [DataMember(Name = "ID_SUPERIOR")]
        public int Superior { get; set; }
    }
}
