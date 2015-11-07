
using System.Runtime.Serialization;

namespace B2BSolution.Financeiro.Entidades
{
    [DataContract]
    public class Contato
    {
        [Atributo("id_contato")]
        [DataMember(Name = "id_contato")]
        public int IdContato { get; set; }

        [Atributo("NOME_CONTATO")]
        [DataMember(Name = "NOME_CONTATO")]
        public string Nome { get; set; }

        [Atributo("email")]
        [DataMember(Name = "email")]
        public string Email { get; set; }

        [Atributo("telefone")]
        [DataMember(Name = "telefone")]
        public string Telefone { get; set; }

        [Atributo("celular")]
        [DataMember(Name = "celular")]
        public string Celular { get; set; }
    }
}
