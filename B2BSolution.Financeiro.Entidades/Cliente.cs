
using System.Runtime.Serialization;

namespace B2BSolution.Financeiro.Entidades
{
    [DataContract]
    public class Cliente
    {
        [Atributo("id_cliente")]
        [DataMember(Name = "id_cliente")]
        public int IdCliente { get; set; }

        [Atributo("DOCUMENTO")]
        [DataMember(Name = "DOCUMENTO")]
        public string Documento { get; set; }

        [Atributo("nome")]
        [DataMember(Name = "nome")]
        public string Nome { get; set; }

        [Atributo("tp_pessoa")]
        [DataMember(Name = "tp_pessoa")]
        public string TipoPessoa { get; set; }

        [Atributo("id_endereco")]
        [DataMember(Name = "id_endereco")]
        public Endereco Endereco { get; set; }

        [Atributo("id_contato")]
        [DataMember(Name = "id_contato")]
        public Contato Contato { get; set; }

        [Atributo("fl_ativo")]
        [DataMember(Name = "fl_ativo")]
        public bool Ativo { get; set; }
    }
}
