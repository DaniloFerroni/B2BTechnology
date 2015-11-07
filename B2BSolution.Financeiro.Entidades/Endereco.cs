
using System.Runtime.Serialization;

namespace B2BSolution.Financeiro.Entidades
{
    [DataContract]
    public class Endereco
    {
        [Atributo("id_endereco")]
        [DataMember(Name = "id_endereco")]
        public int IdEndereco { get; set; }

        [Atributo("rua")]
        [DataMember(Name = "rua")]
        public string Rua { get; set; }

        [Atributo("numero")]
        [DataMember(Name = "numero")]
        public string Numero { get; set; }

        [Atributo("complemento")]
        [DataMember(Name = "complemento")]
        public string Complemento { get; set; }

        [Atributo("cep")]
        [DataMember(Name = "cep")]
        public string Cep { get; set; }

        [Atributo("bairro")]
        [DataMember(Name = "bairro")]
        public string Bairro { get; set; }

        [Atributo("cidade")]
        [DataMember(Name = "cidade")]
        public string Cidade { get; set; }

        [Atributo("estado")]
        [DataMember(Name = "estado")]
        public string Estado { get; set; }
    }
}
